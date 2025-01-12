using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Bir yapının metot olduğunu anlamak için sonunda () olmalı
            // C# da metotlar mor renkli bir küp alırlar
            // Metodlar özünde ikiye ayrılır
            // Geriye değer döndürmeyen metotlar ---> Void
            // Customer-----> Listele,ekle,sil,güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void Write(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //Write("Şeyma Topuz");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Şeyma", "Topuz");
            //CustomerCard("Ayşe", "Kaya");
            //CustomerCard("Mehmet", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            // Dışardan Alınan 3 tane parametreyi toplayan sayılar
            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Girilen Sayılar: " + number1 + " " + number2 + " " + number3);
            //    Console.WriteLine("Girilen Sayıların Toplamı: " + result);
            //}
            //Sum(12,45, 36);


            #endregion

            #region Geriye Değer Döndüren Metotlar
            // Geriye bir değer döndürmesi gerekiyor

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            // ama yazdırma işlemi yapmadığımız için bunun bir karşılığı  yok
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren  String Parametreli Metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent:  " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student+ " isimli öğrenci sınavı geçti. " + " Ortalama:"+ result;

            //    }
            //    else
            //    {
            //        return student+  " isimli öğrenci başarısız oldu. " + " Ortalama:" + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Şeyma Topuz", 85, 75, 80));
            //Console.WriteLine(ExamResult("Ali", 25, 41, 40));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));


            #endregion




            Console.Read();

        }
    }
}
