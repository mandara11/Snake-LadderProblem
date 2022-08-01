using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class CheckOption
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;
        int count;

        public int SnakeorLadder()
        {
            Console.WriteLine("The starting position is -> "+position);

            Random random = new Random();
            int DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Number is -> : " + DiePosition);
            return DiePosition;
        }
        public void Game()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        this.position += 0;
                        break;
                    case SNAKE:
                        this.position -= this.SnakeorLadder();
                        if (this.position < 0)
                        {
                            this.position = 0;
                        }
                        break;
                    case LADDER:
                        int roll = this.SnakeorLadder();
                        this.position += roll;
                        if (this.position > 100)
                        {
                            this.position -= roll;
                        }
                        break;
                }
                Console.WriteLine("The position after every die roll is : " + this.position);
                count++;
            }
            Console.WriteLine("The number of times the dice played : " + count++);

        }
    }
}
