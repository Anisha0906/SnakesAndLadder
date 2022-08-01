using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {      
        public void StartPlaying()
        {
            int StartPoint = 0;
            int RanDice;
            int ComputerChoice;
            Console.WriteLine("Game Started! Good Luck ");
            Random Random = new Random(); 
            RanDice = Random.Next(1, 7); 
            Console.WriteLine("player Role Dice number is:" + " " + RanDice);
            ComputerChoice = Random.Next(0, 3);  
            Console.WriteLine("Dice value:" + ComputerChoice); 
            switch (ComputerChoice) 
            {
                case 0:                            
                    Console.WriteLine("No Play");
                    break;
                case 1:                             
                    StartPoint += RanDice;           
                    if (StartPoint > 100)           
                    {

                        StartPoint -= StartPoint;     
                    }
                    Console.WriteLine("Exact Position :" + StartPoint);
                    break;
                case 2:                                  
                    StartPoint -= RanDice;              
                    if (StartPoint < 0)                 
                    {
                        StartPoint = 0;
                    }
                    Console.WriteLine("Snake Attack:" + StartPoint);
                    Console.WriteLine(StartPoint); 
                    break;
                default:
                    Console.WriteLine("Invalid Option");  
                    break;
            }
        }
           
        }
    }

