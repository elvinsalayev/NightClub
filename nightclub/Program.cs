using System;

namespace nightclub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.GetData();


            if (human.age < 16)
            {
                human.GoHome();
            }
            else if (human.age < 18) 
            {
                human.Under18();
                string permission = Console.ReadLine();

                if (permission == "yes")
                {
                    human.permission = true;
                }
                else if (permission == "no")
                {
                    human.permission = false;
                }
                else
                {
                    human.Under18();
                }


                if (human.permission == true)

                {
                    human.Welcome();
                }
                else if (human.permission == false)
                {
                }
            }
            else
            {
                human.Welcome();
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
