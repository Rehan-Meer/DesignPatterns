namespace Design_Patterns.SingletonPattern
{
    public sealed class Singleton                                   // "sealed" class to prevent inheritance 
    {
        private static Singleton? instance;                         // Singleton's instance is stored in a nullable static field.

        private static readonly object _lock = new();               // Thread synchronization

        private Singleton() { }                                     // Keeping constructor PRIVATE to avoid object creation outside the class

        private int ThreadNo { set; get; }
        public static Singleton GetInstance(int _threadNo)
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    instance ??= new Singleton { ThreadNo = _threadNo };
                }
            }
            Console.WriteLine("Returning object created by thread " + instance.ThreadNo);
            return instance;
        }

        public static void Main()
        {
            Parallel.Invoke(() => Singleton.GetInstance(1), () => Singleton.GetInstance(2));
        }
    }
}




