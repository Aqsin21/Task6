using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
        Task15();
        Task16();
        Main();
    }

    // task 1

    static void Task1()
    {
    // verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?
    l1:
        Console.WriteLine("daxilinde a ve b herfi olan metn daxil edin");
        string Metn = Console.ReadLine();

        int adig = 0;
        int bdig = 0;

        foreach (char a in Metn)
        {
            if (a == 'a')
            {
                adig++;
            }
        }
        foreach (char b in Metn)
        {

            if (b == 'b')
            {
                bdig++;
            }
        }

        if (adig == 0 || bdig == 0)
        {
            Console.WriteLine("metndeki a veya b herflerinin sayi 0 dir");
            goto l1;
        }
        Console.WriteLine($"metndeki a herflerinin sayi {adig}, metndeki b herflerinin sayi {bdig}");
        int result = adig / bdig;
        Console.WriteLine($"metndeki a be heflerinin sayinin nisbeti {result}");














    }
    // task 2
    static void Task2()
    {
    //  verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
    l2:
        Console.WriteLine("metn daxil edin");
        string metn = Console.ReadLine();
        char alet = 'a';

        for (int i = 0; i < metn.Length; i += 2)
        {

            if (metn[i] != alet)
            {
                Console.WriteLine("tek yerde duran herflerin hamisi a deyil");
                goto l2;
            }

        }


        Console.WriteLine("tek yerde duranlarin hamisi a herfidir");
    }
    // task 3
    static void Task3()
    {
    l3:
        Console.WriteLine("metn daxil edin");
        string metn = Console.ReadLine();

        int bdig = 0;

        for (int i = 0; i < metn.Length; i += 2)
        {
            if (metn[i] != 'b')
            {
                bdig++;
                goto l3;
            }
        }
        Console.WriteLine($"tek yerde duran b simvollarin sayi:{bdig}");
    }
    //task 4
    static void Task4()
    {
    l4:
        Console.WriteLine("metn daxil edin:");
        string metn = Console.ReadLine();
        int a = metn.IndexOf('a');
        if ((a + 1) % 2 == 0)
        {
            Console.WriteLine("ilk rast gelinen a herfi cut yerdedi");
        }

        else
        {
            Console.WriteLine("ilk rast gelien a herfi tek yerdedi");
            goto l4;
        }





    }
    //task 5
    static void Task5()
    {
    l5:
        Console.WriteLine("Icinde a,b ve c herfleri olan metn daxil edin:");
        string metn = Console.ReadLine();
        int a = metn.IndexOf('a');
        int b = metn.IndexOf("b");
        int c = metn.IndexOf("c");

        if (a == -1 || b == -1 || c == -1)
        {
            Console.WriteLine("herflerden hansisa daxil edilmeyi");
            goto l5;
        }
        else
        {
            if (a < c && a < b)
            {
                Console.WriteLine("ilk gelen herf a herfidir");
            }
            else if (b < a && b < c)
            {
               Console.WriteLine("ilk gelen herf b herfidir");

            }
            else if (c < a && c < b)
            {
                Console.WriteLine("ilk daxil edilen herf c herfidir");
            }
        }

    }
    // Task 6
    static void Task6()     
    {
    l6:
        Console.WriteLine("icinde a herfi olan metn daxil edin");
        string metn = Console.ReadLine();
    }
    // Task 7
    static void Task7()
    {
    l7:
        Console.WriteLine("icinde a,b ve cherfi olan metn daxil edin");
        string metn = Console.ReadLine();
        int a = metn.IndexOf('a');
        int b = metn.IndexOf('b');
        int c = metn.IndexOf("c");

        if (a == -1 || b == -1 || c == -1)
        {
            Console.WriteLine("daxil edilen metnde her hansisa herf yoxdu");
            goto l7;

        }
        else
        {
            if (a < b && b < c)
            {
                Console.WriteLine(" a herfi b herfinden qabaq b herfi c herfinden qabaq gelir");
                goto l7;
            }
            else
            {
                Console.WriteLine(" a herfi b-den qabaq b herfide c-den qabaq gelmelidir");
                goto l7;
            }
        }

    }
     // Task 8
    static void Task8()
    {    
        l8:
        Console.WriteLine("icinde a herfi olan metn daxil edin");
        string Metn = Console.ReadLine();
        int a = Metn.IndexOf('a');
        int b = a + 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Metn[b]);
            goto l8;
            }
        
        
    }

    // Task 9

    static void Task9()
    {
        l9:
        Console.WriteLine("Minumum 6 herfli metn daxil edin");
        string Metn = Console.ReadLine();

        if(Metn.Length<6)
        {
            Console.WriteLine("Daxil edilen metn sertleri odemir");
            goto l9;
        }
        int a = Metn.Length;
        int a1 = Metn[a - 1];
        int a2 = Metn[a - 2];
        int a3 = Metn[a - 3];

        char b1 = Metn[0];
        char b2 = Metn[1];
        char b3 = Metn[2];

        if(a1==b1&& a2==b2&& a3 == b3)
        {
            Console.WriteLine("Verilmis metnde ilk 3 her son 3 herfin tersine beraberdir");
                
        }

    }

    // Task 10
    static void Task10()
    {
        Console.WriteLine("Icinde eded olan metn daxil edin");
        string Metn = Console.ReadLine();
        string result = "";
        foreach(char c in Metn)
        {
            if (char.IsLetter(c))
            {
                result += c;
            }
    }


  

       




    }

    // Task 11

    static void Task11()
    {
        Console.Write("Metn daxil edin: ");
        string Metn = Console.ReadLine();


        string newmetn = "";

        foreach (char c in Metn)
        {

            if (c == 'a')
            {
               newmetn += 'b';
            }


            newmetn += c;
        }



        Console.WriteLine("Modified string: " + newmetn);



    }

    // Task 12

    static void Task12()
    {
    //12) Verilmish metinde  ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. 
    l1:
        Console.Write("Input a text with a letters ");
        string text = Console.ReadLine();

        Console.WriteLine(text);
        int firstAIndex = text.IndexOf('a');


        if (firstAIndex != -1)
        {

            int lastAIndex = text.LastIndexOf('a');


            if (firstAIndex == lastAIndex)
                Console.WriteLine(text);


            string middleSection = text.Substring(firstAIndex + 1, lastAIndex - (firstAIndex + 1));


            string modifiedStr = text.Substring(0, firstAIndex + 1) + middleSection.Replace("a", "") + text.Substring(lastAIndex);


            Console.WriteLine(modifiedStr);
        }

        else
        {
            Console.WriteLine("There is no a in the text: ");
            goto l1;
        }


    }






    // Task 13

    static void Task13()
    {
    // 13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et. 

      
    


        
    }

    // Task 14

    static void Task14()
    {
        string text = "salam";

        for (int i = 0; i < text.Length - 1; i++)
        {
            char x = text[i + 1];

            if (i % 2 == 0)
            {
                text = text.Remove(i, 1);
                text = text.Insert(i, $"{char.ToUpper(x)}");
            }
        }
        Console.WriteLine(text);

    }
    static void Task15()
    {

    }


    // Vurma cedveli
     
    static void  Task16()
    {
        for (int a = 0; a <= 10; a++)
        {
             for (int  b = 0; b <= 10; b++)
            {
                Console.WriteLine("{0}x{1}",a,b,a*b);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
        
        
    }
























}

        


    
        
           













 













































































    





















    

