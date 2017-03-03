using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Author: Stamatis Stiliatis Togrou
 */

namespace QuestionGame
{
    class CategoriesID
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string description { get; set; }
        //--------------------------------------++

        //constructors
        public CategoriesID() { return; }
        public CategoriesID(int id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
