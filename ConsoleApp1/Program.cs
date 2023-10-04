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