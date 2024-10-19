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
        int playerXWins = 0;
        int playerOWins = 0;

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (TextBox)sender;

            // Определяем номер ячейки, соответствующей нажатому TextBox
            int cellIndex = int.Parse(clickedTextBox.Name.Substring(7)) - 1;

            // Если ячейка пуста, то ставим значение игрока
            if (gameBoard[cellIndex] == 0)
            {
                gameBoard[cellIndex] = player ? 1 : 2; // 1 - X, 2 - O
                clickedTextBox.Text = player ? "X" : "O";
                player = !player; // Переключаем хода
                WinnerCheck();
            }


        }
        private void WinnerCheck()
        {
            // Проверка строк
            for (int i = 0; i < 9; i += 3)
            {
                if (gameBoard[i] > 0 && gameBoard[i] == gameBoard[i + 1] && gameBoard[i] == gameBoard[i + 2])
                {
                    if (gameBoard[i] == 1)
                        playerXWins++;
                    else
                        playerOWins++;
                    ResetGame();
                    return;
                }
            }

            // Проверка столбцов
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i] > 0 && gameBoard[i] == gameBoard[i + 3] && gameBoard[i] == gameBoard[i + 6])
                {
                    if (gameBoard[i] == 1)
                        playerXWins++;
                    else
                        playerOWins++;
                    ResetGame();
                    return;
                }
            }

            // Проверка диагоналей
            if (gameBoard[0] > 0 && gameBoard[0] == gameBoard[4] && gameBoard[0] == gameBoard[8])
            {
                if (gameBoard[0] == 1)
                    playerXWins++;
                else
                    playerOWins++;
                ResetGame();
                return;
            }
            if (gameBoard[2] > 0 && gameBoard[2] == gameBoard[4] && gameBoard[2] == gameBoard[6])
            {
                if (gameBoard[2] == 1)
                    playerXWins++;
                else
                    playerOWins++;
                ResetGame();
                return;
            }

        }
        private void ResetGame()
        {
            // Сбрасываем состояние игрового поля
            Array.Clear(gameBoard, 0, gameBoard.Length);

            // Очищаем все TextBox
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            // Отображаем счет игроков
            label2.Text = $"X: {playerXWins}";
            label3.Text = $"O: {playerOWins}";
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
