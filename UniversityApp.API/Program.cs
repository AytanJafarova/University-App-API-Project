using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.Mappers;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.UniversityDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UniDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDB"));
    //options.UseNpgsql(builder.Configuration.GetConnectionString("UniDBHome"));
});

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseService, CourseManager>();

builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IAccountService, AccountManager>();

builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
builder.Services.AddScoped<IEnrollmentService, EnrollmentManager>();

builder.Services.AddScoped<IExamRepository, ExamRepository>();
builder.Services.AddScoped<IExamService, ExamManager>();

builder.Services.AddScoped<IPreExamRepository, PreExamRepository>();
builder.Services.AddScoped<IPreExamService, PreExamManager>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentManager>();

builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ITeacherService, TeacherManager>();

builder.Services.AddScoped<IGradeRepository, GradeRepository>();
builder.Services.AddScoped<IGradeService, GradeManager>();

builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<IGroupService, GroupManager>();


builder.Services.AddAutoMapper(typeof(AutoMapperDepartment));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
