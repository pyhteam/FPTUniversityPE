

using FPTUniversityPE.BusinessObject.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.// Add ConnectionString
builder.Services.AddDbContext<FPTUniversityPEContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
));

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
app.UseCors(
	options => options.AllowAnyMethod()
		.AllowAnyHeader()
		.SetIsOriginAllowed(origin => true) // allow any origin
		.AllowCredentials() // for signalR


);
app.UseAuthentication(); // Enable authentication

app.UseAuthorization();

app.MapControllers();

app.Run();
