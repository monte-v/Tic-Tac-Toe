using System.Numerics;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool player = false;
        int[] gameBoard = new int[9];

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (TextBox)sender;

            // ќпредел€ем номер €чейки, соответствующей нажатому TextBox
            int cellIndex = int.Parse(clickedTextBox.Name.Substring(7)) - 1;

            // ≈сли €чейка пуста, то ставим значение игрока
            if (gameBoard[cellIndex] == 0)
            {
                gameBoard[cellIndex] = player ? 1 : 2; // 1 - X, 2 - O
                clickedTextBox.Text = player ? "X" : "O";
                player = !player; // ѕереключаем хода
            }

            //WinnerCheck();
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
