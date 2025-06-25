using Backend.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<IPeopleService, PeopleService>();

//Inyectamos la interfaz IPeopleService por medio de un KeyedSingleton
builder.Services.AddKeyedSingleton<IPeopleService, PeopleService>("peopleService");

builder.Services.AddKeyedSingleton<IRandomService, RandomService>("randomSingleton");
builder.Services.AddKeyedScoped<IRandomService, RandomService>("randomScoped");
builder.Services.AddKeyedTransient<IRandomService, RandomService>("randomTransient");

//Inyectamos la interfaz IPostService por medio de un KeyedScoped
builder.Services.AddScoped<IPostService, PostService>();

// Inyectamos una configuración inicial para el HttpClient para usar en cualquier servicio que implemente IPostService
builder.Services.AddHttpClient<IPostService, PostService>(c =>
{
    //Configuramos el HttpClient con una URL base
    c.BaseAddress = new Uri(builder.Configuration["BaseUrlPost"]);
});

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

app.UseAuthorization();

app.MapControllers();

app.Run();
