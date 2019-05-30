using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048.Properties;
using System.Resources;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;

namespace _2048
{
    public partial class Classic : Form
    {
        private Bitmap board = new Bitmap(Resources.grid);
        Random rnd = new Random();
        int[,] arr = new int[6, 6];

        public void Wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public void DrawBoard()
        {
            var UpdatedBoard = new Bitmap(board.Width, board.Height, PixelFormat.Format32bppArgb);
            object tile;

            var graphics = Graphics.FromImage(UpdatedBoard);
            graphics.CompositingMode = CompositingMode.SourceOver;

            graphics.DrawImage(board, 0, 0);

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (arr[j, i] == 0) continue;

                    string tempstr = string.Format("_{0}", arr[j, i].ToString());

                    tile = Resources.ResourceManager.GetObject(tempstr.ToString());

                    graphics.DrawImage((Image)tile, 8 * j + (j - 1) * 65, 8 * i + (i - 1) * 65);
                }
            }

            // UpdatedBoard = new Bitmap(300, 300, graphics);
            imgboard.Image = UpdatedBoard;
        }

        public void PopRandom()
        {
            int empty = 0;
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (arr[j, i] == 0) empty++;
                }
            }

            int tileval = rnd.Next(1, 11);
            if (tileval == 10) tileval = 4;
            else tileval = 2;

            int ind = rnd.Next(1, empty + 1);
            int tmp = 0;

            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    if (arr[k, j] == 0) tmp++;
                    if (tmp == ind)
                    {
                        arr[k, j] = tileval;
                        break;
                    }
                }
                if (tmp == ind) break;
            }
        }

        public void Rotate90(int times)
        {
            for(int t = 1; t <= times; t++)
            {
                int[,] tmp = new int[6, 6];
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) tmp[5 - i, j] = arr[j, i];
                }
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) arr[j, i] = tmp[j, i];
                }
            }
        }

        bool[,] SquashedArr = new bool[6, 6];
        int[,] LastStep = new int[6, 6];
        int[,] LastStep2 = new int[6, 6];
        int score = 0, turnscore = 0, lastturnscore = 0;
        int move = 0;
        bool WinTrigger = false;
        public void SquashTiles(int x, int y)
        {
            if (x == 1) return;
            if (arr[x - 1, y] == 0)
            {
                arr[x - 1, y] = arr[x, y];
                arr[x, y] = 0;
                SquashTiles(x - 1, y);
                return;
            }

            if (arr[x - 1, y] == arr[x, y] && !SquashedArr[x - 1, y])
            {
                arr[x - 1, y] *= 2;
                SquashedArr[x - 1, y] = true;
                turnscore += arr[x, y] * 2;
                arr[x, y] = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //save backup
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++) LastStep[j, i] = arr[j, i];
            }

            //capture up arrow key
            if (keyData == Keys.Down)
            {
                Rotate90(1);
                for(int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) SquashTiles(i, j);
                }
                Rotate90(3);
            }

            //capture down arrow key
            if (keyData == Keys.Up)
            {
                Rotate90(3);
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) SquashTiles(i, j);
                }
                Rotate90(1);
            }

            //capture left arrow key
            if (keyData == Keys.Left)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) SquashTiles(i, j);
                }
            }

            //capture right arrow key
            if (keyData == Keys.Right)
            {
                Rotate90(2);
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) SquashTiles(i, j);
                }
                Rotate90(2);
            }

            //check same
            bool same = true;
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (LastStep[j, i] != arr[j, i])
                    {
                        same = false;
                        break;
                    }
                }
                if (!same) break;
            }

            if (same)
            {
                for(int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) LastStep[j, i] = LastStep2[j, i];
                }
                return true;
            }

            //update LastStep2
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++) LastStep2[j, i] = LastStep[j, i];
            }

            //update board
            DrawBoard();

            Wait(100);
            PopRandom();
            DrawBoard();

            //update move count
            move++;
            lblMoves.Text = move.ToString();

            //update score
            score += turnscore;
            lblScore.Text = score.ToString();
            lastturnscore = turnscore;
            turnscore = 0;

            //Victory?
            if (!WinTrigger)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        if (arr[j, i] >= 2048)
                        {
                            WinTrigger = true;
                            break;
                        }
                    }
                    if (WinTrigger) break;
                }

                if (WinTrigger)
                {
                    DialogResult WinResult = MessageBox.Show("You just reached the 2048 Tile! Do you wish to continue playing?", "You Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (WinResult == DialogResult.No)
                    {
                        TitleScr ts;
                        this.Close();
                        ts = new TitleScr();
                        ts.Show();
                        return true;
                    }
                }
            }

            //Lose?
            bool LoseConfirmed = true;
            int[,] LoseCheck = new int[6, 6];
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++) LoseCheck[j, i] = arr[j, i];
            }

            for(int z = 0; z < 4; z++)
            {
                Rotate90(z);
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++) SquashTiles(i, j);
                }
                Rotate90(4 - z);

                for (int m = 1; m <= 4; m++)
                {
                    for (int n = 1; n <= 4; n++)
                    {
                        if (LoseCheck[n, m] != arr[n, m])
                        {
                            LoseConfirmed = false;
                            break;
                        }
                    }
                    if (!LoseConfirmed) break;
                }
                if (!LoseConfirmed) break;
            }

            if (LoseConfirmed)
            {
                DialogResult LoseResult = MessageBox.Show("Your grid is filled with no more legal moves.", "Game Over!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                if (LoseResult == DialogResult.Retry)
                {
                    Classic reset = new Classic();
                    reset.Show();
                    this.Dispose(false);
                    return true; 
                }
                else
                {
                    TitleScr ts;
                    this.Close();
                    ts = new TitleScr();
                    ts.Show();
                    return true;
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++) arr[j, i] = LoseCheck[j, i];
            }

            // Reset squashed array
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++) SquashedArr[j, i] = false;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public Classic()
        {
            InitializeComponent();

            // memset 0
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++) arr[i, j] = 0;
            }

            // gen inital tiles
            PopRandom();
            PopRandom();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    LastStep[j, i] = arr[j, i];
                    LastStep2[j, i] = arr[j, i];
                }
            }

            DrawBoard();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            TitleScr ts;
            this.Close();
            ts = new TitleScr();
            ts.Show();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            Classic reset = new Classic();
            reset.Show();
            this.Dispose(false);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bool same = true;
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (arr[j, i] != LastStep[j, i]) same = false;
                    arr[j, i] = LastStep[j, i]; 
                }
            }

            if (!same)
            {
                DrawBoard();
                move--;
                score -= lastturnscore;
                lblMoves.Text = move.ToString();
                lblScore.Text = score.ToString();
            }
        }
    }
    
}
