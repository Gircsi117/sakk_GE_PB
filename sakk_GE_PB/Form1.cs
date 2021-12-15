using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sakk_GE_PB
{
    public partial class Form1 : Form
    {
        private bool drag = false;
        private Point oldalHely = new Point(0, 0);

        private Panel[,] jatekter = new Panel[8, 8];
        private Babu[,] babuk = new Babu[8, 8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] babu_nevek = new string[] { "futo", "kiraly", "huszar", "paraszt", "kiralyno", "bastya" }; 

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < babu_nevek.Length; j++)
                {
                    babukIMG.Images.Add($"{i}_{babu_nevek[j]}", Image.FromFile($"../../Images/{i}_{babu_nevek[j]}.png"));
                }
            }

            this.FormBorderStyle = FormBorderStyle.None;
            tabla_general();
            babu_general();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void headerPANEL_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            oldalHely = new Point(e.X, e.Y);
        }

        private void headerPANEL_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            if (this.WindowState != FormWindowState.Maximized && this.Location.Y <= 0)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
        }

        private void headerPANEL_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.oldalHely.X, p.Y - this.oldalHely.Y);
            }
        }

        private void tabla_general()
        {
            int szeles = (jatekterPANEL.Width - 24) / 8;
            int sor = 12;
            int oszlop = 12;
            bool szin = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel pan = new Panel();
                    jatekterPANEL.Controls.Add(pan);
                    pan.Size = new Size(szeles, szeles);
                    pan.Location = new Point(sor, oszlop);
                    pan.Padding = new Padding(3);
                    pan.BackColor = (szin) ? (Color.White) : (Color.Black);
                    pan.Tag = $"{i};{j}";
                    szin = !szin;

                    sor += szeles;

                    jatekter[i, j] = pan;
                }
                szin = !szin;
                oszlop += szeles;
                sor = 12;
            }
        }

        private void babu_general()
        {
            string[] babu_nevek = new string[] { "futo", "kiraly", "huszar", "paraszt", "kiralyno", "bastya" };
            int szin = 1;
            string nev;

            for (int i = 0; i < 8; i++)
            {
                if (i == 2 || i == 3 || i == 4 || i == 5) { continue; }
                if (i == 6) { szin = 0; }
                for (int j = 0; j < 8; j++)
                {
                    switch (j)
                    {
                        case (0): nev = babu_nevek[5]; break;
                        case (1): nev = babu_nevek[2]; break;
                        case (2): nev = babu_nevek[0]; break;
                        case (3): nev = babu_nevek[4]; break;
                        case (4): nev = babu_nevek[1]; break;
                        case (5): nev = babu_nevek[0]; break;
                        case (6): nev = babu_nevek[2]; break;
                        case (7): nev = babu_nevek[5]; break;

                        default: nev = ""; break;
                    }

                    if (i == 1 || i == 6)
                    {
                        nev = babu_nevek[3];
                    }

                    PictureBox pic = new PictureBox();
                    jatekter[i, j].Controls.Add(pic);
                    pic.Dock = DockStyle.Fill;
                    pic.BackgroundImage = babukIMG.Images[$"{szin}_{nev}"];
                    pic.BackgroundImageLayout = ImageLayout.Zoom;
                    pic.Tag = $"{i};{j}";

                    Babu bab = new Babu(pic, i, j, nev, szin);
                    babuk[i, j] = bab;
                }
            }
        }


        private void szinez()
        {
            bool szin = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    jatekter[i, j].BackColor = (szin) ? (Color.White) : (Color.Black);
                    szin = !szin;
                }
                szin = !szin;
            }
        }
    }
}
