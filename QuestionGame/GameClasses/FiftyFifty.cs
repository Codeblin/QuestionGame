using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{
    class FiftyFifty
    {
        private int Mana;

        public FiftyFifty()
        {
            Mana = 40;
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
        public void doFifty(Questions q, Label lbl)
        {
            Random random = new Random();
            int rand;
            rand = random.Next(4);
            while(rand == q.correctAnswer)
            {
                rand = random.Next(4);
            }
            if (rand > 2)
            {
                lbl.Text = "You cast Fifty-Fifty! " + (char)((int)'A' + rand) + " OR " + (char)((int)'A' + q.correctAnswer);
            }else
            {
                lbl.Text = "You cast Fifty-Fifty! " + (char)((int)'A' + q.correctAnswer) + " OR " + (char)((int)'A' + rand);
            }
        }
    }
}
