using System.ComponentModel.Design;

namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 sual
            //Valyuta mübadiləsi, sadə kalkulyator və mili kilometrə çevirən əvvəlki proqramları
            //Do - While ilə təkrarlanan menyuya salın. İstifadəçi çıxış seçənədək proqram işləsin.
            //int secim = 1;
            //while (secim != 0)
            //{
            //    Console.WriteLine("valyutqa");
            //    Console.WriteLine("2. kalkul");
            //    Console.WriteLine("3. mil - km");
            //    Console.WriteLine("0. cixis");


            //    }
            //}
            #endregion

            #region Task 2 
            //İstifadəçi 10 tam ədəd daxil edir. Mənfi, müsbət və sıfır olan ədədlərin hər birinin faizini
            //hesablayın.

            //var musbet = 0;
            //var menfi = 0;
            //var sifir = 0;

            //for (int i = 0; i <= 10;  i++)
            //{
            //    Console.Write("eded daxil edin");
            //    int eded = int.Parse(Console.ReadLine());
            //    if (eded == 0)
            //    {
            //        sifir++;
            //    }

            //    else if (eded > 0)
            //    {
            //        menfi++;
            //    }

            //    else
            //    {
            //        menfi++;
            //    }
            //}

            //double menfifaiz = menfi * 100 / 10;
            //double musbetfaiz = musbet * 100 / 10;
            //double sifirfaiz = sifir * 100 / 10;

            //Console.WriteLine("Müsbət ədədlərin faizi: " + menfifaiz + "%");
            //Console.WriteLine("Mənfi ədədlərin faizi: " + musbetfaiz + "%");
            //Console.WriteLine("Sıfırların faizi: " + sifirfaiz + "%");

            #endregion

            #region Task 3

            //İstifadəçi 10 tam ədəd daxil edir. Cüt və tək ədədlərin faizini hesablayın. Sıfır cüt ədəd
            //sayılır.
            //int cut = 0;
            //int tek = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("eded daxil ele");
            //    int eded = int.Parse(Console.ReadLine());

            //    if (eded % 2 == 0)
            //    {
            //        cut++;
            //    }

            //    else if (eded % 2 == 1)
            //    {
            //        tek++;
            //    }



            //}
            //double cutfaiz = cut * 100 / 10;
            //double tekfaiz = tek * 100 / 10;
            //Console.WriteLine("Müsbət ədədlərin faizi: " + cutfaiz + "%");
            //Console.WriteLine("Mənfi ədədlərin faizi: " + tekfaiz + "%");
            #endregion

            #region Task 4 
            //İstifadəçinin daxil etdiyi mənfi olmayan tam ədədin palindrom olub olmadığını yoxlayın.
            //Məsələn, 12321 palindromdur.

            //Console.Write("Eded ddaxil et");
            //    int eded = int.Parse(Console.ReadLine());
            //int ilkeded=eded;
            //    int tersi = 0;

            //    while (eded>0)
            //    {
            //        int qaliq = eded % 10;
            //        tersi = tersi * 10 + qaliq;

            //    }
            //    if (ilkeded == tersi)
            //    {
            //        Console.Write("tersdir");
            //    }

            //    else
            //    {
            //        Console.Write("ters deyil");
            //    }

            #endregion

            #region Task 5 sual
            //İstifadəçi bir tam ədəd və sola sürüşdürüləcək mövqelərin sayını daxil edir. Rəqəmləri
            //dövri şəkildə sola sürüşdürün. Məsələn, 12345 və 3 üçün nəticə 45123 - dür.

            //Console.Write("tam eded");
            //int tameded = int.Parse(Console.ReadLine());
            //Console.Write("movqe sola");
            //int movqesol=int.Parse(Console.ReadLine());

            //while ()


            #endregion

            #region Task 6

            //1-dən 100-ə qədər bütün sadə ədədləri ekrana çıxarın. Xarici dövr ədədləri gəzir, daxili
            //dövr hər ədədin sadə olub olmadığını yoxlayır.

            //for (int i = 2; i <= 100; i++)
            //{
            //    int bolenSayi = 0;

            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            bolenSayi++;
            //        }
            //    }

            //    if (bolenSayi == 0
            //        )
            //    {
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Task 77 sual
            //Console.Write("gun");
            //int gun = int.Parse(Console.ReadLine());

            //Console.Write("ay");
            //int ay = int.Parse(Console.ReadLine());

            //Console.Write("il");
            //int il = int.Parse(Console.ReadLine());



            #endregion





            //// 1-50 kimi ancag cut olan ededler ekrana cixmaliddir lakin 20 ve 26 cixmammalidir 



            //for (int i = 1; i <= 50; i++)
            //{

            //    if (i % 2 == 0)
            //    {

            //        if (i == 20 || i == 26)

            //         continue; 
            //         Console.WriteLine(i);

            //    }

            //}


            //2.İstifadəçi 10 tam ədəd daxil edir. Mənfi, müsbət və sıfır olan ədədlərin hər birinin faizini
            //hesablayın.

            //int musbet = 0;
            //int menfi = 0;
            //int sifir = 0;

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("10 tam eded daxil edin");

            //    int daxiledileneded = int.Parse(Console.ReadLine());

            //    if (daxiledileneded < 0)
            //    {
            //        menfi++;
            //    }

            //    else if (daxiledileneded > 0)
            //    {
            //        musbet++;
            //    }

            //    else
            //    {
            //        sifir++;
            //    }

            //}
            //double musbetfaiz = musbet * 100 / 10;
            //double menfifaiz = musbet * 100 / 10;
            //double sifirfaiz = musbet * 100 / 10;

            //Console.WriteLine("musbetfaiz + %");
            //Console.WriteLine("menfifaiz + %");
            //Console.WriteLine("sifirfaiz + %");

        }
    }
}
