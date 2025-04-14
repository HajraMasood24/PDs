using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace C__APP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[100];
            string[] password = new string[100];
            int option=mainpg();
            if(option==2)
            {
                Admin admin = new Admin();
                string path = "C:\\2nd semester\\OOP\\PD\\C#(APP)\\admin.txt";
               

                
                admin.adminlogin(path, name, password);
                Continue:
                char op = adpg();
                if (op == 'a')
                {
                    Start:
                    char choice = admin.op4b();
                    if (choice == 'a')
                    {
                        admin.list();
                        int opt = int.Parse(Console.ReadLine());
                        
                        if(opt == 1)
                        {
                            goto Start;
                        }
                    }
                    if (choice == 'b')
                    {
                        admin.view();
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 1)
                        {
                            goto Start;
                        }

                    }
                    if (choice == 'c')
                    {
                        admin.update();
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 1)
                        {
                            goto Start;
                        }

                    }
                    if(choice == 'e')
                    {
                        goto Continue;
                    }
                    
                }

                if (op == 'b')
                {
                    Back:
                    char choice = admin.op4c();
                    if (choice == 'a')
                    {
                        admin.Viewmenu();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }

                    }
                    if (choice == 'b')
                    {
                        admin.additem();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }
                    }
                    if (choice == 'c')
                    {
                        admin.updatemenu();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }
                    }
                    if (choice == 'd')
                    {
                        
                        admin.Deleteitem();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }
                    }
                    if (choice == 'e')
                    {
                        goto Continue;
                    }
                }
                if (op == 'c')
                {
                    admin.customers();
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                    {
                        goto Continue;
                    }
                }

            }


        }
        static char adpg()
        {
            int x = 15, y = 5;
            char option;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("********************WELCOME TO ADMIN PAGE**************************");
            
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("a. View Golden Card Holders");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("b. Menu");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("c. Customer list");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("d. Return main page");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine("Enter option:");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static int mainpg()
        {
            int x = 15, y = 5;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("###################################################################  ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(" 	 	   		@@                                       	        " );
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(" 	       		@@                                         		    " );
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("  	       		@@      @@@  @@@@ @@@@ @@@@                		    ");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(" 	      		@@     @   @  @@   @@  @                            ");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("   	       		@@  @@ @@@@@  @@   @@  @@@                          ");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine(" 		 @@     @@@@@@ @   @  @@   @@  @@@@@          		        ");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine("  		 @@				 		                      	            ");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine(" 		 @@       @@@  @  @ @@@@  @@@   @@@            		        ");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine("  		 @@      @   @ @  @ @  @ @   @ @   @				        ");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine("  	 	 @@      @   @ @  @ @  @ @   @ @@@@             			");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine("  		 @@@@@@@  @@@   @@  @  @  @@ @  @@@@@            		    " );
            Console.SetCursorPosition(x, y + 12);
            Console.WriteLine("                                	 	@                      		    ");
            Console.SetCursorPosition(x, y + 13);
            Console.WriteLine("                           	 	  @@                                ");
            Console.SetCursorPosition(x, y + 14);
            Console.WriteLine("*****************************************************************   ");
            Console.SetCursorPosition(x, y + 15);
            Console.WriteLine("		* 		  Where every sip tells a story     *               ");
            Console.SetCursorPosition(x, y + 16);
            Console.WriteLine("		*  	 Coffee  •  Comfort  •  Community       *               ");
            Console.SetCursorPosition(x, y + 17);
            Console.WriteLine("*****************************************************************   ");
            Console.SetCursorPosition(x + 4, y + 18);
            Console.WriteLine("1.Customer                                                         " );
            Console.SetCursorPosition(x + 4, y + 19);
            Console.WriteLine("2.Admin                                                   ");
            Console.SetCursorPosition(x + 4, y + 20);
            Console.WriteLine("3.Exit                                                  ");

            Console.SetCursorPosition(x, y + 22);
            Console.WriteLine("##################################################################   ");
            Console.SetCursorPosition(x + 4, y + 23);
            Console.WriteLine("Select an option:");
            Console.SetCursorPosition(x + 4, y + 24);
            int op;
            op=int.Parse(Console.ReadLine());
            return op;


        }
        static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;

        }
    }
}
