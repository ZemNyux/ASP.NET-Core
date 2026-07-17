namespace asp.net2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", async context =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync("""
                    <!DOCTYPE html>
                    <html lang="uk">
                    <head>
                        <meta charset="UTF-8">
                        <title>Главная страница</title>
                        <style>
                            body { font-family: sans-serif; text-align: center; margin-top: 50px; background-color: #f4f4f9; }
                            h1 { color: #333; }
                            a { display: inline-block; margin-top: 20px; padding: 10px 20px; background-color: #007bff; color: white; text-decoration: none; border-radius: 5px; }
                            a:hover { background-color: #0056b3; }
                        </style>
                    </head>
                    <body>
                        <h1>Салют! Ты на главной странице сайта!</h1>
                        <p>Это первый главный раздел сайта на ASP.NET Core.</p>
                        <a href="/about">Перейти до другого раздела сайта</a>
                    </body>
                    </html>
                """);
            });

            app.MapGet("/about", async context =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync("""
                    <!DOCTYPE html>
                    <html lang="uk">
                    <head>
                        <meta charset="UTF-8">
                        <title>Про нас</title>
                        <style>
                            body { font-family: sans-serif; text-align: center; margin-top: 50px; background-color: #eef9f4; }
                            h1 { color: #2e7d32; }
                            a { display: inline-block; margin-top: 20px; padding: 10px 20px; background-color: #2e7d32; color: white; text-decoration: none; border-radius: 5px; }
                            a:hover { background-color: #1b5e20; }
                        </style>
                    </head>
                    <body>
                        <h1>Это второй раздел сайта!</h1>
                        <p>Тут пока что ничего не находиться но все в силе все будет)</p>
                        <a href="/">Вернуться на Главную страницу</a>
                    </body>
                    </html>
                """);
            });

            app.Run();
        }
    }
}