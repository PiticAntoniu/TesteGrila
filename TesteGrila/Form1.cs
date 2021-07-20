using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteGrila
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //Test test = new Test(Ct.DefaultTest);
            //test.Shuffle();
            //test.Save(Ct.DefaultGeneratedTest);

            List<int> a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random r = new Random();
            foreach (int i in a.OrderBy(x => r.Next()))
            {
                Console.WriteLine(i);
            }
        }
    }
}
