using LOT5RDB.Models;
using LOT5RDB.Skills.Shared.Models;
using LOT5RDB.Skills.Shared.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LOT5RDB.Controllers;

public class SkillsController : Controller
{
    private readonly IMediator _mediator;
    public SkillsController(IMediator mediator)
    {
        _mediator = mediator;

    }
    // GET
    public async Task<IActionResult> Index(string sortOrder, string currentFilter, string? searchString, int? pageNumber)
    {
        ViewData["CurrentSort"] = sortOrder;
        ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        ViewData["GroupSortParam"] = sortOrder == "Skill Group" ? "group_desc" : "Skill Group";
        var skills = await _mediator.Send(new GetSkillsQuery());
        if(!String.IsNullOrEmpty(searchString))
        {
            skills = skills.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())
                                       || s.SkillGroup.Name.ToUpper().Contains(searchString.ToUpper()))
                .ToList();
        }

        if(searchString != null)
        {
            pageNumber = 1;
        }
        else
        {
            searchString = currentFilter;
        }

        List<SkillModel> sortedSkills;
        switch (sortOrder)
        {
            case "name_desc":
                sortedSkills = skills.OrderByDescending(s => s.Name).ToList();
                break;
            case "Skill Group":
                sortedSkills = skills.OrderBy(s => s.SkillGroup.Name).ToList();
                break;
            case "group_desc":
                sortedSkills = skills.OrderByDescending(s => s.SkillGroup.Name).ToList();
                break;
            default:
                sortedSkills = skills.OrderBy(s => s.Name).ToList();
                break;
        }
        return View(SkillsViewModel.Create(sortedSkills, pageNumber ?? 1, 5));
    }
    
    
}
