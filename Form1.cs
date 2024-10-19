namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Click(object sender, EventArgs e)
        {

        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Black;
            panel2.BackColor = Color.Lavender;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.White;
            panel2.BackColor = Color.SlateBlue;
        }
    }
}
