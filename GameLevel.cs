using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Tic_Tac_Toe_Game
{
    public class GameLevel
    {
        public enum enGameLevel { Easy = 0, Medium = 1, Hard = 2 };
        public enGameLevel _GameLevel = enGameLevel.Medium;
    }
}
