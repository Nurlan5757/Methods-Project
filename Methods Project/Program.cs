


namespace Methods_Project
{
    internal class Program
    {
        static void Main()
        {
            string namesList = "Nurlan,Ulduz,Dunya";
            int num;
            do
            {
                Console.WriteLine("1.Siyahiya bax");
                Console.WriteLine("2.Siyahiya add elave et");
                Console.WriteLine("3.Siyahida adi yoxla");
                Console.WriteLine("4.Daxil edilmis indexdeki adi goster");
                Console.WriteLine("0.Menudan cix");

                Console.Write("Enter your num:");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    switch (num)
                    {
                        case 1:
                            Seename();
                            break;
                        case 2:
                            Addname();
                            break;
                        case 3:
                            Checkname();
                            break;
                        case 4:
                            Index();
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid num. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            } while (num != 0);
        }
        static void Seename()
        {
            Console.WriteLine("Names in the list:Nurlan,Ulduz,Dunya");
            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }
        }
        static void Addname()
        {
            Console.Write("Enter name to add: ");
            string newName = Console.ReadLine();

       
                if (newName.Length > 2 && ) 
                {
                    namesList.Add(newName);
                    Console.WriteLine("Name added to the list.");

                }
                else
                {
                    Console.WriteLine("this is wrong");
                }
            
        }
        static void Checkname()
        {
            Console.Write("Enter Name to Check: ");
            string nameToCheck = Console.ReadLine();


            if ()
            {

                Console.WriteLine("var");
            }
            else
            {
                Console.WriteLine("yoxdur");
            }

        }
        static void Index()
        {



        }
    }   
}














