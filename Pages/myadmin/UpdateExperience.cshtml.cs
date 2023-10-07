using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using static project.Model.Data;
namespace project.Pages.myadmin;
{
public class UpdateExperienceModel : PageModel
{
    Appdbcontext db;
    public Experience experience{get;set;}
    public UpdateExperienceModel(Appdbcontext _db)
    {
        db=_db;
    }
    public void OnGet(int Id)
    {
        experience = db.tbl_Experience.Find(Id);
         
    }

    public IActionResult OnPost(Experience experience)
    {
        db.tbl_Experience.Update(experience);
        db.savechanges();
        return RedirectToPage("ShowExperience");

    }
   
}
}