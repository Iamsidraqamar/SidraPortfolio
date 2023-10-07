using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;
using static project.Model.Data;

namespace project.Pages.myadmin;

public class ShowEducationModel : PageModel
{
    Appdbcontext db;
    public List<Education> Educations { get; set; }
    public ShowEducationModel(Appdbcontext _db)
    {
      db = _db;
    }
    public void OnGet()
    {
      Educations = db.tbl_Education.ToList();
    }
    public IActionResult OnGetDelete(int Id)
    {
      var ItemToDel=db.tbl_Education.Find(Id);
      db.tbl_Education.Remove(ItemToDel);
      db.savechanges();
      return RedirectToPage("ShowEducation");
    }
}

