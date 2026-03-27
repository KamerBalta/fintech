using Fintech.Business.Abstract;
using Fintech.Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// 1. ADIM: Servisleri Konteynere Ekleyin (Mutfak Aşaması)
// --------------------------------------------------------

// OpenAPI/Swagger desteği
builder.Services.AddOpenApi();
builder.Services.AddControllers(); // API Controller'larını kullanabilmek için bu ŞART.

// Kendi yazdığımız Business servislerini buraya ekliyoruz
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<ITransactionService, TransactionManager>();
builder.Services.AddScoped<ICreditScoreService, CreditScoreManager>();

// --------------------------------------------------------

var app = builder.Build(); // Uygulama (app) burada inşa edilir. Artık servis eklenemez!

// 2. ADIM: HTTP İstek Hattını Yapılandırın (Sunum Aşaması)
// --------------------------------------------------------

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Controller'larımızı rotalara eşleştiriyoruz
app.MapControllers(); 

// Örnek WeatherForecast (İstersen silebilirsin, kalabilir de)
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

// Mevcut record yapısı
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}