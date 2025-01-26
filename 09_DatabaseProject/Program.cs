using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net
            // Bizim C# programlama dilini yapılarını kullanabilmemize olanak sağlayan bir çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;

            Console.WriteLine("----------------------------------");
            
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            
            Console.Write("Lütfen getirmek istediğiniz tabl numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------");



            SqlConnection connection = new SqlConnection("Data Source=SHEYMIX\\SQLEXPRESS08;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            // data table verilerimizi belleğe almamızı sağlayacak
            adapter.Fill(dataTable);
            connection.Close();

            // var değişkeni bütün değişken türlerini üzerine alan bir değişken 
            foreach(DataRow row in dataTable.Rows)
            {
               foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());    
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
