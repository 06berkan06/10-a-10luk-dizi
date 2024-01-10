using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_a_10luk_dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           
           
            
                
                int[,] dizim = new int[10, 10];


                int[] rastgeleSayilar = new int[100];
                for (int i = 0; i < 100; i++)
                 {  
                int randomSayi;
                do
                {
                    randomSayi = random.Next(0, 50);

                } while (randomSayi % 2 != 0 );
                rastgeleSayilar[i] = randomSayi;   
                }
            for (int satir = 0; satir < 10; satir++)
            { for (int sutun = 0; sutun < 10; sutun++) 
                { 
                    dizim[satir, sutun] = rastgeleSayilar[satir * 10 + sutun];
                } 
            }

                for (int satir = 0; satir < 10; satir++)
                {
                    for (int sutun = 0; sutun < 10; sutun++)
                    { 
                        Console.Write(dizim[satir, sutun].ToString().PadLeft(3) + " ");
                        
                    }
                    Console.WriteLine();
                }
            
            Console.ReadLine();
        }
    }
}
