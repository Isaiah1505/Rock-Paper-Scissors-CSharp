using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Versioning;

class Start 
{

    static void Main()
    {
        Console.WriteLine("Type 'Rock', 'Paper' or 'Scissors' to start playing against the computer");
        var random = new Random();  //random becomes a variable to store RPS 
        string answer = Console.ReadLine(); //string answer is the user's answer
        if(answer == "Rock" || answer == "rock"){   //player's answer is rock

            int RPS = random.Next(1,4); //randomly picks rock paper or scissors = (1,2,3) for the computer
            Console.WriteLine("Player Chose: "+answer);

            if(RPS == 1){       //computer picked rock and player picked rock
                Console.WriteLine("Computer picked: Rock");
                Console.WriteLine("It's a Tie");
            }    

            if(RPS == 2){       //computer picked paper, player picked rock
                Console.WriteLine("Computer picked: Paper");
                Console.WriteLine("Computer Wins");
            }
            
            if(RPS == 3){       //computer picked scissors, player picked rock
                Console.WriteLine("Computer picked: Scissors");
                Console.WriteLine("Player Wins");
            }
                    
            Console.WriteLine("Try again? Type Yes, anything else will end the game.");
            string followUpAns = Console.ReadLine();

                while(followUpAns == " "){  //asks player if they want to play again or end the session

                }
                if(followUpAns == "Yes" || followUpAns == "yes" ){  //if if yes is inputted, the main is rerun

                    Console.WriteLine("Restarting");
                    Main();

                }   else{           //if no, game ends
                        Console.WriteLine("Okay, Game has ended");
                    }

        }    else if(answer == "Paper" || answer == "paper"){       //player answered paper

                    int RPS = random.Next(1,4);
                    Console.WriteLine("Player Chose: "+answer);
                    if(RPS == 1){               //computer picked rock, player picked paper
                        Console.WriteLine("Computer picked: Rock");
                        Console.WriteLine("Player Wins");
                    }    

                    if(RPS == 2){               //computer picked paper, player picked paper
                        Console.WriteLine("Computer picked: Paper");
                        Console.WriteLine("It's a tie");
                    }
            
                    if(RPS == 3){               //computer picked scissors, player picked paper
                        Console.WriteLine("Computer picked: Scissors");
                        Console.WriteLine("Computer Wins");
                    }
                    Console.WriteLine("Try again? Type Yes, anything else will end the game.");
                    string followUpAns = Console.ReadLine();

                    while(followUpAns == " "){

                    }
                    if(followUpAns == "Yes" || followUpAns == "yes" ){

                        Console.WriteLine("Restarting...");
                        Main();

                    }else{
                        Console.WriteLine("Okay, Thanks for playing. Game has ended");
                    }
                    


             }  else if(answer == "Scissors" || answer == "scissors"){

                        int RPS = random.Next(1,4);
                        Console.WriteLine("Player Chose: "+answer);
                        if(RPS == 1){           //computer picked rock, player picked scissors
                            Console.WriteLine("Computer picked: Rock");
                            Console.WriteLine("Computer Wins");
                        }    

                        if(RPS == 2){           //computer picked paper, player picked scissors
                            Console.WriteLine("Computer picked: Paper");
                            Console.WriteLine("Player Wins");
                        }
            
                        if(RPS == 3){       //computer picked scissors, player picked scissors
                            Console.WriteLine("Computer picked: Scissors");
                            Console.WriteLine("It's a Tie");
                        }
                        Console.WriteLine("Try again? Type Yes, anything else will end the game.");
                        string followUpAns = Console.ReadLine();

                    while(followUpAns == " "){  //asks player if they want to continue or end the session

                    }
                    if(followUpAns == "Yes" || followUpAns == "yes" ){  //if yes, runs the main, where the game code is

                        Console.WriteLine("Restarting");
                        Main();

                    }else{      //if no, game ends and thank you message appears
                        Console.WriteLine("Okay, Thanks for playing. Game has ended");
                    }

                }   else{// misinput handling, if incorrect phase is typed in

                        Console.WriteLine("Incorrect Input. Doesn't work, Try to");
                        Main();
                    }

    }
}