using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>( opt =>
    {
        opt.UseInMemoryDatabase("Answer");
        opt.UseInMemoryDatabase("Course");
        opt.UseInMemoryDatabase("Exam");
        opt.UseInMemoryDatabase("Question");
        opt.UseInMemoryDatabase("ReviewHistory");
        opt.UseInMemoryDatabase("Semester");
        opt.UseInMemoryDatabase("Student");
        opt.UseInMemoryDatabase("StudentAnswer");
        opt.UseInMemoryDatabase("StudentCourse");
        opt.UseInMemoryDatabase("Teacher");
        opt.UseInMemoryDatabase("Topic");
        opt.UseInMemoryDatabase("TopicReview");
    }
);

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
