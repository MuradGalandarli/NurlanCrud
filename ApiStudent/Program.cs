using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Student.Bsiness.Abstract;
using Student.Bsiness.Concrete;
using Student.DataAccessLayer;
using Student.DataAccessLayer.Abstract;
using Student.DataAccessLayer.Concrete;
using Student.DataAccessLayer.RepositoryEF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ApplicationDbContext, ApplicationDbContext>();
builder.Services.AddScoped<IRepositoryEFStudent, RepositoryEFStudentDal>();
builder.Services.AddScoped<IStudentManagercs,StudentManager>();
builder.Services.AddScoped<ICourseManager, CourseManager>();
builder.Services.AddScoped<IRepositoryEFCourse, RepositoryEFCourseDal>();
builder.Services.AddScoped<IRepositoryEFTeacher, ReposiyoryEFTeacherDal>();
builder.Services.AddScoped<ITeacherManager, TeacherManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
