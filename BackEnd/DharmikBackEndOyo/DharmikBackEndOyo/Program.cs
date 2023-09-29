using DharmikBackEndOyo.Sertvices.City;
using DharmikBackEndOyo.Sertvices.DharmashalaRoomTypes;
using DharmikBackEndOyo.Sertvices.Dharmshala;
using DharmikBackEndOyo.Sertvices.Facilites;
using DharmikBackEndOyo.Sertvices.Query;
using DharmikBackEndOyo.Sertvices.State;
using DharmikBackEndOyo.Sertvices.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IDharmshalaRoomTypesService,DharmshalaRoomTypesService>();
builder.Services.AddScoped<IDharmshalaService, DharmshalaService>();
builder.Services.AddScoped<IFacilitesService, FacilitesService>();
builder.Services.AddScoped<IQueryService, QueryService>();
builder.Services.AddScoped<IStateService,StateService>();
builder.Services.AddScoped<IUserService, UserService>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


