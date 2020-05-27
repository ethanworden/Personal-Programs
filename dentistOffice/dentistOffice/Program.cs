/* this program will show patient information, 
 * and add patients.
 */


using System;
using System.IO;

namespace dentistOffice
{
    class Program
    {

       // public static string file = "information.txt";
        public static StreamReader read = new StreamReader( "information.txt");
      //  public static StreamWriter write = new StreamWriter("information.txt");



        static void Main(string[] args)
        {
            read.Close();
           // write.Close();
            Console.WriteLine("Welcome to Ethan's Dentist Program! \n");
            Main_Menu();
        }
        

        static void Main_Menu()
        {
            Console.WriteLine("\nWould you like to: \n" +
                "Add Patient      See all");
            string response = Console.ReadLine();

            if(response == "Add Patient")
            {
                Add_Patient();

            }
            else if(response == "See all")
            {
                ALL();
            }
            {
                Console.WriteLine("Unknown Response...\n");
                Main_Menu();
            }
        }


        static void Add_Patient()
        {
            Console.Write("Patient's first name: ");
            string fname = Console.ReadLine();
            Console.Write("Patient's last name: ");
            string lname= Console.ReadLine();
         //   File.AppendAllText(file, fname + " "+ lname +"\n");
            Console.WriteLine("Patient has been added");
            Main_Menu();
        }

        static void Schedule()
        {
       //     Console.WriteLine(File.ReadAllText(file));
            Console.WriteLine("Which patient is scheduling an appointment");
            string patient = Console.ReadLine();

         

        }
         
        static void ALL()
        {
            read.Read();
            Console.WriteLine("\nShowing all patients: ");
            Console.WriteLine(read.ReadLine());
            Main_Menu();
        }
    }
}
