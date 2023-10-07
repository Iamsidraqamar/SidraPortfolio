using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using static project.Model.Data;
namespace project.Pages.myadmin;

public class AddEducationModel : PageModel
{
    Appdbcontext db;
    public Education education{get;set;}
    public AddEducationModel(Appdbcontext _db)
    {
        db=_db;
    }
    public void OnGet()
    {

    }
    public IActionResult OnPost( Education education)
    {
    db.tbl_Education.Add(education);
    db.savechanges();
    return RedirectToPage("ShowEducation");
    }
}
