using Scalar.AspNetCore;
using TaskService.src.Data;
using TaskService.src.Interface;
using TaskService.src.Repository;

// Crea una instancia de WebApplicationBuilder para configurar la aplicación.
var builder = WebApplication.CreateBuilder(args);

// Configuración de la capa de API y OpenAPI (scalar).
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

// Configuración de los Controllers.
builder.Services.AddControllers();

// Configuración de la Inyección de Dependencias (DI):

// Contenedor (Almacenamiento en memoria):
// Se registra como Singleton para que la misma instancia persista durante toda la vida de la aplicación.
builder.Services.AddSingleton<TaskContainer>();

//Repositorio:
// Se registra como Scoped, creando una nueva instancia por cada solicitud HTTP.
// Esto garantiza un manejo de datos aislado para esa solicitud.
builder.Services.AddScoped<ITaskRepository, TaskRepository>();


// Construye la aplicación.
var app = builder.Build();

// Configuraciones específicas del entorno de Desarrollo.
if (app.Environment.IsDevelopment())
{
    // Habilita OpenApi.
    app.MapOpenApi();
     // Habilita la referencia de Scalar
    app.MapScalarApiReference();
    // Endpoint de depuración para verificar el estado de la memoria/contenedor.
    app.MapGet("/debug-memory", (TaskContainer container) => container.Tasks);
}
// Redirección HTTPS
app.UseHttpsRedirection();

// Mapeo de los controladores
app.MapControllers(); 

// Ejecuta la aplicación.
app.Run();

