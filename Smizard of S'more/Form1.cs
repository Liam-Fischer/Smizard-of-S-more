namespace Smizard_of_S_more
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScreenChanger(this, new Menu());
        }

        public static void ScreenChanger(object sender, UserControl next)
        {
            Form f;

            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            //next.Location = new Point((f.ClientSize.Width - next.Width) / 2, (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }
    }
}