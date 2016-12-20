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
    class Skip
    {
        private int Mana;

        public Skip()
        {
            Mana = 60;
        }

        public int mana
        {
            get { return Mana; }
            set { Mana = value; }
        }

        public bool available(int mana)
        {
            if (mana >= Mana)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //power functionality
        //just a call to the getNextQuestion method in the FormGame
    }
}
