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
    class Clarity
    {
        private int Mana;

        public Clarity()
        {
            Mana = 80;
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
            }else
            {
                return false;
            }
        }

        //Power functionality
        public void doClarity(Questions q, Label lbl)
        {
            lbl.Text = "You cast Clarity! The right answer is: " + (char)((int)'A' + q.correctAnswer)
                        + ". ";
        }
    }
}
