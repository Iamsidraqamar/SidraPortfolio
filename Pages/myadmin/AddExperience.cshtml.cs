using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using static project.Model.Data;
namespace project.Pages.myadmin;
{
public class AddExperienceModel : PageModel
{
    Appdbcontext db;
    public Experience experience{get;set;}
    public AddExperienceModel(Appdbcontext _db)
    {
        db=_db;
    }
    public void OnGet()
    {

    }
    public IActionResult OnPost( Experience experience)
    {
    db.tbl_Experience.Add(experience);
    db.savechanges();
    return RedirectToPage("ShowEducation");
    }
}
}