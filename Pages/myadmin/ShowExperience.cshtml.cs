using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using static project.Model.Data;

namespace project.Pages.myadmin;
{
public class ShowExperienceModel : PageModel
{
    Appdbcontext db;
    public List<Experience> experience{get;set;}
    public ShowExperienceModel(Appdbcontext _db)
    {
      db = _db;
    }
    public void OnGet()
    {
      experience =db.tbl_Experience.ToList();
    }
    public IActionResult OnGetDelete(int Id)
    {
        var ItemToDel=db.tbl_Experience.Find(Id);
        db.tbl_Experience.Remove(ItemToDel);
        db.savechanges();
        return RedirectToPage("ShowExperience");
    }
   
}
}
