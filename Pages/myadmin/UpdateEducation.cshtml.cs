using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using static project.Model.Data;
namespace project.Pages.myadmin;
{
public class UpdateEducationModel : PageModel
{
    Appdbcontext db;
    public Education education{get;set;}
    public UpdateEducationModel(Appdbcontext _db)
    {
        db=_db;
    }
    public void OnGet(int Id)
    {
        education = db.tbl_Education.Find(Id);
         
    }

    public IActionResult OnPost(Education education)
    {
        db.tbl_Education.Update(education);
        db.savechanges();
        return RedirectToPage("ShowEducation");

    }
   
}
}