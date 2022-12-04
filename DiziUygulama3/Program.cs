using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziUygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] dizi = new int[20];

            for (int sayac = 0; sayac < dizi.Length; sayac++)
            {
                dizi[sayac] = rnd.Next(1,10);
            }

            int degerBul = 0;

            foreach (int item in dizi)
            {
                Console.WriteLine(item);
                if (item == 8)
                {
                    degerBul++;
                }
            
            }
            if (0<degerBul)
            {
                Console.WriteLine("Dizi içersinde ki 8 değeri " + degerBul + " adettir");
            }
            else 
            {
                Console.WriteLine("Dizi içersinde istediğinzi değerden bulunmuyor !");
            }
       
            Console.ReadLine();
        }
    }
}
