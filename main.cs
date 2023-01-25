using System;
using System.Net;
using System.Text;

namespace Softplanner
{   
   
   
   class Softplanner  {

         static string action;
         static bool restart = false;
         static void Main(string[] args) {
            start();
         }

         static void start() {
            if(restart == false) {
               for (int i = 0; i < 100; i++) {
                  Console.WriteLine("");
               }

               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("  -------------------------- Start -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
            }
           
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("      Action (show / new) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            action = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.Write("      Action =  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(action);
            
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Are you sure (yes / no) : ");
            Console.ForegroundColor = ConsoleColor.Blue;

            if (Console.ReadLine() == "yes") {

               if (action == "show") {
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("  -------------------------- Show -----------------------------");
                  Console.ForegroundColor = ConsoleColor.White; 
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
            
                  show();
               } else { //create
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;
                  Console.WriteLine("  -------------------------- Create -----------------------------");
                  Console.ForegroundColor = ConsoleColor.White; 
                  Console.WriteLine("");
                  Console.WriteLine("");
                  Console.ForegroundColor = ConsoleColor.Green;

                  create();
               }

            } else {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("  -------------------------- Restart -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
               restart = true;
               start();
            }

         }

         static void show() {
      
         }

         static void create() {
            string[] test = {"","","","","",""};
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Typ :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            test[0] = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Name :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            test[1] = Console.ReadLine();;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      from - to :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            test[2] = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Programmer :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            test[3] = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Discription :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            test[4] = Console.ReadLine();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      on GitHub (yes / no) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            test[5] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("     Loading...");
            Thread.Sleep(800);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Name :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Typ :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine(typ);;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Discription :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(discription);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      Programmer :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(programmer);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      from - to :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(fromto);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("      on GitHub (yes / no) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(github);

            Console.WriteLine ("");
            Console.WriteLine ("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write ("      Are you sure (yes / no) :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            
            if (Console.ReadLine() == "yes") {
               save();
               return;
            } else {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("  -------------------------- Restart -----------------------------");
               Console.ForegroundColor = ConsoleColor.White;
               restart = true;
               start();
            }
            
         }

         
         static bool save() { // save and return "true" if it worked else: "false"
            int test1 = 1;
            int test2 = 2;
            if (test1 == test2) { //just for testing.
               return true;
            } else {
               Console.WriteLine("");
               Console.WriteLine("");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.Write("      This didn t worked! Please try again.");
               return false;
            }
         }
     }
}