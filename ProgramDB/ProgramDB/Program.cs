
using Microsoft.EntityFrameworkCore;
using ProgramDB.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// получение данных
using (DBContext db = new DBContext())
{
    var table = db.tablica.FromSqlRaw("Select * From Test_Table").ToList();
    /*var table = db.tablica.ToList();*/

    // получаем объекты из бд и выводим на консоль
    Console.WriteLine("Select list:");
    foreach (DBClass u in table)
    {
        Console.WriteLine($"{u.Id} {u.Ms} {u.Kontroller} {u.Sila_tyagi} {u.Napryajenie} {u.Tok_generatora} {u.Tor_kompressora} {u.Temp_gazov_B1} {u.Temp_gazov_A5} {u.Tok_ADT} {u.Vyhod_TNVD} {u.Chastota_vrascheniya}");
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
