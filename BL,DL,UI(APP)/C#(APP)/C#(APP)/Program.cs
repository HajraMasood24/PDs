using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using C__APP_.UI;


namespace C__APP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[100];
            string[] password = new string[100];
            st:
            int option=mainpg();
            if (option == 1)
            {
                CustomerUI cus=new CustomerUI();
                OrderUI order=new OrderUI();
                cus.Info();
                cus.customerMenu();
                order.DisplayMenu();
                order.PlaceOrder();
                order.CalculateTotalBill();
                Console.WriteLine("Enter 1 to return to main");
                int opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.Clear();
                    goto st;
                }

            }
            if(option==2)
            {
                AdminUI ad = new AdminUI();
                
                UI.AdminUI.adminlogin();
                Continue:
                char op = ad.adpg();
                if (op == 'a')
                {
                    Start:
                    char choice = ad.op4b();
                    if (choice == 'a')
                    {
                        ad.add();
                        int opt = int.Parse(Console.ReadLine());
                        
                        if(opt == 1)
                        {
                            goto Start;
                        }
                    }
                    if (choice == 'b')
                    {
                        ad.viewdetails();
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 1)
                        {
                            goto Start;
                        }

                    }
                    if (choice == 'c')
                    {
                        ad.update();
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 1)
                        {
                            goto Start;
                        }

                    }
                    if (choice == 'd')
                    {
                        ad.deleteuser();
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 1)
                        {
                            goto Start;
                        }
                    }
                    if (choice == 'e')
                    {
                        ad.list();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Start;
                        }
                    }

                    if (choice == 'f')
                    {
                        goto Continue;
                    }
                    
                }

                if (op == 'b')
                {
                    Back:
                    char choice = ad.op4c();
                    if (choice == 'a')
                    {
                        ad.Viewmenu();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }

                    }
                    if (choice == 'b')
                    {
                        ad.additem();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }
                    }
                    if (choice == 'c')
                    {
                        ad.updatemenu();
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 1)
                        {
                            goto Back;
                        }
                    }
                    if (choice == 'd')
                    {
                        
                        ad.Deleteitem();
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
                    ad.customers();
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                    {
                        goto Continue;
                    }
                }
                if(op== 'd')
                {
                    Console.Clear();
                    goto st;
                }

            }

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
