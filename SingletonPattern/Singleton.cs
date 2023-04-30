namespace Design_Patterns.SingletonPattern
{
    public sealed class Singleton                                             // "sealed" class to prevent inheritance 
    {

        private static Singleton? instance;                                   // The Singleton's instance is stored in a nullable static field.

        private static readonly object _lock = new();                         // for thread synchronization

        private Singleton() { }                                               // keeping constructor PRIVATE to avoid direct object creation.

        private int ThreadNo { set; get; }
        public static Singleton GetInstance(int num)
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    instance ??= new Singleton();
                    instance.ThreadNo = num;
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




