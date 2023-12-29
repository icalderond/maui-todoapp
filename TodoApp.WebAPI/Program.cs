using Microsoft.EntityFrameworkCore;
using TodoApp.WebAPI.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodoEFContext>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    TodoEFContext context = scope.ServiceProvider.GetRequiredService<TodoEFContext>();
    // context.Database.EnsureCreated();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();

