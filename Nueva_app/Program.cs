using Microsoft.Extensions.Options;
using Nueva_app.Models;
using Nueva_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<BarSettings>(
    builder.Configuration.GetSection(nameof(BarSettings)));
builder.Services.AddSingleton<IBarSettings>(
    d => d.GetRequiredService<IOptions<BarSettings>>().Value);
builder.Services.AddSingleton<BeerService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();

