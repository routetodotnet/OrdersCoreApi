using System;
using System.Threading.Tasks;

namespace asyncawaitexample
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Biryani biryani =new Biryani();
            biryani.GetBiryani();


            Console.ReadLine();

        }
      
    }


    public class Biryani
    {

        public void GetBiryani()
        {
            Console.WriteLine("--------------Sync Process ---------------");
            Biryani biryani = new Biryani();
            biryani.CookBiryani();

            Console.WriteLine("--------------Async Await Process---------------");


           // var result=biryani.CookBiryaniAsync();
            //await result;
            Console.WriteLine("--------------Completed---------------");

            Console.ReadLine();
        }

        public  async Task CookBiryaniAsync()
        {

            Console.WriteLine($"Prepare Ingrediants Masala {System.DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"working loop on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            var a = 0;
            for (int i = 0; i < 1000000; i++)
            {
                a = a + i;
            }
            Console.WriteLine($"working on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            var boiledrice = BoiledRiceAsync();
           
            Console.WriteLine($"Put Chicken on the bandi :{System.DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"Put {await boiledrice} on top of chicken :{System.DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"working on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Biryani Ready...{System.DateTime.Now.ToLongTimeString()}");

            Console.ReadLine();

        }
        public async Task<string> BoiledRiceAsync()
        {

            Console.WriteLine($"Boiling Rice on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            //takes 20 minutes to complete 
            await Task.Delay(5000);
            //System.Threading.Thread.Sleep(5000);
            string boiledrice = "boiledrice";

            return  boiledrice;


        }


        public void CookBiryani()
        {
            Console.WriteLine($"Prepare Ingrediants Masala {System.DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"working loop on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            var a = 0;
            for (int i = 0; i < 1000000; i++)
            {
                a = a + i;
            }
            Console.WriteLine($"working on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            var boiledrice = BoiledRice();

            Console.WriteLine($"Put Chicken on the bandi :{System.DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"Put {boiledrice} on top of chicken :{System.DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"working on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Biryani Ready...{System.DateTime.Now.ToLongTimeString()}");

            Console.ReadLine();

        }
        public string BoiledRice()
        {

            Console.WriteLine($"Boiling Rice on thread { System.Threading.Thread.CurrentThread.ManagedThreadId}");
            //takes 20 minutes to complete 
            //Task.Delay(10000);
            System.Threading.Thread.Sleep(5000);
            string boiledrice = "boiledrice";

            return boiledrice;


        }
    }
}
