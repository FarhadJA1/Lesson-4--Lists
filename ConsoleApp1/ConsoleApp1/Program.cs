using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        int[] a = { 3,2,4,-5,1};

                        int[] b = { 3,2,4,-5};
                        Console.WriteLine(b.Length);

                        string[] c = { "Valeh" };*/

            /*foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }*/


            /*for (int i = 0; i < b.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(b[i]);
                }
            }
            Console.WriteLine(c);*/


            
            /*string[] array1 = {"salam","sagol","necesen"};
            string[] array2 = array1;
            array2[1] = "hahah";
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }*/


           /* int num1 = 5;
            int num2 = num1;
            num2 = 7;
            Console.WriteLine(num1);*/

            List<string> words = new List<string>();
            List<int> nums = new List<int>(1); //yeni list yaratma
            words.Add("salam");
            nums.Add(1);//capacity 1 //index 0
            nums.Add(2);//capacity 2 //index 1
            nums.Add(4);//capacity 3 //index 2
            nums.Add(3);//capacity 4 //index 3
            nums.Add(5);//capacity 8  //index 4
            /*nums.Clear();*/
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            
            if (nums.Contains(3))//listdə olub olmaması(true/false)
            {
                Console.WriteLine("var");
            }
            else
            {
                Console.WriteLine("yox");
            }




            /*nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);*/
            Console.WriteLine(nums.Capacity); // listin razmeri
            Console.WriteLine(nums.Find(m=>m>2)); //listdə verdiyimiz şərtə uyğun ilk elementi qaytarır
            
            foreach (var item in nums.FindAll(x => x > 2)) //listdə verdiyimiz şərtə uyğun bütün elementləri qaytarir(collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(nums.FindIndex(m=>m>2)); //listdə verdiyimiz şərtə uyğun ilk elementin indexi

            nums.ForEach(m =>{ Console.WriteLine(m); });

            Console.WriteLine(nums.FindLastIndex(m=>m>2)); //listdə verdiyimiz şərtə uyğun ilk elementin indexi(tərsdən)

            Console.WriteLine(nums.IndexOf(4)); //konkret elementin indexi
            Console.WriteLine("_____________________");
            //nums.Remove(2);
            nums.ForEach(item => Console.WriteLine(item));
            //nums.RemoveAll(m => m > 2);
            Console.WriteLine("________________");
            nums.ForEach(m => Console.WriteLine(m));
            nums.RemoveAt(nums.FindIndex(m=>m>2)); //qeyd etdiyimiz indexdən sonra bütün elementləri silir
            nums.RemoveRange(nums.FindIndex(m => m > 2), 1); //qeyd etdiyimiz indexdən sonra verdiyimiz sayda silir
            nums.Reverse(); //listi tərs çevirir
            nums.Sort(); //listi düzgün sıra ilə sıralayır
        }
    }
}
