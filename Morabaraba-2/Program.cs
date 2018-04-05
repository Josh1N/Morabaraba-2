using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2
{
    class Program
    {
        /*  
   *  okay so i havent got much done but its something. 
   *  
   *  what we need now:
   *  
   *  1) an object Player which contains:
   *      -> the state the player is in (Placing, Moving, or Flying)
   *      -> a list of 12 cows called Unplaced 
   *          -> everytime a player places a cow, a cow is removed from their Unplaced list 
   *             AND ONE IS ADDED to a seperate list called OnBoard
   *          -> everytime a cow is killed, a cow must be removed from OnBoard
   *      by monitoring the length of these two lists we'll be able to determine the which state each
   *      player is in
   *      -> when Unplaced is empty, the player's state must change from Placing to Moving
   *      -> if their OnBoard is ever less than four, WHEN THEY ARE IN THE MOVING STATE, their state
   *         must change to Flying. 
   *      -> if their OnBoard is less than 3, the other player has won.
   *         
   */

        public string[] Positions = { "A1", "A4", "A7", "B2","B4","B6", "C3","C4","C5","D1","D2","D3", "D5", "D6", "D7","E3","E4","E5","F2","F4","F6","G1","G4","G7" };

        public List<string> UnplacedCows  = new List<string>(); //NEED TO KNOW WHETHER TO MAKE TWO LISTS (ONE) FOR EACH PLAYER SO AS TO KNOW HOW TO KEEP TO TRACK OF WHO HAS WHICH COWS
        public List<string> onBoardCows = new List<string>();

        static void runGame()//player currentPlayer) // an object of type player needs to be created
        {


            /* so first we need to start out by asking Player1 (lets use 1 and 2 instead of B and W) for their
             * first move -> so we're going to need some input validation here. 
             * 
             * if the move is valid, the board must be updated and runGame called again (with the opposite
             * player to the one who just went as currentPlayer) 
             * 
             * the state of currentPlayer must be checked with every move
             */

        }
        static void printInstructions()
        {
            Console.Write("Morabaraba Game Instructions\n\nHOW TO START\n1. 	To start you need the Twelve men's morris game board. \n	The board starts empty, each player holding all his pieces \n	in hand.\n2. 	Each player has 12 game pieces. One player plays white, \n	the other black, but any 2 differing colors can be used.\n\nRULES\n1. 	The gameboard for 12 men's morris.\n2. 	When a player is reduced to 4 pieces, his pieces are free \n	to move to any unoccupied point, instead of being restricted \n	to adjacent points as earlier in the game.\n\nGAMEPLAY\n1. 	At first, each player in turn puts one piece on the board, \n	at any vacant point.\n2. 	Once all pieces are on the board, a player now moves one of \n	his pieces along a marked line to an adjacent empty point.\n3. 	If a piece placed or moved forms a row of three along a marked\n 	line (This is called a mill), he can take one of his opponent's \n	pieces, as long as that piece is not itself part of a mill.\n4. 	If when capturing, all opposing pieces have formed mills, then\n 	any of the pieces may be captured.\n\nHOW TO WIN\n1. 	The goal of the game is to reduce your opponent's pieces to as\n 	little as possible.\n2. 	A player wins the game when his opponent is reduced to 2 pieces \n	and is thus unable to form a mill or make any further captures.\n3. 	If the board is filled in the first phase, and no pieces taken, \n	the second phase will be gridlocked with neither player able to move.\n 	In this case the game is draw.\n\n");
        }



        private List<string> rows = new List<string>() // need to figure out how to circumanvigate escape character 
        {
             "  1  2  3  4  5  6  7  \n",
            string.Format("A {0}--------{1}--------{2}  \n","A1","A4","A7"),
            "  | '      |       |  \n",
            string.Format("B |  {O}-----{1}-----{2}  |  \n","B2","B4","B6"),
            "  |  | '   |   / |  |  \n",
            string.Format("C |  |  {O}--{1}--{2}  |  |  \n","C3","C4","C5"),
            "  |  |  |     |  |  |  \n",
            string.Format("D {0}--{1}--{2}     {3}--{4}--{5}  \n","D1","D2","D3", "D5", "D6", "D7"),
            "  |  |  |     |  |  |  \n",
            string.Format("E |  |  {0}--{1}--{2}  |  |  \n","E3","E4","E5"),
            "  |  | /   |   ' |  |  \n",
            string.Format("F |  {0}-----{1}-----{2}  |  \n","F2","F4","F6"),
            "  | /      |      ' |  \n",
            string.Format("G {0}--------{1}--------{2}  \n\n","G1","G4","G7")
        };


        public static void printGameBoard(List<string> var)
        {
            // prints list of strings for each row of the board
            // strings in the list can be updated via their index whenever the board changes 
            // this is going to be similar to what we tried to do in F# but it'll be alot easier because
            // its just a matter of indexing and updating at that index 
            foreach (string r in var)
            {
                Console.Write(r);
            }


        

        }

        static void Main(string[] args)
        {
            printInstructions();
            Console.WriteLine("Press Enter to begin the game:");
            Console.ReadLine();
            printGameBoard(rows);
           // runGame(player currentPlayer); // an object of type player needs to be created 
            // run game is where everything should happen
            // should take 

        }
    }
}
