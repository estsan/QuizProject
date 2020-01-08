using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizProject
{
    class Player
    {
        public string Name { get; set; }
        public enum PlayerColor { Red, Blue, Green, Yellow};
        public int[] Position { get; set; }
    }
}
