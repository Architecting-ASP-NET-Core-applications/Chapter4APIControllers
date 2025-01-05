using Chapter4APIControllers.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ITodoBridge, TodoBridge>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


/*---------------------------------*/
app.MapGet("/todos", () =>
{
    // Retrieve and return list of todos
});

app.MapGet("/todos/{id}", (int id) =>
{
    // Retrieve and return todo with specified id
});

app.MapPost("/todos", (TaskEntity todo) =>
{
    // Create new todo
});

app.MapPut("/todos/{id}", (int id, TaskEntity todo) =>
{
    // Update todo with specified id
});

app.MapDelete("/todos/{id}", (int id) =>
{
    // Delete todo with specified id
});


/*---------------------------------*/


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
