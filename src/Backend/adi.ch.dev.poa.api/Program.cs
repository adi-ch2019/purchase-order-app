var builder = WebApplication.CreateBuilder (args) ;
builder.Configuration.AddJsonFile("appsettings.Development.json");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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

// Retrieve the connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


app.UseAuthorization();

app.MapControllers();

app.Run();
