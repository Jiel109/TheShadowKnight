using System;

namespace TheShadowKnight
{
    public class MainMenu
    {
        static String ans;
        public static void Main(String[] args)
        {
            while (true)    
            {
                Console.WriteLine("THE SHADOW KNIGHT\n");
                Console.WriteLine("[1] NEW GAME");
                Console.WriteLine("[2] LOAD GAME");
                Console.WriteLine("[3] CAMPAIGN MODE");
                Console.WriteLine("[4] CREDITS");
                Console.WriteLine("[5] EXIT");
                Console.Write("Enter option: ");
                ans = Console.ReadLine();

                if (ans.Equals("1"))
                {
                    CharacterCreation.Character();
                    Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        continue;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        Console.WriteLine("Thank you for playing the game!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }

                }
                else if (ans.Equals("2"))
                {
                    Console.WriteLine("Load game feature still in development. To be implemented in the future.");
                    Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        continue;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        Console.WriteLine("Thank you for playing the game!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                else if (ans.Equals("3"))
                {
                    CampaignMode.Campaign();
                    Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        continue;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        Console.WriteLine("Thank you for playing the game!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                else if (ans.Equals("4"))
                {
                    Credits.Cred();
                    Console.WriteLine("\nReturn to Main Menu? [Y/N]");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        continue;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        Console.WriteLine("Thank you for playing the game!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                else if(ans.Equals("5"))
                {
                    Console.WriteLine("Thank you for playing the game!");
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.");
                    continue;
                }
            }
        }
    }
}