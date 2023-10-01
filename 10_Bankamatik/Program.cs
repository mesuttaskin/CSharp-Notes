using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifre = "ab18";
            double bakiye = 2500;

            Console.WriteLine("Kartlı İşlem-1\nKartsız İşlem-2\n\tSeçiminiz:");
            string kart = Console.ReadLine();

            if (kart == "1")
            {
                    BASLA:
                bool girisDurumu = false;
               
                int hak = 3;
                while (hak > 0)
                {
                    Console.WriteLine("Şifre:");
                    string sfr = Console.ReadLine();

                    if (sfr == sifre)
                    {
                        Console.WriteLine("Giriş Başarılı.");
                        girisDurumu = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Şifre hatalı!!");
                    }
                    hak--;
                }

                if (girisDurumu)
                {
                ANAMENU:
                    Console.WriteLine("*******************Ana Menü******************* \r\n             Para Çekmek için    1\r\n             Para yatırmak için  2\r\n             Para Transferleri   3\r\n             Eğitim Ödemeleri    4\r\n             Ödemeler            5\r\n             Bilgi Güncelleme    6\r\n             Kart İade          7");

                    Console.WriteLine("Seçiminiz:");
                    string anamenu = Console.ReadLine();

                    #region PARA ÇEKME
                    if (anamenu == "1")
                    {
                        Console.WriteLine("Kaç para çekilecek:");
                        double miktar = Convert.ToDouble(Console.ReadLine());

                        if (bakiye >= miktar)
                        {
                            bakiye -= miktar;
                            Console.WriteLine("Paranızı alınız. Yeni Bakiyeniz:" + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye.");
                        }
                    }
                    #endregion
                    #region PARA YATIRMA
                    else if (anamenu == "2")
                    {
                        Console.WriteLine("Kredi Kartı 1\nKendi Hesabına 2\nSeçiminiz:");
                        string secim = Console.ReadLine();

                        if (secim == "1")
                        {
                            Console.WriteLine("Kredi kart no:");
                            long kredikart = Convert.ToInt64(Console.ReadLine());
                            if (kredikart >= 100000000000 && kredikart <= 999999999999)
                            {
                                #region 2.Yöntem
                                //string kredikart = Console.ReadLine();
                                //if (kredikart.Length == 12)
                                //{
                                //    long kredikarti = Convert.ToInt64(kredikart);

                                //}
                                #endregion

                                Console.WriteLine("Kaç para yatırılacak:");
                                double miktar = Convert.ToDouble(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("Paranız Kredi Kartına Aktarıldı.. Yeni Bakiyeniz:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kredi kart numaranız hatalı(12 haneli olmalıdır)!!");
                            }
                        }
                        else if (secim == "2") 
                        {
                            Console.WriteLine("Kaç para yatırılacak:");
                            double miktar = Convert.ToDouble(Console.ReadLine());

                            bakiye += miktar;
                            Console.WriteLine("Paranız Yatırıldı.Yeni bakiyeniz:"+bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Seçim!!");
                        }
                    }
                    #endregion
                    else if (anamenu == "3") 
                    {
                        Console.WriteLine("EFT - 1\nHavale - 2\nSeçiminiz: ");
                        string secim = Console.ReadLine();

                        if (secim == "1") 
                        {
                            Console.WriteLine("Başında TR olacak şekilde IBAN giriniz:");
                            string iban = Console.ReadLine();

                            //başında tr ve 12 basamaklı sayı
                            if (iban.ToUpper().StartsWith("TR") && iban.Length==14)
                            {
                                Console.WriteLine("Kaç para eft edeilecek:");
                                double miktar = Convert.ToDouble(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("EFT Başarılı. Yeni Bakiyeniz:" + bakiye);
                                }
                                else
                                {Console.WriteLine("Yetersiz Bakiye!!");
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("IBAN hatalı!!");
                            }




                        }
                        else if (secim == "2") 
                        {

                            Console.WriteLine("Havale edilecek hesap no:");
                            string hesapNo = Console.ReadLine();

                            //12 basamaklı sayı
                            if (hesapNo.Length == 12)
                            {
                                Console.WriteLine("Kaç para havale edeilecek:");
                                double miktar = Convert.ToDouble(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;
                                    Console.WriteLine("Havele Başarılı. Yeni Bakiyeniz:" + bakiye);
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!!");

                                }
                            }
                            else
                            {
                                Console.WriteLine("HesapNo hatalı!!");
                            }
                        }
                        else {
                            Console.WriteLine("Hatalı Seçim!!");
                        }
                    }
                    else if (anamenu == "4") {
                        Console.WriteLine("Eğitim Ödemeleri Bölümü Arızalı");
                    }
                    else if (anamenu == "5") 
                    {
                        Console.WriteLine("  Elektrik Faturası       1\r\n             Telefon Faturası        2\r\n             İnternet faturası       3\r\n             Su Faturası             4\r\n             OGS Ödemeleri           5");
                        Console.WriteLine("Ödenecek fatura bedeli:");
                        double fatura = Convert.ToDouble(Console.ReadLine());

                        if (bakiye >= fatura)
                        {
                            Console.WriteLine("Faturanız ödendi.Yeni bakiye="+bakiye);
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                        }

                    }
                    else if (anamenu == "6") 
                    {
                        Console.WriteLine("Eski Şifre:");
                        string eskiSfre = Console.ReadLine();
                        if (sifre == eskiSfre)
                        {
                            Console.WriteLine("yeni şifre:");
                            string yenisfr = Console.ReadLine();
                            Console.WriteLine("yeni şifre tekrar:");
                            string yenisfr2 = Console.ReadLine();
                            if (yenisfr == yenisfr2) 
                            {
                                sifre = yenisfr;
                                goto BASLA;
                            }
                            else { Console.WriteLine("Şifreler uyuşmuyor.."); }

                        }
                        else
                        {
                            Console.WriteLine("Girilen Şifre Hatalı");
                        }


                    }
                    else if (anamenu == "7")
                    {
                        Console.WriteLine("Kartınız İade Edildi.");
                        Console.WriteLine("Yine Bekleriz.");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Seçim!!");
                        goto ANAMENU;
                    }

                    Console.WriteLine("Ana menüye için   9\r\nÇıkmak için             0");
                    string don = Console.ReadLine();
                    if (don == "9")
                        goto ANAMENU;
                    else
                        Environment.Exit(0);
                }



            }
            else if (kart == "2")
            {

            }
            else
            {
                Console.WriteLine("Hatalı Seçim!!");
            }


            Console.ReadLine();
        }
    }
}
