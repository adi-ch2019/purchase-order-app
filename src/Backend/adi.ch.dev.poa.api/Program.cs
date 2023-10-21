using adi.ch.dev.poa.api;
using adi.ch.dev.poa.api.Data;
using adi.ch.dev.poa.api.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder (args) ;

// Retrieve the connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Configuration.AddJsonFile("appsettings.Development.json");
// Database
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddSwaggerGen(options =>
//         {
//             options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
//         });
 builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins("http://localhost:4200") // Replace with your Angular app's URL
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();



app.UseAuthorization();

app.MapControllers();

app.Run();
