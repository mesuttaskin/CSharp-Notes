using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 kişilik bir ailedeki üyeleri isimleri
           
                //* Değişken bir data tutabilir.
            string isim1 = "Altan";
            string isim2 = "Ceylan";
            string isim3 = "Uras";
            string isim4 = "Kıvanç";
            string isim5 = "Kerem";

            //************** ARRAY(DİZİ) *****************

            // Diziler veritipleri ve uzunlukları tanımlanan koleksiyon yapılarıdır. Diziler kendileri verilen değerleri INDEX adı verilen ve 0 dan başlayarak 1'er 1'er artan numaralandırma yapısıyla tutarlar.

            // Boş Dizi Tanımı
            //string[] isimler = new string[10];

            //Dolu Bir Dizi Tanımı
            //string[] isimler = { "Altan", "Ceylan", "Uras", "Kerem", "Kıvanç" };


            // *********** Diziye Eleman Ekleme ************
            //string[] isimler = new string[10];
            //isimler[0] = "Ali";
            //isimler[5] = "Veli";
            //isimler[3] = isim1;

            //isimler[10] = "Mahmut";

            //double[] sayilar = { 12, 14.5, 23.4f };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            object[] karisik = { 12, "Altan", 12.5,34.5f, 35m };


            Console.ReadLine();

        }
    }
}
