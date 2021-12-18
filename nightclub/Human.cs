using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nightclub
{
    internal class Human
    {
        public string name;
        public string surname;
        public int age;
        public bool permission;

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                    < >                       ");
            Console.WriteLine("                  <<< >>>                     ");
            Console.WriteLine("                <<<<< >>>>>                   ");
            Console.WriteLine("              <<<<<<   >>>>>>                 ");
            Console.WriteLine("            <<<<<<<     >>>>>>>               ");
            Console.WriteLine("         <<<<<<<<         >>>>>>>>            ");
            Console.WriteLine("       <<<<<<<<<             >>>>>>>>>        ");
            Console.WriteLine("    <<<<<<<<<<                 >>>>>>>>>>     ");
            Console.WriteLine("<<<<<<<<<<<    Day`n Nite CLub    >>>>>>>>>>> ");
            Console.WriteLine("    <<<<<<<<<<                 >>>>>>>>>>     ");
            Console.WriteLine("    <<<<<<<<<<                 >>>>>>>>>>     ");
            Console.WriteLine("    <<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>     ");
            Console.WriteLine("    <<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>     ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ResetColor();
        }
        public void GetData()
        {
            Console.WriteLine("Please tap ENTER to start...");
            Console.ReadKey();
            Console.Clear();
            Start();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Please fill in the required information... ");
            Console.Write("I wanna know your ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("name ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(": ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Start();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Your ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("surname ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(": ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            surname = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Start();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{name} {surname}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" , please write your ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("age ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(": ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            age = Convert.ToInt32(Console.ReadLine());
            Start();
        }
        public void Welcome()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("╔╗╔╗╔╦═══╦╗──╔╗──╔═══╦═══╦═╗╔═╦═══╗");
            Console.WriteLine("║║║║║║╔══╣║──║║──║╔═╗║╔═╗║║╚╝║║╔══╝");
            Console.WriteLine("║║║║║║╚══╣║──║║──║║─╚╣║─║║╔╗╔╗║╚══╗");
            Console.WriteLine("║╚╝╚╝║╔══╣║─╔╣║─╔╣║─╔╣║─║║║║║║║╔══╝");
            Console.WriteLine("╚╗╔╗╔╣╚══╣╚═╝║╚═╝║╚═╝║╚═╝║║║║║║╚══╗");
            Console.WriteLine(" ╚╝╚╝╚═══╩═══╩═══╩═══╩═══╩╝╚╝╚╩═══╝");
        }
        public void Under18()
        {
            Console.ResetColor();
            Console.Clear();
            Start();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Your parents know you're here, don't they? >:O \nDo you have permission from them? (yes or no) ");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void GoHome()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Go home sweet baby and play with your toys! :D");
        }

    }
} 
