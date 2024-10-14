using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public class GameMode
    {
        public Player Computer { get; set; }
        public Player User { get; set; }

        public GameMode()
        {
            User = new Player();
            Computer = new Player();
        }
            public void GamePlay(string userMove)
            {
                string computerMove = ComputerMove();
                if (userMove == "Ladda")
                {
                    if (computerMove == "Ladda")
                    {
                        User.Charge();
                        Computer.Charge();
                    }
                    else if (computerMove == "Blocka")
                    {
                        User.Charge();
                    }
                    else if (computerMove == "Skjuta")
                    {
                        Computer.Shoot();
                        //lägga en poäng till Dator
                    }
                }
                else if (userMove == "Blocka")
                {
                    if (computerMove == "Ladda")
                    {
                        Computer.Charge();
                    }
                    else if (computerMove == "Blocka")
                    {
                        //ingenting händer
                    }
                    else if (computerMove == "Skjuta")
                    {
                        Computer.Shoot();
                    }
                }
                else if(userMove == "Skjuta")
                {
                    if (computerMove == "Ladda")
                    {
                        User.Shoot();
                        //lägga en poäng till
                    }
                    else if (computerMove == "Blocka")
                    {
                        User.Shoot();
                    }
                    else if (computerMove == "Skjuta")
                    {
                        User.Shoot();
                        Computer.Shoot();
                    }

                }

            }
            private string ComputerMove()
            {
                List<string> computerMove = new List<string> { "Ladda", "Blocka" };
                //if (Computer.Shotgung())
                //{
                //    computerMove = "Shotgun";

                //}
                //else
                //{
                    if (Computer.CanShoot())
                    {
                        computerMove.Add("Skjuta");
                    }
                //}
                Random random = new Random();
                int index = random.Next(computerMove.Count);
                return computerMove[index];
            }
    }
}
