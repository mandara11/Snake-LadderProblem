namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem");
            CheckOption checkOption = new CheckOption();
            //SnakeLadderGame.SinglePlayer(); //UC1
            //Player.CheckDieRoll(); //UC2

            checkOption.Game();   //UC3 //UC4
            checkOption.SnakeorLadder();
        }
    }
}