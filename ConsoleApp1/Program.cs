using ConsoleApp1;
/*
 *  IsAlive     Thread'in çalışma durumunu verir.
 *  Name        Thread'in adını atar ya da verir.
 *  Priority    Thread'in çalışma önceliğini atar ya da verir
 *  Abort       ThreadAbortException hatasını atarak thread'n çalışmasını iptal eder.
 *  Resume      Beklemeye geçirilmiş thread'in çalışmasının devam etmesini sağlar
 *  Sleep       Belirtilen süre kadar beklemeye geçer.
 *  Suspend     Thread'i geçici süre durdurur.
 */

// Background Thread (Arka plan thread'i arka planda çalışır main thread sona erdiğinde background thread'lerde sona erer.
// Thread myThread = new Thread(CalisacakMetod);
// myThread.IsBackground = true;
// şeklinde background thread'i olarak ayarlanır.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main thread starting.");

        //IsParcacigi isci = new IsParcacigi("Child 1");
        //Thread newThrd = new Thread(isci.Run);

        Thread backGroundThread = new Thread(CalisacakMetod);
        backGroundThread.IsBackground = true;

        AddParams ap = new AddParams(20, 10);
        Thread threadWithParameters = new Thread(new ParameterizedThreadStart(Add));
        threadWithParameters.Start(ap);



        //newThrd.Start();
        backGroundThread.Start();


        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Main thread "+i);
            Thread.Sleep(50);
        }

        //do
        //{
        //    Console.Write(".");
        //    Thread.Sleep(100);

        //} while (isci.Count != 10);

        Console.WriteLine("Main thread ending.");
    }

    static void Add(object data)
    {
        if(data is AddParams)
        {
            Console.WriteLine("Id of thread in main(): {0}", Thread.CurrentThread.ManagedThreadId);
            AddParams ap = (AddParams)data;
            Console.WriteLine("{0} + {1} = {2}", ap.a, ap.b, ap.a + ap.b);
        }
    }

    static void CalisacakMetod()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("İşlem : "+i);
            Thread.Sleep(100);
        }
        Console.WriteLine("CalisacakMetod() thread'i sona erdi");

    }
}

class AddParams
{
    public int a;
    public int b;

    public AddParams(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}