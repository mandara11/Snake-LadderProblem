namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            SnakeLadderGame.SinglePlayer(); //UC1
            Player.CheckDieRoll(); //UC2
        }
    }
}