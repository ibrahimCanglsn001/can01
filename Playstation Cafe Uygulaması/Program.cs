using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstation_Cafe_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double odenecekTutar = 0;
            int oynananSüre = 0, oyunTipi = 0;
            Console.WriteLine("      - GÜLŞEN Playstation Kafe -      ");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000); // 1 Saniye Bekle
            Console.WriteLine("Playstation Kafemize Hoş Geldiniz...");
            Console.WriteLine("");
            Console.WriteLine("         | Seçenekler |          ");
            Console.WriteLine("");
            Console.WriteLine("Oyunlarımız Aşağıdaki Seçeneklerde Mevcuttur :  ");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|     1 - PS5 eFootball 2023                   |");
            Console.WriteLine("|     2 - PS4 Grand Theft Auto V               |");
            Console.WriteLine("|     3 - PS3 Minecraft                        |");
            Console.WriteLine("|     4 - PS5 Call of Duty Modern Warfare II   |");
            Console.WriteLine("|     5 - PS5 Fortnite                         |");
            Console.WriteLine("|     6 - PS4 God of War: Ragnarök             |");
            Console.WriteLine("|     7 - PS3 Assassin's Creed                 |");
            Console.WriteLine("|     8 - PS3 FIFA 2019                        |");
            Console.WriteLine("|     9 - PS4 Resident Evil 4                  |");
            Console.WriteLine("|     10 - PS4 WWE 2K22                        |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("------------------------------------------------");

            Console.Write(" Lütfen Kaç Numaralı Oyunu Oynamak İstediğinizi Seçiniz : ");
            oyunTipi = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Bu Oyunu Kaç Saat Oynamak İstersiniz ? : ");
            oynananSüre = Convert.ToInt32(Console.ReadLine());
            if (oynananSüre > 1)
            {
                for (int i = 1; i <= oynananSüre; i++)
                {
                    if (i == 1)
                    {
                        if (oyunTipi == 1) { odenecekTutar = i * 25; }
                        else if (oyunTipi == 2) { odenecekTutar = i * 15; }
                        else if (oyunTipi == 3) { odenecekTutar = i * 10; }
                        else if (oyunTipi == 4) { odenecekTutar = i * 25; }
                        else if (oyunTipi == 5) { odenecekTutar = i * 25; }
                        else if (oyunTipi == 6) { odenecekTutar = i * 15; }
                        else if (oyunTipi == 7) { odenecekTutar = i * 10; }
                        else if (oyunTipi == 8) { odenecekTutar = i * 10; }
                        else if (oyunTipi == 9) { odenecekTutar = i * 15; }
                        else if (oyunTipi == 10) { odenecekTutar = i * 15; }

                    }
                    else
                    {
                        oynananSüre -= 1;
                        if (oyunTipi == 1) { odenecekTutar += oynananSüre * 25 * 1; }
                        else if (oyunTipi == 2) { odenecekTutar += oynananSüre * 15 * 1; }
                        else if (oyunTipi == 3) { odenecekTutar += oynananSüre * 10 * 1; }
                        else if (oyunTipi == 4) { odenecekTutar += oynananSüre * 25 * 1; }
                        else if (oyunTipi == 5) { odenecekTutar += oynananSüre * 25 * 1; }
                        else if (oyunTipi == 6) { odenecekTutar += oynananSüre * 15 * 1; }
                        else if (oyunTipi == 7) { odenecekTutar += oynananSüre * 10 * 1; }
                        else if (oyunTipi == 8) { odenecekTutar += oynananSüre * 10 * 1; }
                        else if (oyunTipi == 9) { odenecekTutar += oynananSüre * 15 * 1; }
                        else if (oyunTipi == 10) { odenecekTutar += oynananSüre * 15 * 1; }
                    }
                }
            }
            else
            {
                if (oyunTipi == 1) { odenecekTutar = oynananSüre * 20; }
                else if (oyunTipi == 2) { odenecekTutar = oynananSüre * 15; }
                else if (oyunTipi == 3) { odenecekTutar = oynananSüre * 10; }
                else if (oyunTipi == 4) { odenecekTutar = oynananSüre * 25; }
                else if (oyunTipi == 5) { odenecekTutar = oynananSüre * 25; }
                else if (oyunTipi == 6) { odenecekTutar = oynananSüre * 15; }
                else if (oyunTipi == 7) { odenecekTutar = oynananSüre * 10; }
                else if (oyunTipi == 8) { odenecekTutar = oynananSüre * 10; }
                else if (oyunTipi == 9) { odenecekTutar = oynananSüre * 15; }
                else if (oyunTipi == 10) { odenecekTutar = oynananSüre * 15; }
            }
            Console.WriteLine(" Ödenecek Tutar : {0} TL'dir GÜLŞEN Playstation Kafe İyi Günler Diler... ", odenecekTutar);
            Console.ReadKey();
        }
    }
}