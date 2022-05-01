using System;

namespace Tic_Tac_toe
{
    public class Progran
    {

        public static int Input1()
        {   
            Console.WriteLine("Pick a number for an x: ");
            string Input = Console.ReadLine();

            int x = Int32.Parse(Input);
            
            return x;
        } 


        public static int Input2()
        {   
            Console.WriteLine("Pick a number for an o: ");
            string Input = Console.ReadLine();

            int x = Int32.Parse(Input);
            
            return x;
        } 
        
        public static int win(string[] game_board)
        {   
            if(game_board[0].Equals(game_board[1])  && game_board[0].Equals(game_board[2]))
            {
                return 1;
            }

            else if(game_board[3].Equals(game_board[4])  && game_board[3].Equals(game_board[5]))
            {
                return 1;
            }

            else if(game_board[6].Equals(game_board[7])  && game_board[6].Equals(game_board[8]))
            {
                return 1;
            }

             else if(game_board[0].Equals(game_board[3])  && game_board[0].Equals(game_board[6]))
            {
                return 1;
            }

             else if(game_board[1].Equals(game_board[4])  && game_board[1].Equals(game_board[7]))
            {
                return 1;
            }

            else if(game_board[2].Equals(game_board[5])  && game_board[2].Equals(game_board[8]))
            {
                return 1;
            }

            else if(game_board[0].Equals(game_board[4])  && game_board[0].Equals(game_board[8]))
            {
                return 1;
            }

            else if(game_board[2].Equals(game_board[4])  && game_board[2].Equals(game_board[6]))
            {
                return 1;
            }

            else
            {
                return 0;
            }
            
        }
        public static void Board(string [] game_board)
        {   
            
            Console.WriteLine($" {game_board[0]} | {game_board[1]} | {game_board[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {game_board[3]} | {game_board[4]} | {game_board[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {game_board[6]} | {game_board[7]} | {game_board[8]}");
            Console.WriteLine("");
            
        }

        public static void Main(string[] args)
        {   
            string[] game_board = {"1","2","3","4","5","6","7","8","9"};
            int win_lose = 0;
            do
               {
                win_lose = win(game_board);

                Board(game_board);
                int input1 = Input1();
                game_board[input1 - 1] = "x";
                Board(game_board);
                
                win_lose = win(game_board);

                if(win_lose == 1)
                {
                    Console.WriteLine("X WINs!!");
                    break;
                }
                
                int input2 = Input2();
                game_board[input2 - 1] = "o";
                win_lose = win(game_board);

                

                else if(win_lose == 0 && game_board[0] != "1" 
                                    && game_board[1] != "2" 
                                    && game_board[2] != "3" 
                                    && game_board[3] != "4" 
                                    && game_board[4] != "5" 
                                    && game_board[5] != "6" 
                                    && game_board[6] != "7" 
                                    && game_board[7] != "8" 
                                    && game_board[8] != "9" )
                {
                    Console.WriteLine("Tie");
                    break;  
                }

                if(win_lose == 1)
                {
                    Console.WriteLine("O WINS!!");
                    break;
                }

            }
            while(win_lose == 0);
        }
    }
    

}
