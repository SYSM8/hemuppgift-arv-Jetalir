using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            bool turn = true;
            string name;

            do
            {
                Console.WriteLine("Please enter a name");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
            Console.WriteLine($"Welcome {name}");

            HumanPlayer player = new HumanPlayer(name); // Spelarens profil
            ComputerPlayer computer = new ComputerPlayer("AI"); // Datorns profil
            Board board = new Board();

            bool retry = true;
            Console.WriteLine("How many sticks do you wanna play with? choose between 20-100");
            int.TryParse(Console.ReadLine(), out int Pins);
            while (retry) // Kontrollerar att Antalet pinnar är mellan 20-100
            {
                
                if (Pins <= 100 && Pins >= 20)
                {
                    board.Setup(Pins);
                    retry = false;
                }
                else
                {
                    Console.WriteLine("please try again");
                    int.TryParse(Console.ReadLine(), out Pins);
                }
            }
            
            while (board.GetNoPins() > 0) // Spelet har börjat
            {
                if (turn && board.GetNoPins() > 0) // Spelarens tur
                {
                    Console.Write($"It's your turn, ");
                    int take;
                    do
                    {
                        Console.WriteLine($"Take 1-2 Sticks. {board.GetNoPins()} Left");
                        int.TryParse(Console.ReadLine(), out take);
                    } while (take < 1 || take > 2);

                    player.TakePins(board, take);

                    Console.WriteLine($"you took {take}, {board.GetNoPins()} Left.");
                    turn = false;
                }
                else if (!turn) // Datorns tur att välja
                {
                    easy();
                }
            }

            if (!turn) // vinns medelande
            {
                Console.WriteLine($"Congratz {name}, You Win!");
            }
            else if (turn)
            {
                Console.WriteLine("You Lose!");
            }

            void easy() // Enkel motståndare
            {
                Random rand = new Random();
                
                computer.TakePins(board, rand.Next(1,2));
                Console.WriteLine($"Your Opponent took 1, {board.GetNoPins()} Left.");
                turn = true;
            }
            
        }

        
    }
}
