using Dal.dalapi;
using Dal.dalImplements;
using Dal;
using Microsoft.Extensions.Configuration;
//using services -בלי האובייקטים והפרופיל של ה בי-אל
using Bl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//IConfiguration config = ConfigurationBuilder.Build();
//AddServicesBl
builder.Services.AddTransient<IStudentBl, StudentServiceBl>();
builder.Services.AddTransient<ITeacherBl, TeacherServiceBl>();
builder.Services.AddServicesBl(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();

