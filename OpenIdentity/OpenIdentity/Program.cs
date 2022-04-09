var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var services = builder.Services;

var mapperConfig = new AutoMapper.MapperConfiguration(cfg =>
{
	//Add multipule profiles.
	cfg.AddProfile(new OpenIdentityData.MapperConfiguration());
	cfg.AddProfile(new OpenIdentityService.MapperConfiguration());


});
services.AddSingleton(mapperConfig.CreateMapper());

services.AddOIDatabaseContext(builder.Configuration);

services.AddTransient<IOIUserServiceCommands, OIUserServiceCommands>();
services.AddTransient<IOIUserServiceQueries, OIUserServiceQueries>();
//services.AddTransient<IOITokenServiceCommands, OITokenServiceCommands>();

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
