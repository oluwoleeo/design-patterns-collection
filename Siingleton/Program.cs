namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application application1 = Application.GetInstance();
            Application application2 = Application.GetInstance();

            Console.WriteLine(application1.Equals(application2));
        }
    }
}