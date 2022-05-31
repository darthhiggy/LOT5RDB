using LOT5RDB.Skills.Shared.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LOT5RDB.Models;

public class SkillsViewModel : PageModel
{
    public SkillsViewModel(List<SkillModel> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int) Math.Ceiling(count / (double) pageSize);

        Skills = items;
    }

    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }
    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;
    public List<SkillModel> Skills { get; set; }

    public static SkillsViewModel Create(List<SkillModel> source, int pageIndex, int pageSize)
    {
        var count = source.Count;
        var items = source.Skip((pageIndex-1) * pageSize).Take(pageSize).ToList();
        return new SkillsViewModel(items, count, pageIndex, pageSize);
    }
}
