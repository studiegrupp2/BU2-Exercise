
namespace Controllers;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();
        builder.Services.AddControllers();

        //övning 9
        //builder.Services.AddSingleton<CounterService>();

        // builder.Services.AddSingleton<WordService>();
        builder.Services.AddSingleton<TodoService, TodoService>();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.UseAuthorization();

      
        app.MapControllers();
        app.Run();
    }
}


