using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_XtremeCinema8
{
    public partial class Form1 : Form
    {
        List<Category> categories = new List<Category>();

        public Form1()
        {

            InitializeComponent();
            locationOutput.ReadOnly = true;

            //creates categories
            Category comedy = new Category("Comedy", "Aisle 1");
            Category drama = new Category("Drama", "Aisle 2");
            Category action = new Category("Action", "Aisle 3");
            Category scifi = new Category("Sci-Fi", "Aisle 4");
            Category horror = new Category("Horror", "Aisle 5");
            Category newReleases = new Category("New Releases", "Back Wall");

            //adds categories to list
            categories.Add(comedy);
            categories.Add(drama);
            categories.Add(action);
            categories.Add(scifi);
            categories.Add(horror);
            categories.Add(newReleases);
        }



        private void search_Click(object sender, EventArgs e)
        {
            //loop over categories list
            for (int i = 0; i < categories.Count; i++)
            {
                //check if category matches selected item
                Category check = categories.ElementAt(i);
                if(categoryList.SelectedItem == check.category)
                {
                    //outputs text
                    locationOutput.Text = check.aisle;
                    break;
                }

            }
        }
    }
}
