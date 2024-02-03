using BussinesLayer.Content;
using BussinesLayer.Services;
using DataLayer;
using DataLayer.Abstract;
using DataLayer.EntitiyFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//proje baslarken db verilerini ayaða getiren alan.
builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("ctrsvr")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAbout, EFAbout>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContact, EFContact>();
builder.Services.AddScoped<IMessageService, MessageManager>();
builder.Services.AddScoped<IMessage, EFMessage>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IService, EFService>();
builder.Services.AddScoped<ISkillService, SkillManager>();
builder.Services.AddScoped<ISkill, EFSkill>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMedia, EFSocialMedia>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IPortfolio, EFPortfolio>();












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

app.UseAuthorization();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
