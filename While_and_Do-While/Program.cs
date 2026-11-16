using System.Security.Cryptography.X509Certificates;

namespace While_and_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //ASCII cədvəlində 0-dan 127-yə qədər kodları və onlara uyğun simvolları ekrana çıxarın.

            //int i = 0;
            //while (i <= 127)
            //{
            //    Console.WriteLine(i + " = " + (char)i);
            //    i++;
            //}
            #endregion

            #region Task 2
            //İstifadəçinin daxil etdiyi say qədər ulduzdan ibarət üfüqi xətt çıxarın.

            //Console.Write("say daxil et: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = 0;

            //while (b < a)
            //{
            //    Console.Write("*");
            //    b++;
            //}

            //Console.ReadLine();
            #endregion

            #region Task 3

            //1-dən 50-yə qədər ədədlər arasından yalnız cüt olanları ekrana çıxarın.


            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Console.ReadLine();
            #endregion

            #region Task 4
            //İstifadəçinin daxil etdiyi iki ədəd arasındakı cüt ədədlərin cəmini və tək ədədlərin hasilini
            //hesablayın.Məsələn, 10 və 30.


            //Console.Write("Birinci");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Ikinci");
            //int b = int.Parse(Console.ReadLine());

            //int cutCem = 0;
            //int tekHasil = 1;

            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cutCem += i;
            //    }
            //    else
            //    {
            //        tekHasil *= i;
            //    }
            //}

            //Console.WriteLine("cemi: " + cutCem);
            //Console.WriteLine("hasili: " + tekHasil);

            #endregion

            #region Task 5

            //1-dən 100-ə qədər 3-ə qalıqsız bölünən bütün ədədləri ekrana çıxarın.
            //int a = 1;

            //while (a<=100)
            //{
            //    if (a%3==0)
            //    {
            //        Console.WriteLine(a);

            //    }
            //    a++;

            //}

            //Console.ReadLine();
            #endregion

            #region Task 6
            //Daxil edilən mənfi olmayan tam ədədin faktorialını hesablayın. Məsələn, 5! = 1 × 2 × 3
            //× 4 × 5.
            //Console.Write("eded daxil et: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = 1;
            //int i = 1;

            //while (i <= a)
            //{
            //    b = b * i;
            //    i++;
            //}

            //Console.WriteLine(b);


            #endregion

            #region Task 7 
            //İstifadəçi əsas və mənfi olmayan tam üst daxil edir. Əsasın həmin qüvvətini dövrlə
            //hesablayın.Məsələn, 2 və 3 üçün nəticə 8 - dir.

            //int esas = int.Parse(Console.ReadLine());
            //int ust = int.Parse(Console.ReadLine());

            //int netice = 1;

            //for (int i = 1; i <= ust; i++)
            //{
            //    netice = netice * esas;
            //}

            //Console.WriteLine(netice);



            #endregion

            #region Task 8
            //İstifadəçinin daxil etdiyi tam ədədin rəqəmlərinin sayını və rəqəmlərinin cəmini
            //hesablayın.

            //int eded = int.Parse(Console.ReadLine());

            //int say = 0;
            //int cem = 0;

            //while (eded > 0)
            //{
            //    int reqem = eded % 10;

            //    cem = cem + reqem;

            //    say++;

            //    eded = eded / 10;
            //}

            //Console.WriteLine(say);
            //Console.WriteLine(cem);


            #endregion

            #region Task 9

            //İstifadəçinin daxil etdiyi tam ədədin rəqəmlərini tərsinə düzərək nəticəni çıxarın.


            //Console.Write("eded");
            //int eded = int.Parse(Console.ReadLine());

            //int ters = 0;

            //while (eded > 0)
            //{
            //    int reqem = eded % 10;

            //    ters = ters * 10 + reqem;

            //    eded /= 10;
            //}

            //Console.WriteLine(ters);



            #endregion

            #region Task 10

            //İstifadəçinin daxil etdiyi sıfırdan fərqli tam ədədin qalıqsız bölündüyü müsbət bölənləri
            //ekrana çıxarın.
            //Console.Write("Eded");
            //int eded = int.Parse(Console.ReadLine());
            //int i = 1;

            //while (i <= eded)
            //{
            //    if (eded % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}


            #endregion

            #region Task 11
            //İstifadəçinin daxil etdiyi tam ədədin sadə olub olmadığını müəyyən edin. 1 sadə ədəd
            //
            //
            //deyil.

            //int eded = int.Parse(Console.ReadLine());

            //int i = 2;


            //while (i < eded)
            //{
            //    if (eded % i == 0)
            //    {
            //        Console.WriteLine("Sade deyil");
            //    }

            //    i++;


            //}

            #endregion

            #region Task 12?
            //Daxil edilən ədəddə yan-yana eyni olan iki rəqəmin olub olmadığını yoxlayın. Məsələn,
            //1223 - də 22 var.
            #endregion

            #region Task 13
            //Ədədin rəqəmlərinin soldan sağa azalmayan ardıcıllıqla düzülüb düzülmədiyini yoxlayın.
            //Məsələn, 12299 uyğundur, 122044 uyğun deyil.

            int eded = int.Parse(Console.ReadLine());
            int say = 0;

            while (eded >= 10)
            {
                if (eded % 10 < eded / 10 % 10)
                {
                    say = 1;
                    break;
                }

                eded /= 10;
            }

            if (say == 0)
            {
                Console.WriteLine(" uygun deyil");
            }
            else
            {
                Console.WriteLine(" uygundu");
            }
            #endregion

            #region Task 14?
            #endregion
        }
    }
}