using GuessMyAge.Business;
using GuessMyAge.Business.Services;
using GuessMyAge.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GuessMyAgeDbContext>(
    options =>
        options.UseSqlite(x => x.MigrationsAssembly(typeof(GuessMyAgeDbContext).Assembly.FullName)));

builder.Services.Inject().InjectRepositories();
// Tu avais oublié cette ligne pour que ton service fonctionne
builder.Services.AddScoped<IGameService, GameService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseStaticFiles();
app.UseRouting();


app.MapControllers();

app.MapFallbackToFile("wwwroot/index.html"); ;

app.Run();
