using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smizard_of_S_more
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form1.ScreenChanger(this, new Gamescreen());
        }
    }
}
