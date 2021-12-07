using System;

namespace JukeBox
{
    
   public class Program
    {
        static void Dance() {
            Console.WriteLine("People are dancing");
        }
        static void Main(string[] args)
        {

            string input;
            int money;
            Console.WriteLine("Choose the amount of your money: ");
            input = Console.ReadLine();
            money = Convert.ToInt32(input);
            // int oneDancePrice = 1;

            Songs mySong = new Songs();
            Dance danceMove = new Dance();


            for (int i = money; i > 1; i--)
            {
                
                Dance();
                Console.WriteLine(mySong.genre);
                if (Equals(mySong, "rock"))
                {
                    Console.WriteLine(danceMove.danceMove); 
                }
                else
                {
                    Console.WriteLine("just jump");
                }
            }
                  
            }

        }

        }
    
   

