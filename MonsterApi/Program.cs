using MonsterApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<MonsterService>(); //esto es para que se pueda inyectar en las clases (injeccion de dependencias)
// builder.Services.AddTransient<MonsterService>(); //esto es para que se cree una nueva instancia cada vez que se inyecte
var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();