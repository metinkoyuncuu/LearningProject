//using System.Numerics;

//namespace Consolee
//{
//    internal class VolatileBigIntegerThreadDelegate
//    {
//        static volatile int _count = 0;
//        static void Main(string[] args)
//        {
//            BigInteger bigInteger = BigInteger.Parse("44444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444");

//            ////Thread
//            //// Thread oluşturup başlatma
//            //Thread thread = new Thread(new ThreadStart(Yazdir));
//            //thread.Start();

//            //// Ana thread'den farklı olarak çalışacak olan thread
//            //for (int i = 0; i < 5; i++)
//            //{
//            //    Console.WriteLine("Ana Thread: Sayı {0}", _count);

//            //    Thread.Sleep(1000); // 1 saniye bekleme
//            //}
//            ////Delegate Class
//            //DelegateClass delegateClass = new();
//            //delegateClass.mesajGosterDelegate("Ben bir delegate mesajıyım");

//            ////Dictionary
//            //Dictionary<string,string> mySampleForDictionary= new();
//            //mySampleForDictionary["myValue"] = "mykey";
//            //bool control = mySampleForDictionary.ContainsValue("mykeyy");
//            //Console.WriteLine(mySampleForDictionary["myValue"]+control);

//            Console.ReadLine(); // Programın kapanmaması için bekletme
//        }

//        //static void Yazdir()
//        //{
//        //    for (int i = 0; i < 5; i++)
//        //    {
//        //        _count = i + 9;
//        //        Console.WriteLine("Thread: Sayı {0}", _count);
//        //        Thread.Sleep(1500); // 1.5 saniye bekleme
//        //    }
//        //}
//    }
//    // class DelegateClass
//    //{
//    //    public delegate void MesajGoster(string mesaj);
//    //    public MesajGoster mesajGosterDelegate;

//    //    public DelegateClass()
//    //    {
//    //        // Delegate referansı atanır
//    //        mesajGosterDelegate = new MesajGoster(MesajYaz);
//    //    }

//    //    public void MesajYaz(string mesaj)
//    //    {
//    //        Console.WriteLine(mesaj);
//    //    }
//    //}
//}
