using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                                   ****OTOBÜS KOLTUK REZERVASYON SAYFASINA HOŞGELDİNİZ****\n\n\n");
            Console.WriteLine("Otobüsün görünümü aşağıdaki gibidir\n\n");

            Console.WriteLine(" 17 18 19 20 21 22 23 24 25 26 27 28 29 30\n 47 48 49 50 51 52 53 54 55 56 57 58 59 60\n----------------------------------------------- \n31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46\n  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16\n\n\n");


            int[] KoltukNolar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };
            int[] BoşKoltukAtama = { 0, 61 };
            int tercih;
            int sayaç = 0;
            int CamKenarıSeçim;
            int KoridorTarafıSeçim;
            string TercihIki;

            while (sayaç < 61)
            {

                Console.Write("Cam kenarından yer ayırtmak istiyorsanız 1'i\nKoridor tarafından yer ayırtmak istiyorsanız 2'yi\nUygulamayı kapatmak istiyorsanız 3'ü\nTuşlayınız;");
                tercih = Convert.ToInt16(Console.ReadLine());

                if (tercih == 1)
                {
                    Console.WriteLine("Rezervasyon etmek istediğiniz koltuk no'yu giriniz;");
                    CamKenarıSeçim = Convert.ToInt16(Console.ReadLine());
                    if (KoltukNolar[CamKenarıSeçim - 1] <= 30)
                    {
                        if (KoltukNolar[CamKenarıSeçim - 1] != BoşKoltukAtama[0])
                        {
                            Console.WriteLine("Rezervasyon yaptığınız koltuk no={0}\n\n", KoltukNolar[CamKenarıSeçim - 1]);
                            KoltukNolar[CamKenarıSeçim - 1] = BoşKoltukAtama[0];
                            sayaç++;

                        }
                        else if (KoltukNolar[CamKenarıSeçim - 1] == BoşKoltukAtama[0])
                        {
                            Console.Write("Bu koltuk doludur. Koridor tarafından rezervasyon yapmak isterseniz evet\nİstemezseniz hayır\nYazınız;");
                            TercihIki = Console.ReadLine();
                            if (TercihIki == "evet" || TercihIki == "EVET")
                            {
                                if (KoltukNolar[CamKenarıSeçim + 29] == BoşKoltukAtama[1])
                                {
                                    Console.WriteLine("Geçilmek üzere olan koltuk dolu olduğu için bu işlem gerçekleştirelemez.\n\n");
                                    sayaç++;
                                }
                                else
                                {
                                    Console.Write("Size seçtiğiniz koltuğun yanındaki koltuk olan ve koridor tarafında bulunan {0} no'lu koltuğu veriyoruz.\n", KoltukNolar[CamKenarıSeçim + 29]);
                                    KoltukNolar[CamKenarıSeçim + 29] = BoşKoltukAtama[0];
                                    sayaç++;
                                }

                            }
                            if (TercihIki == "hayır" || TercihIki == "HAYIR")
                            {
                                Console.Write("Seçtiğiniz koltuğun yanındaki koltuğu seçmek istemediniz..\n\n\n");
                                sayaç++;

                            }



                        }
                    }


                    else if (KoltukNolar[CamKenarıSeçim - 1] > 30)
                    {
                        Console.WriteLine("Girdiğiniz koltuk numarası koridor tarafına aittir.\n");
                        sayaç++;
                    }

                }






                if (tercih == 2)
                {
                    Console.Write("Rezervasyon etmek istediğiniz koltuk no'yu giriniz;");
                    KoridorTarafıSeçim = Convert.ToInt16(Console.ReadLine());
                    if (KoltukNolar[KoridorTarafıSeçim - 1] > 30)
                    {
                        if (KoltukNolar[KoridorTarafıSeçim - 1] != BoşKoltukAtama[1])
                        {
                            Console.WriteLine("Rezervasyon yaptığınız koltuk no={0}", KoltukNolar[KoridorTarafıSeçim - 1]);
                            KoltukNolar[KoridorTarafıSeçim - 1] = BoşKoltukAtama[1];
                            sayaç++;
                        }
                        else if (KoltukNolar[KoridorTarafıSeçim - 1] == BoşKoltukAtama[1])
                        {
                            Console.Write("Bu koltuk doludur. Cam tarafından rezervasyon yapmak isterseniz evet\nİstemezseniz hayır\nYazınız;");
                            TercihIki = Console.ReadLine();
                            if (TercihIki == "evet" || TercihIki == "EVET")
                            {
                                if (KoltukNolar[KoridorTarafıSeçim - 31] == BoşKoltukAtama[0])
                                {
                                    Console.WriteLine("Geçilmek üzere olan koltuk dolu olduğu için bu işlem gerçekleştirelemez.\n\n");
                                    sayaç++;
                                }
                                else
                                {
                                    Console.Write("Size seçtiğiniz koltuğun yanındaki koltuk olan ve koridor tarafında bulunan {0} no'lu koltuğu veriyoruz.\n", KoltukNolar[KoridorTarafıSeçim - 31]);
                                    KoltukNolar[KoridorTarafıSeçim - 31] = BoşKoltukAtama[0];
                                    sayaç++;
                                }


                            }
                            else if (TercihIki == "hayır" || TercihIki == "HAYIR")
                            {
                                Console.Write("Seçtiğiniz koltuğun yanındaki koltuğu seçmek istemediniz..\n\n");
                                sayaç++;
                            }
                        }




                    }
                    else if (KoltukNolar[KoridorTarafıSeçim - 1] > 30)
                    {
                        Console.WriteLine("Girdiğiniz koltuk numarası cam tarafına aittir.\n");
                        sayaç++;
                    }
                }






                if (tercih == 3)
                {
                    Console.Write("Uygulamayı kapatmak için klavyeden herhangi bir tuşu tuşlayınız;");
                    Console.Read();
                }
            }


            Console.Read();


        }

    }
}
