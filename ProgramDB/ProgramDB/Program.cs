
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
    // получаем объекты из бд и выводим на консоль
    var tablica = db.tablica.ToList();
    Console.WriteLine("tablica list:");
    foreach (DBClass u in tablica)
    {
        Console.WriteLine($"{u.Id} {u.time}");
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
