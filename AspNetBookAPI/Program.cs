internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();

        var app = builder.Build();

        app.MapControllers();

        app.MapGet("/", () =>
        {
            return Results.Redirect("/api/books");
        });

        app.Run();
    }
} 