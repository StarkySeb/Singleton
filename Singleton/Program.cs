
namespace singleton{

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Zavolání instance pro výpis
        Singleton singleton = Singleton.GetInstance();
        singleton.Zprava();
    }
}

}