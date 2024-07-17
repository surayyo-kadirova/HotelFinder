// In Program.cs for .NET 6 and later
using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.DatabaseContext.Abstract;
using HotelFinder.DatabaseContext.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Register IHotelService with its implementation
builder.Services.AddSingleton<IHotelService, HotelManager>();
builder.Services.AddSingleton<IHotelRepository, HotelRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();