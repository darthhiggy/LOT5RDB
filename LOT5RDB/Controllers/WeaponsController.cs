using LOT5RDB.Equipment.Shared.Weapons.Models;
using LOT5RDB.Equipment.Shared.Weapons.Queries;
using LOT5RDB.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace LOT5RDB.Controllers;

public class WeaponsController : Controller
{
    private readonly IMediator _mediator;
    public WeaponsController(IMediator mediator)
    {
        _mediator = mediator;

    }
    // GET
    public async Task<IActionResult> Index(string sortOrder, string currentFilter, string? searchString, int? pageNumber)
    {
        ViewData["CurrentSort"] = sortOrder;
        ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        var weapons = await _mediator.Send(new GetWeaponsQuery());
        weapons = FilterBySearchString(weapons, searchString);
        
        if(searchString != null)
        {
            pageNumber = 1;
        }
        else
        {
            searchString = currentFilter;
        }
        
        weapons = SortWeapons(weapons, sortOrder);

        return View(WeaponsViewModel.Create(weapons, pageNumber ?? 1, 5));
    }

    private static List<WeaponModel> FilterBySearchString(List<WeaponModel> weapons, string? searchString)
    {
        if(String.IsNullOrWhiteSpace(searchString))
        {
            return weapons;
        }

        return weapons.Where(w => w.Name.ToUpper().Contains(searchString.ToUpper())
                                  || w.Qualities.Any(q => q.Name.ToUpper().Contains(searchString.ToUpper()))
                                  || w.Skill.Name.ToUpper().Contains(searchString.ToUpper())).ToList();
    }

    private List<WeaponModel> SortWeapons(List<WeaponModel> weapons, string sortOrder)
    {
        switch (sortOrder)
        {
            case "name_desc":
                return weapons.OrderByDescending(w => w.Name).ToList();
            default:
                return weapons.OrderBy(w => w.Name).ToList();
        }
    }
}
