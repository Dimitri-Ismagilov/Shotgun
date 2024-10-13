using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class GameMode
    {
        public Computer Computer { get; set; }
        public User User { get; set; }
        private Random random;
        public GameMode()
        {
            public void GamePlay(string userMove)
            {
                string computerMove = ComputerMove();
                if (playerMove)
                {
                    User.Charge()
                }
            }

            Computer computer = new Computer();
            User user = new User();
            random = new Random();

            private void ComputerMove()
            {
                int action = random.Next(0,3);
                return action;
                {
                    0 = "Ladda";
                    1 = 

                }
            }







            private List<Move> playerMove = new List<Move>();
            Computer computerMove = new Computer();
            string computerUnswer = computerMove.GetRandomMove();

            public void GamePlay()
            {

                
            }
        }
    }
}
