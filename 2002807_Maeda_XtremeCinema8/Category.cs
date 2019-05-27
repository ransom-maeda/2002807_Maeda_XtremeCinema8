using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_XtremeCinema8
{
    public class Category
    {
        public string category { get; set; }
        public string aisle { get; set; }

        public Category(string c, string a)
        {
            category = c;
            aisle = a;
        }
    }
}
