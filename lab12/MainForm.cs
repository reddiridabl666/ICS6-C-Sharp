using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab12
{
    public partial class MainForm : Form
    {

        enum Tile
        {
            Blank,
            Cross,
            Circle
        }

        Tile turn;
        Tile[,] gameState;

        Dictionary<Tile, byte[]> imgs = new Dictionary<Tile, byte[]> {
            {Tile.Cross, Properties.Resources.cross},
            {Tile.Circle, Properties.Resources.circle},
        };
        
        Dictionary<Tile, string> turnText = new Dictionary<Tile, string> {
            {Tile.Cross, "крестиков"},
            {Tile.Circle, "ноликов"},
        };

        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 3; ++i)
            {
                board.Rows.Add();
                board.Rows[i].Height = 100;
            }
            RestartGame();
        }

        private void RestartGame()
        {
            turn = Tile.Cross;
            gameState = new Tile[3, 3];
            resetBtn.Hide();

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    ((DataGridViewImageCell)board.Rows[i].Cells[j]).Value = Properties.Resources.blank;
                }
            }

            label1.Text = string.Format("Ход {0}", turnText[turn]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void board_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gameState[e.RowIndex, e.ColumnIndex] == Tile.Blank && !resetBtn.Visible)
            {
                gameState[e.RowIndex, e.ColumnIndex] = turn;
                board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = imgs[turn];

                if (turn == Tile.Cross)
                {
                    turn = Tile.Circle;
                } else
                {
                    turn = Tile.Cross;
                }

                label1.Text = string.Format("Ход {0}", turnText[turn]);

                CheckGameOver();
            }
        }

        private void CheckGameOver()
        {
            var result = IsGameOverRow();
            if (result != Tile.Blank)
            {
                GameOver(result);
                return;
            }
            
            result = IsGameOverColumn();
            if (result != Tile.Blank)
            {
                GameOver(result);
                return;
            }

            result = IsGameOverDiag();
            if (result != Tile.Blank)
            {
                GameOver(result);
                return;
            }

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (gameState[i, j] == Tile.Blank)
                    {
                        return;
                    }
                }
            }

            GameOver(Tile.Blank);
        }

        private Tile IsGameOverRow()
        {
            uint crossRow = 0;
            uint circleRow = 0;

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (gameState[i, j] == Tile.Cross)
                    {
                        ++crossRow;
                    }

                    if (gameState[i, j] == Tile.Circle)
                    {
                        ++circleRow;
                    }
                }

                if (crossRow == 3)
                {
                    return Tile.Cross;

                }

                if (circleRow == 3)
                {
                    return Tile.Circle;
                }

                crossRow = 0;
                circleRow = 0;
            }

            return Tile.Blank;
        }
        
        private Tile IsGameOverColumn()
        {
            uint crossColumn = 0;
            uint circleColumn = 0;

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (gameState[j, i] == Tile.Cross)
                    {
                        ++crossColumn;
                    }

                    if (gameState[j, i] == Tile.Circle)
                    {
                        ++circleColumn;
                    }
                }

                if (crossColumn == 3)
                {
                    return Tile.Cross;
                }

                if (circleColumn == 3)
                {
                    return Tile.Circle;
                }

                crossColumn = 0;
                circleColumn = 0;
            }

            return Tile.Blank;
        }

        private Tile IsGameOverDiag()
        {
            if (gameState[0, 0] == gameState[1, 1] && gameState[1, 1] == gameState[2, 2])
            {
                return gameState[0, 0];
            }
            
            if (gameState[0, 2] == gameState[1, 1] && gameState[1, 1] == gameState[2, 0])
            {
                return gameState[0, 2];
            }

            return Tile.Blank;
        }

        private void GameOver(Tile winner)
        {
            switch (winner)
            {
                case Tile.Cross:
                    label1.Text = "Победили крестики";
                    break;
                case Tile.Circle:
                    label1.Text = "Победили нолики";
                    break;
                default:
                    label1.Text = "Ничья";
                    break;
            }

            resetBtn.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
 