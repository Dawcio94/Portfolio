using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001
{
    public partial class Form1 : Form
    {
        int score = 0;
        List<int> scores = new List<int>() { 0, 0, 0, 0 };
        List<Player> players = new List<Player>();
        DialogResult result;
        MessageBoxButtons button = MessageBoxButtons.OK;
        string caption = "Aktywny gracz";
        int aktywny_gracz = 0, counter = 0;
        public Form1()
        {
            InitializeComponent();
            plGame.Visible = false;
            lbplay3.Visible = false;
            lbplay4.Visible = false;
            tbplayer3.Visible = false;
            tbplayer4.Visible = false;
            plstartgame.Visible = true;
            this.ActiveControl = tbplayer1;
        }

        private void btstartgame_Click(object sender, EventArgs e)
        {
            plstartgame.Visible = false;
            plGame.Visible = false;
            string message = "Aktywny 1 gracz";

            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (nupplayers.Value == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        players.Add(new Player(i, tbplayer1.Text));
                        scores[i] = 0;
                    }
                    plplayer4.Visible = false;
                    lnlplayer1.Text = "Gracz 1:\n" + tbplayer1.Text;
                    lnlplayer2.Text = "Gracz 2:\n" + tbplayer2.Text;
                    lnlplayer3.Text = "Gracz 3:\n" + tbplayer3.Text;

                }
                else if (nupplayers.Value == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        players.Add(new Player(i, tbplayer1.Text));
                        scores[i] = 0;
                    }
                    lnlplayer1.Text = "Gracz 1:\n" + tbplayer1.Text;
                    lnlplayer2.Text = "Gracz 2:\n" + tbplayer2.Text;
                    lnlplayer3.Text = "Gracz 3:\n" + tbplayer3.Text;
                    lnlplayer4.Text = "Gracz 4:\n" + tbplayer4.Text;

                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        players.Add(new Player(i, tbplayer1.Text));
                        scores[i] = 0;
                    }
                    lnlplayer1.Text = "Gracz 1:\n"+tbplayer1.Text;
                    lnlplayer2.Text = "Gracz 2:\n"+tbplayer2.Text;
                    plplayer3.Visible = false;
                    plplayer4.Visible = false;
                }
                plGame.Visible = true;
            }
        }

        

        public void koniecTury()
        {
            if (aktywny_gracz + 1 < players.Count())
            {
                aktywny_gracz = aktywny_gracz + 1;
                string message = "Aktywny " + (aktywny_gracz+1) + " gracz";
                result = MessageBox.Show(message, caption, button);
                pbbone1.Visible = false;
                pbbone2.Visible = false;
            }
            else
            {
                aktywny_gracz = 0;
                string message = "Aktywny " + (aktywny_gracz + 1) + " gracz";
                result = MessageBox.Show(message, caption, button);
                pbbone1.Visible = false;
                pbbone2.Visible = false;
            }
        }

        private void nupplayers_ValueChanged(object sender, EventArgs e)
        {
            if (nupplayers.Value == 3)
            {
                lbplay3.Visible = true;
                lbplay4.Visible = false;
                tbplayer3.Visible = true;
                tbplayer4.Visible = false;
            }
            else if (nupplayers.Value == 4)
            {
                lbplay4.Visible = true;
                tbplayer4.Visible = true;
            }
            else
            {
                lbplay3.Visible = false;
                lbplay4.Visible = false;
                tbplayer3.Visible = false;
                tbplayer4.Visible = false;
            }
        }

        private void btchoose_Click(object sender, EventArgs e)
        {
            if (scores[aktywny_gracz] == 2001 || counter == 200)
            {
                int final = (scores.IndexOf(scores.Max())) + 1;
                caption = "Koniec gry";
                string message = "Wygranym został gracz " + final + " z wynikiem " + scores.Max();

                result = MessageBox.Show(message, caption, button);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            Random rnd1 = new Random();
                int dice1 = (rnd1.Next(1, 30)) % 6;
                Random rnd2 = new Random();
                int dice2 = (rnd2.Next(1, 20)) % 6;
                ChangePicture(dice1, dice2);
            pbbone1.Visible = true;
            pbbone2.Visible = true;
           
                        if (aktywny_gracz == 0)
                        {
                            scores[aktywny_gracz] = CountScore(dice1, dice2, scores[aktywny_gracz]);
                            lblscore1.Text = "Wynik:" + scores[aktywny_gracz];

                        }
                        if (aktywny_gracz == 1)
                        {
                            scores[aktywny_gracz] = CountScore(dice1, dice2, scores[aktywny_gracz]);
                            lblscore2.Text = "Wynik:" + scores[aktywny_gracz];

                        }
                         if (aktywny_gracz == 2)
                         {
                            scores[aktywny_gracz] = CountScore(dice1, dice2, scores[aktywny_gracz]);
                            lblscore3.Text = "Wynik:" + scores[aktywny_gracz];

                            }
                            if (aktywny_gracz == 3)
                            {
                                scores[aktywny_gracz] = CountScore(dice1, dice2, scores[aktywny_gracz]);
                                lblscore4.Text = "Wynik:" + scores[aktywny_gracz];

                            }
                         
            koniecTury();
            counter++;
                
        }



        private void btendgame_Click(object sender, EventArgs e)
        {
            int final = (scores.IndexOf(scores.Max()))+1;
            caption = "Koniec gry";
            string message = "Wygranym został gracz "+final+" z wynikiem "+scores.Max();

            result = MessageBox.Show(message, caption, button);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        void ChangePicture(int rand1, int rand2)
        {

            switch (rand1)
            {
                case 1:
                    pbbone1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pbbone1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pbbone1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pbbone1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pbbone1.Image = Properties.Resources._5;
                    break;
                case 0:
                    pbbone1.Image = Properties.Resources._6;
                    break;
            }
            switch (rand2)
            {
                case 1:
                    pbbone2.Image = Properties.Resources._1;
                    break;
                case 2:
                    pbbone2.Image = Properties.Resources._2;
                    break;
                case 3:
                    pbbone2.Image = Properties.Resources._3;
                    break;
                case 4:
                    pbbone2.Image = Properties.Resources._4;
                    break;
                case 5:
                    pbbone2.Image = Properties.Resources._5;
                    break;
                case 0:
                    pbbone2.Image = Properties.Resources._6;
                    break;
            }
        }

        int CountScore(int rand1, int rand2, int score)
        {



            if (rand1 == 0)
            {
                rand1 = 6;
            }
            if (rand2 == 0)
            {
                rand2 = 6;
            }


            if (rand1 + rand2 == 7)
            {
                score /= 7;
            }
            else if (rand1 + rand2 == 11)
            {
                score *= 11;
            }


            if (score < 2001)
            {
                score = score + rand2 + rand1;
            }
            else
            {
                score = score - rand1 - rand2;
            }


            return score;
        }

    }
}
