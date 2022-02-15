using TFWAPIFixed.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DBContext")));
string AllowOrigins = "AllowOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowOrigins,
                      builder =>
                      {
                          /*  builder.WithOrigins("https://www.ordinaryGeeks.com/transformativeWorkoutlife.com/",
                                                "https://www.ordinaryGeeks.com/",
                                                "https://ordinaryGeeks.com")
                          */
                          builder.AllowAnyOrigin()
                             .AllowAnyHeader()
                                        .AllowAnyMethod();
                      });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors(AllowOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
