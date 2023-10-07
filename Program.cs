using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static project.Model.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
string myconstring=builder.Configuration.GetConnectionString("myconstring").ToString();
builder.Services.AddDbContext<Appdbcontext>(Options=> Options.UseSqlServer());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
