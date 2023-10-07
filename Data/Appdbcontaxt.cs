using Microsoft.EntityFrameworkCore;

namespace project.Model{
    public class Data
    {
public class Appdbcontext: DbContext
{
    public Appdbcontext(DbContextOptions<Appdbcontext>options): base(options)
    {

    }
    //properties  to create database.
    public DbSet<Contactus> tbl_contact{get;set;}
    public DbSet<Education> tbl_Education{get;set;}
    public DbSet<Experience> tbl_Experience{get;set;}
    
    public DbSet<Facts> tbl_Facts{get;set;}
    
    public DbSet<Profile> tbl_Profile{get;set;}
    
    public DbSet<services> tbl_services{get;set;}
    public DbSet<skills> tbl_skills{get;set;}
    
    public DbSet<socialnetworks> tbl_social{get;set;}
    
    public DbSet<Testimonial> tbl_Testimonial{get;set;}

            internal void savechanges()
            {
                throw new NotImplementedException();
            }
        }


    }
}