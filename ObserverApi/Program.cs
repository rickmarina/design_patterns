var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddLogging();
builder.Services.AddSingleton<EventBroker>();
builder.Services.AddSingleton<ISubject>(sp => sp.GetRequiredService<EventBroker>());
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<NotifyService>();

var app = builder.Build();

// Forzar la instanciación de los observers para que se suscriban
app.Services.GetRequiredService<UserService>();
app.Services.GetRequiredService<NotifyService>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/create", (UserService userService) =>
{
    userService.CreateUser(new UserModel { Name = "John Doe", Id = 1 });
    return "PONG";
});

app.MapGet("/delete", (UserService userService) =>
{
    userService.DeleteUser(new UserModel { Name = "John Doe", Id = 1 });
    return "PONG";
});

app.Run();
