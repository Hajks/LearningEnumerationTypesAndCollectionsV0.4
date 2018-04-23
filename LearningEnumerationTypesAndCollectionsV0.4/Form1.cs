using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV0._4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            List<Egg> myCarton = new List<Egg> ();
            Egg x = new Egg();
            Egg y = new Egg();
            Chicken z = new Chicken(); // Chicken inherits from egg, that's why we can add to list our chicken.

            myCarton.Add(x); // That's how we add our object
            myCarton.Add(z);
            myCarton.Add(y);

            int theSize = myCarton.Count; //We can check how big our list is.

            bool isIn = myCarton.Contains(x); //We can check if our object is in list.

            int idx = myCarton.IndexOf(y); //We can check what index our object have.

            myCarton.Remove(y); ; //We can remove our object from list.

        }
    }
}
