using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
2048 GAME
Supawish Kanokpongsakorn 6230525521 CUIE103
APP DEV FOR IE 2020
 */

namespace _2048game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader srhigh = new StreamReader("save\\highscore.txt");
            highsc = Convert.ToInt32(srhigh.ReadLine());
            srhigh.Close();
        }

        Random rd = new Random();
        int score = 0;
        int highsc;
        int row = 4;
        int[,] board = new int[10, 10];
        int dragx = 0, dragy = 0;
        string direction = "";
        int newsqx = 0, newsqy = 0;
        bool isGameOver = false;
        Pen border_pen = new Pen(Color.FromArgb(127, 140, 141), 4.0f);


        Bitmap t2 = new Bitmap("assets\\" + "tile2.png");
        Bitmap t4 = new Bitmap("assets\\" + "tile4.png");
        Bitmap t8 = new Bitmap("assets\\" + "tile8.png");
        Bitmap t16 = new Bitmap("assets\\" + "tile16.png");
        Bitmap t32 = new Bitmap("assets\\" + "tile32.png");
        Bitmap t64 = new Bitmap("assets\\" + "tile64.png");
        Bitmap t128 = new Bitmap("assets\\" + "tile128.png");
        Bitmap t256 = new Bitmap("assets\\" + "tile256.png");
        Bitmap t512 = new Bitmap("assets\\" + "tile512.png");
        Bitmap t1024 = new Bitmap("assets\\" + "tile1024.png");
        Bitmap t2048 = new Bitmap("assets\\" + "tile2048.png");
        Bitmap t4096 = new Bitmap("assets\\" + "tile4096.png");
        Bitmap t8192 = new Bitmap("assets\\" + "tile8192.png");

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            genTile();
            checkscore();
            Graphics g = e.Graphics;
            int width = pictureBox1.Width / row;
            int height = pictureBox1.Height / row;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < row; j++)
                {
                    switch (board[i, j])
                    {
                        case 2: g.DrawImage(t2, width * i, height * j, width, height); break;
                        case 4: g.DrawImage(t4, width * i, height * j, width, height); break;
                        case 8: g.DrawImage(t8, width * i, height * j, width, height); break;
                        case 16: g.DrawImage(t16, width * i, height * j, width, height); break;
                        case 32: g.DrawImage(t32, width * i, height * j, width, height); break;
                        case 64: g.DrawImage(t64, width * i, height * j, width, height); break;
                        case 128: g.DrawImage(t128, width * i, height * j, width, height); break;
                        case 256: g.DrawImage(t256, width * i, height * j, width, height); break;
                        case 512: g.DrawImage(t512, width * i, height * j, width, height); break;
                        case 1024: g.DrawImage(t1024, width * i, height * j, width, height); break;
                        case 2048: g.DrawImage(t2048, width * i, height * j, width, height); break;
                        case 4096: g.DrawImage(t4096, width * i, height * j, width, height); break;
                        case 8192: g.DrawImage(t8192, width * i, height * j, width, height); break;
                        default: g.FillRectangle(Brushes.LightGray, width * i, height * j, width, height); break;
                    }
                }
            for (int k = 0; k < row; k++)
            {
                g.DrawLine(border_pen, 0, height * k, pictureBox1.Width, height * k);
                g.DrawLine(border_pen, width * k, 0, width * k, pictureBox1.Height);
            }
            g.DrawRectangle(Pens.Yellow, newsqx * width, newsqy * height, width, height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragx = e.X;
            dragy = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragx > e.X && Math.Abs(dragx - e.X) > Math.Abs(dragy - e.Y))
            {
                direction = "left";
            }
            else if (dragx < e.X && Math.Abs(dragx - e.X) > Math.Abs(dragy - e.Y))
            {
                direction = "right";
            }
            else if (dragy > e.Y && Math.Abs(dragy - e.Y) > Math.Abs(dragx - e.X))
            {
                direction = "up";
            }
            else if (dragy < e.Y && Math.Abs(dragy - e.Y) > Math.Abs(dragx - e.X))
            {
                direction = "down";
            }
            else
            {
                direction = null;
            }
            swipe(direction);
            Refresh();
        }

        private void retrylabel_Click(object sender, EventArgs e)
        {
            isGameOver = false;
            score = 0;
            board = new int[4, 4];
            dragx = 0;
            dragy = 0;
            direction = "";
            newsqx = 0;
            newsqy = 0;
            retrylabel.Visible = false;
            gameoverlabel.Visible = false;
            Refresh();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            StreamWriter sw = new StreamWriter("save\\savegame.txt");
            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    sw.Write(board[i, j].ToString() + ',');
                }
                sw.WriteLine("");
            }
            sw.Close();
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;
            StreamReader sr = new StreamReader("save\\savegame.txt");
            string line = "";
            string[] tile;
            int j = 0;
            board = new int[10, 10];
            while ((line = sr.ReadLine()) != null)
            {
                tile = line.Split(',');
                for (int i = 0; i < tile.Length - 1; i++)
                {
                    board[i, j] = Convert.ToInt32(tile[i]);
                }
                j++;
            }
            sr.Close();
            Refresh();
        }

        void checkscore()
        {
            if (score > highsc)
            {
                highsc = score;
            }
            scorelabel.Text = score.ToString();
            hscorelabel.Text = highsc.ToString();
        }

        private void leftswipe(int row)
        {
            for (int t = 0; t < row; t++)
            {
                for (int j = 0; j < row; j++)
                    for (int i = row - 2; i >= 0; i--)
                    {
                        for (int i_ = i; i_ >= 0; i_--)
                        {
                            if (board[i_, j] == 0)
                            {
                                board[i_, j] = board[i_ + 1, j];
                                board[i_ + 1, j] = 0;
                            }
                        }
                    }
                for (int j = 0; j < row; j++)
                    for (int i = 0; i < row - 1; i++)
                    {
                        if (board[i, j] == board[i + 1, j])
                        {
                            board[i, j] += board[i + 1, j];
                            board[i + 1, j] = 0;
                            score += board[i, j];
                        }
                    }
            }
        }

        private void rightswipe(int row)
        {
            for (int t = 0; t < row; t++)
            {
                for (int j = 0; j < row; j++)
                    for (int i = 1; i < row; i++)
                    {
                        for (int i_ = i; i_ < row; i_++)
                        {
                            if (board[i_, j] == 0)
                            {
                                board[i_, j] = board[i_ - 1, j];
                                board[i_ - 1, j] = 0;
                            }
                        }
                    }
                for (int j = 0; j < row; j++)
                    for (int i = row - 1; i > 0; i--)
                    {
                        if (board[i, j] == board[i - 1, j])
                        {
                            board[i, j] += board[i - 1, j];
                            board[i - 1, j] = 0;
                            score += board[i, j];
                        }
                    }
            }
        }

        private void upswipe(int row)
        {
            for (int t = 0; t < row; t++)
            {
                for (int i = 0; i < row; i++)
                    for (int j = row - 2; j >= 0; j--)
                    {
                        for (int j_ = j; j_ >= 0; j_--)
                        {
                            if (board[i, j_] == 0)
                            {
                                board[i, j_] = board[i, j_ + 1];
                                board[i, j_ + 1] = 0;
                            }
                        }
                    }
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < row - 1; j++)
                    {
                        if (board[i, j] == board[i, j + 1])
                        {
                            board[i, j] += board[i, j + 1];
                            board[i, j + 1] = 0;
                            score += board[i, j];
                        }
                    }
            }
        }

        private void downswipe(int row)
        {
            for (int t = 0; t < row; t++)
            {
                for (int i = 0; i < row; i++)
                    for (int j = 1; j < row; j++)
                    {
                        for (int j_ = j; j_ < row; j_++)
                        {
                            if (board[i, j_] == 0)
                            {
                                board[i, j_] = board[i, j_ - 1];
                                board[i, j_ - 1] = 0;
                            }
                        }
                    }
                for (int i = 0; i < row; i++)
                    for (int j = row - 1; j > 0; j--)
                    {
                        if (board[i, j] == board[i, j - 1])
                        {
                            board[i, j] += board[i, j - 1];
                            board[i, j - 1] = 0;
                            score += board[i, j];
                        }
                    }
            }
        }

        private void swipe(string d)
        {
            if (d == null || isGameOver) return;
            switch (d)
            {
                case "left":
                    leftswipe(row);
                    break;
                case "right":
                    rightswipe(row);
                    break;
                case "up":
                    upswipe(row);
                    break;
                case "down":
                    downswipe(row);
                    break;
                default:
                    break;
            }
        }

        private void genTile()
        {

            if (direction == null) return;
            bool isFull = true;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] == 0) isFull = false;
                }
            if (isFull)
            {
                gameOver();
                return;
            }

            bool isPlaced = false;
            do
            {
                int sqx = rd.Next(row);
                int sqy = rd.Next(row);
                if (board[sqx, sqy] == 0)
                {
                    board[sqx, sqy] = 2;
                    isPlaced = true;
                    newsqx = sqx;
                    newsqy = sqy;
                }
            } while (!isPlaced);
        }

        private void gameOver()
        {
            isGameOver = true;
            retrylabel.Visible = true;
            gameoverlabel.Visible = true;
            StreamWriter swhigh = new StreamWriter("save\\highscore.txt");
            swhigh.WriteLine(highsc);
            swhigh.Close();
        }
    }
}