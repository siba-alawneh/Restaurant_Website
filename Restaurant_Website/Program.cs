using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Restaurant_Website.Data;
using Restaurant_Website.Data.Interceptors;
using Restaurant_Website.Helpers.Email;
using Restaurant_Website.Helpers.File;
using Restaurant_Website.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//*
//scaffold-dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Data Source=SIBA\SQL2025;Initial Catalog=Restaurant_Last_20260915;User ID=sa;Password=123;Trust Server Certificate=True" -OutputDir Models
//*/


builder.Services.AddDbContext<DataDbContext>(x =>
x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
.AddInterceptors(new SoftDeleteInterceptor()));


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddSingleton<IEmailHelper, EmailHelper>();
builder.Services.AddSingleton<IFileHelper, FileHelper>();


builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DataDbContext>();

//IDENTITY CONFIG
builder.Services.Configure<IdentityOptions>(x => {
    x.Password.RequiredUniqueChars = 0;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequiredLength = 3;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireDigit = false;
});

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/Admin/Account/Login";
    x.LogoutPath = "/Admin";
    x.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    x.SlidingExpiration = true;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
