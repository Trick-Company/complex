using ComplexProject.Data;
using ComplexProject.Services;
using ComplexProject.Sevices;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IFieldService, FieldService>();
builder.Services.AddDbContext<ComplexContext>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().
    AddEntityFrameworkStores<ComplexContext>();

builder.Services.AddScoped<IAccountService,AccountService>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireDigit = false;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
