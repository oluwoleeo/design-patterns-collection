// Structural pattern

namespace Singleton
{
    public class Application
    {
        static readonly object _lock = new object();
        static Application _instance;
        static int counter = 0;

        private Application()
        {
            counter++;
            Console.WriteLine($"Constructor called {counter} times");
        }

        public static Application GetInstance()
        {
            lock (_lock) // thread safety
            {
                if (_instance == null)
                {
                    _instance = new Application();
                }
            }

            return _instance;
        }
    }
}
