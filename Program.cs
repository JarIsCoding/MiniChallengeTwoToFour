using MiniChallengeTwoToFour.Services.GreaterOrLessThan;
using MiniChallengeTwoToFour.Services.Sum;
using MiniChallengeTwoToFour.Services.WokeUp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISumService, SumService>();
builder.Services.AddScoped<IGreaterOrLessThanService, GreaterOrLessThanService>();
builder.Services.AddScoped<IWokeUpService, WokeUpService>();

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
