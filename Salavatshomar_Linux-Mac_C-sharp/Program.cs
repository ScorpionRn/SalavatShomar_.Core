using System;


namespace Salavatshomar_Linux_Mac_C_sharp
{
    class Program
    {
        //Variable
        static int salavat_count;

        static void Main(string[] args)
        {
            Console.Title = "Salavat shomar";

            //Start
            start:
            Console.Clear();
            Console.Write("What do you want to do? \n|___help :: Show help message\n|___start :: Start Counting\n|___about :: Show about message\n==>");
            string command = Console.ReadLine();
            //Commands
            if (command == "start")
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Counts = " + salavat_count);

                    Console.ReadKey();

                    Console.Clear();

                    salavat_count++;
                }
            }
            else
            if (command == "help")
            {
                Console.Clear();

                Console.Write("Use Ctrl + C to stop app.");
                Console.Write("for back enter 'back' ==>");
                string back = Console.ReadLine();
                if (back == "back")
                {
                    goto start;
                }
            }
            else
            if (command == "about")
            {
                Console.Clear();

                Console.Write("Developer: Scorpion_Rn\nTelegram Channel: https://t.me/salavat_shomar_app_channel \nGithub: \nSite: \n");
                Console.Write("for back enter 'back' ==>");
                string back = Console.ReadLine();
                if (back == "back")
                {
                    goto start;
                }
            }
        }
    }
}
