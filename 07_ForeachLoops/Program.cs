using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:DEğişken Türü
            //2:Değiken adı
            //3:In
            //4:Liste, Koleksiyon,Dizi
            //Foreach ile yapılan her şey for ile de yapılabilir.


            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //tam sayılar için de yapabiliriz
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //2'ye tam bölünenleri yazdırma
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);

            //    }
            //}


            //bir dizinin içinde bulunan sayıları toplama
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int sum = 0;
            //foreach(int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Listeler
            // Listeleri veri tabanarı ile beraber kullanacağız
            // Listeler bir koleksiyon verisidir

            //List<int> numbers = new List<int>() 
            //{ 
            //    1, 2, 3, 4, 5, 8 
            //};

            // Direkt olarak bunu yazdırdığımızda metinsel olarak bir ifade dönderir
            // Foreach döngüsü sadece dizilerle çalışan bir yapı değil aynı zamanda listelerle de çalışan bir yapıdır.

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            // bir kelimeyi harflerine ayıran ifadeyi yazalım 
            //string word = "Merhaba";
            // word ismindeki değişkeni chara göre parçalar
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}  


            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            // Klavyeden öğrneci sayısı alalım bu öğrencilerin isimleri notları ve ortalamalarını hesaplayan bir uygulama

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            // Kullanıcının girdiği kadar öğrenci adı almamızı sağlar
            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi

                for(int j=0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz.
                }
                studentExamAvg[i] = totalExamResult / 3;

            }

            // Sınav Ortalamaları
            for(int i =0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");

                // Öğrencilerin ortalaması ile geçip kalma durumları

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci {studentExamAvg[i]} ortalama ile dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci {studentExamAvg[i]} ortalama ile dersten kaldı.");
                }

                Console.WriteLine("---------------------------------------------------");
            }







            #endregion

            Console.Read();
        }
    }
}
