using System;
using System.ComponentModel.DataAnnotations;

public class Program
{
    static void Main()
    {
       
        Console.WriteLine("Hello! Welcome to the world of Pokemon.");

        Thread.Sleep(1000); // just to delay code by milliseconds

        Console.WriteLine("Pokemon come in all different types,");

        Thread.Sleep(500);

        Console.WriteLine("So first, why don't you enter your name.");

        string input = Console.ReadLine();

        // Repeat what was said to the user
        Console.Write("Your name is \"");
        Console.Write(input);
        Console.Write("\"?");

        Thread.Sleep(1000);

        Console.WriteLine(" That's a nice name");

        Thread.Sleep(1000);

        Console.WriteLine("Curious to see if you can handle my challenge.");
        
        Thread.Sleep(1000);
        Console.WriteLine("Ready?");
        bool correct = false;
        

        do // to keep looping until i get the desired answer
        {
            string confirm = Console.ReadLine();
            if (confirm.ToLower() == "yes" || confirm.ToLower() == "sure" || confirm.ToLower() == "yeah")
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("Not the answer I'm looking for...");
            }

        } while (correct == false);

        Console.WriteLine("Good");

        Thread.Sleep(1000);

        string mon = ""; // stores the pokemon choice for later use

        Console.WriteLine("Now do tell which of these starters would you like?");
        Thread.Sleep(1000);
        Console.WriteLine("Charmander, Squirtle, or Bulbasoar?");

        do
        {
            string[] names = { "charmander", "squirtle", "bulbasoar" };
            string choice = Console.ReadLine();
            bool correct_choice = names.Contains(choice.ToLower());

            if (correct_choice == true)
            {
                mon = choice.ToLower();
            }
            else
            {
                Console.WriteLine("Not what I'm offering, try again...");
            }

        } while (mon == "");

        Console.WriteLine("Good choice.");

        Thread.Sleep(1000);

        Console.WriteLine("Now let's have you fight your first opponent.");

        Thread.Sleep(800);

        Console.WriteLine("You have a Lv 5 Weedle in front of you.");

        Thread.Sleep(900);

        Console.WriteLine("Which of these moves would you like to use?");

        // stats to keep track of
        int opp_hp = 5; 
        int hp = 7;
        bool opp_debuffed = false;
        bool opp_less_atk = false;
        int opp_sleep = 0;

        do // messy code of handling move choices. not my proudest moment, I've only coded in gdscript
        {

            if (mon == "charmander")
            {
                Console.WriteLine("Ember, Scratch, Tail Whip");
            }
            else if (mon == "squirtle")
            {
                Console.WriteLine("Water Gun, Tackle, Baby Doll Eyes");
            }
            else
            {
                Console.WriteLine("Drain, Tackle, Spore");
            }

            string[] c_names = { "ember", "scratch", "tail whip" };
            string[] s_names = { "water gun", "tackle", "baby doll eyes" };
            string[] b_names = { "drain", "tackle", "spore" };
            string choice = Console.ReadLine().ToLower();
            bool correct_choice = false;

            if (mon == "charmander")
            {
                correct_choice = c_names.Contains(choice.ToLower());
                if (correct_choice == true)
                {
                    if (choice.ToLower() == "ember")
                    {
                        Console.WriteLine("You used Ember, and dealt 2 damage.");
                        opp_hp -= 2;
                        if (opp_debuffed == true)
                        {
                            opp_hp -= 1;
                        }
                        Thread.Sleep(1000);
                    }
                    else if (choice.ToLower() == "scratch")
                    {
                        Console.WriteLine("You used Scratch, and dealt 1 damage.");
                        opp_hp -= 1;
                        if (opp_debuffed == true)
                        {
                            opp_hp -= 1;
                        }
                        Thread.Sleep(1000);
                    }
                    else if (choice.ToLower() == "tail whip")
                    {
                        Console.WriteLine("You used Scratch, and now they have less defense");
                        opp_debuffed = true;

                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine("Not a choice.");
                }
            }
            else if (mon == "squirtle")
            {
                correct_choice = s_names.Contains(choice.ToLower());
                if (correct_choice == true)
                {
                    if (choice.ToLower() == "water gun")
                    {
                        Console.WriteLine("You used Water Gun, and dealt 2 damage.");
                        opp_hp -= 2;
                        if (opp_debuffed == true)
                        {
                            opp_hp -= 1;
                        }
                        Thread.Sleep(1000);
                    }
                    else if (choice.ToLower() == "tackle")
                    {
                        Console.WriteLine("You used Tackle, and dealt 1 damage.");
                        opp_hp -= 1;
                        if (opp_debuffed == true)
                        {
                            opp_hp -= 1;
                        }
                        Thread.Sleep(1000);
                    }
                    else if (choice.ToLower() == "baby doll eyes")
                    {
                        Console.WriteLine("You used Baby Doll Eyes, and now they have less attack");
                        opp_less_atk = true;
                        
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine("Not a choice.");
                }
            }
            else if (mon == "bulbasoar")
            {
                correct_choice = b_names.Contains(choice.ToLower());
                if (correct_choice == true)
                {
                    if (choice.ToLower() == "drain")
                    {
                        Console.WriteLine("You used Drain, and dealt 2 damage.");
                        opp_hp -= 2;
                        if (opp_debuffed == true)
                        {
                            opp_hp -= 1;
                        }
                        Thread.Sleep(1000);
                    }
                    else if (choice.ToLower() == "tackle")
                    {
                        Console.WriteLine("You used Tackle, and dealt 1 damage.");
                        opp_hp -= 1;
                        if (opp_debuffed == true)
                        {
                            opp_hp -= 1;
                        }
                        Thread.Sleep(1000);
                    }
                    else if (choice.ToLower() == "spore")
                    {
                        Console.WriteLine("You used Spore, and now they can't attack for 2 turns.");
                        opp_sleep = 2;
                        
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine("Not a choice.");
                }
            }


            if (opp_hp > 0)
            {
                if (opp_sleep <= 0)
                {
                    if (opp_less_atk == true)
                    {
                        Console.WriteLine("Weedle using Pin Needle, and you took 1 damage.");
                        hp -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Weedle using Pin Needle, and you took 2 damage.");
                        hp -= 2;
                    }

                }
                else
                {
                    opp_sleep -= 1;
                }
            }
            else
            {
                Console.WriteLine("Nice going, you'll do great for the actual game.");
                Thread.Sleep(1000);
                System.Environment.Exit(1);

            }



        } while (hp > 0 | opp_hp > 0);

        if (hp <= 0 && opp_hp > 0)
        {
            Console.WriteLine("Nice try, restart the game to try again.");
        }
        else if (opp_hp <= 0 && hp > 0)
        {
            Console.WriteLine("Nice going, you'll do great for the actual game.");
        }





    }
}