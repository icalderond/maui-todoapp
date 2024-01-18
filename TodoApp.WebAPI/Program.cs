using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TodoApp.WebAPI.Contexts;
using TodoApp.WebAPI.Data;
using TodoApp.WebAPI.Repositories;
using TodoApp.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodoEFContext>();
builder.Services.AddScoped<IToDoItemRepository, ToDoItemRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ToDoItemWithTagService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    TodoEFContext context = scope.ServiceProvider.GetRequiredService<TodoEFContext>();
    // context.Database.EnsureCreated();
    context.Database.Migrate();
}

app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.Run();