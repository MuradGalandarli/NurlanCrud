using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Student.DataAccessLayer;
using Student.EntityLayer;
using System;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
/*
private readonly ApplicationDbContext _applicationDbContext;
string connectionString = string.Empty;

public CommonService(ApplicationDbContext applicationDbContext)
{
    _applicationDbContext = applicationDbContext;
    connectionString = _applicationDbContext.Database.GetDbConnection().ConnectionString;
}
*/
/*

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Student.DataAccessLayer.AppContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("PgDbConnection"));
});*/



/*var connectionString = builder.Configuration.GetConnectionString("PgDbConnection");
builder.Services.AddDbContext<Student.DataAccessLayer.AppContext>(options =>
{
    options.UseNpgsql(connectionString);
});
*/

/*builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("PgConnection"))
);
*/

/*builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(opt =>

    opt.UseNpgsql(builder.Configuration.GetConnectionString("PgConnection")));

*/


builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("PgConnection")));


/*
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(opt =>

    opt.UseNpgsql(builder.Configuration.GetConnectionString("PgConnection")));

*/
/*
builder.Services.AddDbContext<AppContext>(options =>
           options.UseNpgsql(builder.Configuration.GetConnectionString("PgConnection")));
*/



// Add services to the container.
builder.Services.AddRazorPages();

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
