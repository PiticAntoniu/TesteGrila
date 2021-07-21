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
            Test test = new Test(Ct.DefaultTest);
            test.Shuffle();
            test.Save(Ct.DefaultGeneratedTest);

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WordApp.GetTemplate().Close(false);
            WordApp.GetWordApp().Quit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
