using FluentValidation.AspNetCore;
using LShopSolution.Admin.Services;
using LShopSolution.Authen.Users;
using LShopSolution.ViewModels.Authen.Users;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>()); ;
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IUserApiClient, UserApiClient>();
//builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = "/Login/Index";
    options.AccessDeniedPath = "/";
});
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
#if DEBUG
if (app.Environment.IsDevelopment())
{
    var mvcBuilder = builder.Services.AddRazorPages();

    if (builder.Environment.IsDevelopment())
    {
        mvcBuilder.AddRazorRuntimeCompilation();
    }
}
#endif
//builder.Servicesx
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();
app.UseSession(); //chay truoc MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
