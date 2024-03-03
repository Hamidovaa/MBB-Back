using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };


            // Task1-Yuxaridaki arrayda 5 reqeminin nece defe tekrarlandigini tapin

            //int say = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] == 5)
            //    {
            //        say += 1;
            //    }
            //}
            //Console.WriteLine(say);


            //Task2-Yuxaridaki arraydaki butun reqemlerin cemini tapin

            //int sum = 0;
            //for(int i=0; i<arr.Length; i++)
            //{
            //    sum+=arr[i];
            //}
            //Console.WriteLine(sum);


            //Task3-arrayda tekrar olunan reqemleri artan sira ile duzun

            //Array.Sort(arr);
            //int say = arr[0];
            //int tekrarSayi = 1;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] == say)
            //    {
            //        tekrarSayi++;
            //    }
            //    else
            //    {
            //        for (int j = 0; j < tekrarSayi; j++)
            //        {
            //            Console.WriteLine(say + " ");
            //        }
            //        say = arr[i];
            //        tekrarSayi = 1;
            //    }
            //}


            //Task4-arraydaki en boyuk reqemi tapin ve nece defe tekrarlandigini gosterin

            //int count = 0;
            //int a = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > a)
            //    {
            //        a = arr[i];
            //    }
            //}
            //Console.WriteLine(a);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == a) { count++; }
            //}
            //Console.WriteLine("tekrar sayi:" + count);


            //Task5-Random 1 den 10 a qeder reqem generate edin ve sonra arrayda hemin reqemin olub olmamasini yoxlayin

            //Random random = new Random();
            //int randomNumber = random.Next(1, 10);
            //bool b = false;
            //Console.WriteLine(randomNumber);
            //foreach (int item in arr)
            //{
            //    if (item == randomNumber)
            //    {
            //        b = true;
            //    }
            //}
            //Console.WriteLine(b);


            //Task6-Adinizdaki herflerin sayini tapin ve hemin sayin arrayda olub olmamasini yoxlayin Meselen Murad adinda 5 herf var ve 5 arrayda var

            //string ad = "Reqsane";
            //bool var = false;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (ad.Length == arr[i])
            //    {
            //        var = true;
            //    }
            //}
            //Console.WriteLine("var");



            //Task7-arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin

            //int a = 0;
            //int index = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 == 2)
            //    {
            //        a = arr[i];
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(a+ "indexi:" + index);



            //Task8-arraydaki en boyuk reqemin ilk indexini tapin

            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //int axtarilaneded = max;
            //int index = Array.IndexOf(arr, axtarilaneded);
            //Console.WriteLine(index);


            //Task8-arraydaki en boyuk reqemin ilk indexini tapin

            //int max = arr[0];
            //int index2 = 0;
            //for(int i = 1; i < arr.Length; i++)
            //{
            //    if(arr[i]>max)
            //    {
            //        max = arr[i];
            //        index2 = i;
            //    }
            //}
            //Console.WriteLine(max + "indexi:" +index2);


            //Task9-4 reqeminin arrayin hansi indexlerinde oldugunu gosterin

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] == 4)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}





        }
    }
}
