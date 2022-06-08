using System;

class HelloWorld
{

    static void Main()
    {
        bool i = false;
        bool a;

        do
        {

            string vastaus;
            do
            {

                a = false;
                Console.WriteLine("Valitse joku, kivi = 1, paperi = 2, sakset = 3");
                vastaus = Console.ReadLine().ToLower();
                if (vastaus != "1" && vastaus != "2" && vastaus != "3" && vastaus != "kivi" && vastaus != "paperi" && vastaus != "sakset")
                {
                    a = true;
                    Console.Clear();
                    Console.WriteLine("Anna sopiva vastaus");

                }
            }
            while (a == true);
            Random rnd = new Random();

            int random = (rnd.Next(1, 4));


            switch (random)
            {
                case 1:

                    Console.WriteLine("Tietokone laittoi kiven");
                    if (vastaus == "1" || vastaus == "kivi")
                    {
                        Console.WriteLine("Tasapeli!");
                    }

                    if (vastaus == "2" || vastaus == "paperi")
                    {
                        Console.WriteLine("Sinä voitit!");
                    }
                    if (vastaus == "3" || vastaus == "sakset")
                    {
                        Console.WriteLine("Sinä hävisit!");
                    }

                    break;
                case 2:

                    Console.WriteLine("Tietokone laittoi paperin");

                    if (vastaus == "1" || vastaus == "kivi")
                    {
                        Console.WriteLine("Sinä hävisit!");
                    }

                    if (vastaus == "2" || vastaus == "paperi")
                    {
                        Console.WriteLine("Tasapeli!");
                    }
                    if (vastaus == "3" || vastaus == "sakset")
                    {
                        Console.WriteLine("Sinä voitit!");
                    }
                    break;
                case 3:

                    Console.WriteLine("Tietokone laittoi sakset");
                    if (vastaus == "1" || vastaus == "kivi")
                    {
                        Console.WriteLine("Sinä voitit!");
                    }

                    if (vastaus == "2" || vastaus == "paperi")
                    {
                        Console.WriteLine("Sinä hävisit!");
                    }
                    if (vastaus == "3" || vastaus == "sakset")
                    {
                        Console.WriteLine("Tasapeli!");
                    }
                    break;
            }



            Console.WriteLine("Haluatko jatkaa? k/e");
            string loppu = Console.ReadLine();

            if (loppu == "k")
            {

                i = true;
            }
            else
            {

                i = false;

            }


            Console.Clear();


        }
        while (i == true);
        Console.WriteLine("Hei hei!");
    }
}



