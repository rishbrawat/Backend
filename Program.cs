using Microsoft.EntityFrameworkCore;


// each piece in the pipeline is called middlewere
// foor example
// app.UseAuthentication()
// app.MapControllers() etc

// req -> mw1 -> mw2 -> endpoint -> response

// builder is an object used to construct and configure your asp.net application before the application is actually built.
var builder = WebApplication.CreateBuilder(args);

// now we register the context with DI
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(
        // 
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);
// register controllers
builder.Services.AddControllers();


// for swagger 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build(); // the actual application object


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();