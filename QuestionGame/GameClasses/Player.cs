using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{
    class Player
    {
        public int score;
        public string name;

        public Player(int score, string name)
        {
            this.score = score;
            this.name = name;
        }
    }
}
