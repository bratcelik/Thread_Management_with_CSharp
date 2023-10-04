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



Console.WriteLine("Main thread starting.");

IsParcacigi isci = new IsParcacigi("Child 1");
Thread newThrd = new Thread(isci.Run);
newThrd.Start();

do
{
    Console.Write(".");
    Thread.Sleep(100);

}while (isci.Count != 10);

Console.WriteLine("Main thread ending.");

Console.ReadLine();