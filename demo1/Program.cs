
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
         var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

    }
}
