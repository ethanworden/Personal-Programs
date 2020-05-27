// Checking if two strings are anagrams 
//Examples: (FIRED, FRIED) (SADDER, DREADS) (LISTEN, SILENT)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Enter String #1: ");
            String str1 = Console.ReadLine();
            Console.WriteLine("  Enter String #2: ");
            String str2 = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("The strings are anagrams =  " + anagram(str1, str2));
            Console.ReadKey();


        }

        static bool anagram(string a, string b)
        {
            if ((a.Length != b.Length) || (a == b)) 
            { 
                return false; 
            }else{
                
                while(a.Length >0)
                {
                    
                    if (b.Contains(a[0]))
                    {
                        Console.WriteLine($"{a[0]}  is located at position: {b.IndexOf(a[0])} of the second string.");
                        int delete = b.IndexOf(a[0]);
                        b = b.Remove(delete,1);                   
                        a = a.Remove(0, 1);
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                        Console.WriteLine("\n\n");
                    }else{
                        return false;
                         }     
                }
                  if( b.Length != 0)
                  {
                   return false;
                  }
                   return true;
                }
            }
        }
    }


