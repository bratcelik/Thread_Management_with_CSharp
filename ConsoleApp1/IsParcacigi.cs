namespace ConsoleApp1
{
    public class IsParcacigi
    {
        public int Count;
        public Thread Thrd;

        public IsParcacigi(string name)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        public void Run()
        {
            Console.WriteLine(Thrd.Name + " starting");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);
                Count++;
            } while (Count <= 10);
            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }
}
