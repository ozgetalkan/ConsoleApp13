namespace ConsoleApp13
{
    internal class Program
    {
        //TODO: Daha çok iş var
        //Normal comment
        //HACK: sss
        //UNDONE : 1122
        static void Main(string[] args)
        {
            Program p = new();
            p.fuc1();
        }
        public void fuc1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                //System.Diagnostics.Debugger.Break();
                //thread iş parçacığı demek. Mesela bir thread de video oynatırken, dğer thread de text dosyası yazacaksın.
                System.Threading.Thread.Sleep(2000); //şuan da çalışan thread'i 2000 milisaniye geciktir = 2 saniye
                //ekrana iki saniyede bir 0 dan 8 e kadar sayılar gelir. 8 den sonra Visual studio açılır.
                if (i == 8)
                {
                    System.Diagnostics.Debugger.Launch();
                }
            }
        }
    }
}