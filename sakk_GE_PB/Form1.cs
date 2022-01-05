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

        public Panel[,] jatekter = new Panel[8, 8];
        private Babu[,] babuk = new Babu[8, 8];
        string[] babu_nevek = new string[6] { "futo", "kiraly", "huszar", "paraszt", "kiralyno", "bastya" };
        private List<Babu> leutottek = new List<Babu>() { };

        private Form valaszt;
        private Babu selected;
        private int fel = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void feladBtn_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show($"{fel} feladod?", "", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                felvalt();
                MessageBox.Show($"{fel} gyozott");
                babu_letorol();
                babu_general();
                fel = 0;
            }
            if (Result == DialogResult.No)
            {
                return;
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
                    pan.Click += mozgat;
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
                //felesleges sorok kihagyása
                if (i == 2 || i == 3 || i == 4 || i == 5) { continue; }
                //Bábúk szinének modosítása
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
                    pic.Click += kijelol;

                    Babu bab = new Babu(pic, i, j, nev, szin);
                    babuk[i, j] = bab;
                }
            }
        }

        private void babu_letorol()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(jatekter[i, j].Controls.Count != 0)
                    {
                        jatekter[i, j].Controls.Clear();
                    }
                }
            }
        }

        //panelhez adás
        private void mozgat(object sender, EventArgs e)
        {
            Panel pan = sender as Panel;

            if (pan.BackColor == Color.Yellow)
            {
                int sor = Convert.ToInt32(pan.Tag.ToString().Split(';')[0]);
                int oszlop = Convert.ToInt32(pan.Tag.ToString().Split(';')[1]);
                pan.Controls.Add(babuk[selected.Sor, selected.Oszlop].Maga);

                babuk[selected.Sor, selected.Oszlop] = null;
                selected.Sor = sor;
                selected.Oszlop = oszlop;
                selected.Maga.Tag = pan.Tag;

                babuk[sor, oszlop] = selected;
                jatekter[sor, oszlop].Controls.Add(selected.Maga);

                if ((sor == 0 && selected.Name == "paraszt") || (sor == 7 && selected.Name == "paraszt"))
                {
                    csere();
                }

                felvalt();
            }

            szinez();
        }

        //bábúkhoz adni, a kijelölt bábú vizsgálata
        private void kijelol(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int x = Convert.ToInt32(pic.Tag.ToString().Split(';')[0]);
            int y = Convert.ToInt32(pic.Tag.ToString().Split(';')[1]);

            if (babuk[x, y].Szin == fel)
            {
                szinez();
                selected = babuk[x, y];

                if (selected.Name != "paraszt")
                {
                    for (int i = 0; i < selected.Iranyok.Count; i++)
                    {
                        hely_szinez(selected, selected.Sor, selected.Oszlop, selected.Iranyok[i][0], selected.Iranyok[i][1], selected.Nagylepes);
                    }
                }
                else
                {
                    for (int i = 0; i < selected.Iranyok.Count; i++)
                    {
                        hely_szinez(selected, selected.Sor, selected.Oszlop, selected.Iranyok[i][0], selected.Iranyok[i][1], selected.Nagylepes, i);
                    }

                }
            }
            else if (jatekter[x, y].BackColor == Color.Red) //Leütés
            {
                if (babuk[x, y].Name != "paraszt")
                {
                    leutottek.Add(babuk[x, y]);
                }
                
                jatekter[x, y].Controls.Clear();

                jatekter[x, y].Controls.Add(jatekter[selected.Sor, selected.Oszlop].Controls[0]);

                babuk[selected.Sor, selected.Oszlop] = null;
                selected.Sor = x;
                selected.Oszlop = y;
                selected.Maga.Tag = jatekter[x, y].Tag;
                babuk[x, y] = selected;

                if ((x == 0 && selected.Name == "paraszt") || (x == 7 && selected.Name == "paraszt"))
                {
                    csere();
                }

                felvalt();
                szinez();
            }
        }

        private void csere()
        {
            valaszt = new Form();
            valaszt.Size = new Size(500, 250);
            valaszt.StartPosition = FormStartPosition.CenterScreen;
            valaszt.BackColor = Color.FromArgb(255, 128, 0);
            valaszt.FormBorderStyle = FormBorderStyle.None;
            valaszt.MaximizeBox = false;
            valaszt.MinimizeBox = false;

            List<Babu> kello = leutottek.FindAll(x => x.Szin == fel);
            kello.OrderBy(x => x.Name);
            var elemek = from elem in kello group elem by elem.Name;

            if (kello.Count > 0)
            {
                valaszt.Size = new Size(elemek.Count() * 100, 100);

                int x = 0;

                for (int i = 0; i < elemek.Count(); i++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(100, 100);
                    pic.BackgroundImage = babukIMG.Images[$"{fel}_{elemek.ToList()[i].Key}"];
                    pic.Tag = $"{fel}_{elemek.ToList()[i].Key}";
                    pic.BackgroundImageLayout = ImageLayout.Zoom;
                    valaszt.Controls.Add(pic);
                    pic.Location = new Point(x, 0);

                    pic.Click += kicserel;
                    

                    x += pic.Width;
                }

                valaszt.ShowDialog();
            }
        }

        private void kicserel(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int szin = Convert.ToInt32(pic.Tag.ToString().Split('_')[0]);
            string nev = pic.Tag.ToString().Split('_')[1];

            Babu csere = leutottek.Find(x => x.Szin == szin && x.Name == nev);
            leutottek.Remove(csere);

            csere.Sor = selected.Sor;
            csere.Oszlop = selected.Oszlop;

            babuk[csere.Sor, csere.Oszlop].Name = csere.Name;
            babuk[csere.Sor, csere.Oszlop].Iranyok = csere.Iranyok;
            babuk[csere.Sor, csere.Oszlop].Nagylepes = csere.Nagylepes;
            jatekter[csere.Sor, csere.Oszlop].Controls[0].BackgroundImage = babukIMG.Images[$"{szin}_{nev}"];
            babuk[csere.Sor, csere.Oszlop].Maga.BackgroundImage = babukIMG.Images[$"{szin}_{nev}"];

            valaszt.Close();
        }

        //A bábú helyeinek szinezése
        private void hely_szinez(Babu select, int sor, int oszlop, int sorIrany, int oszlopIrany, bool nagylepes, int szam = 0)
        {
            bool mehete = true;

            if ((sor+sorIrany) < 8 && (sor+sorIrany) >= 0 && (oszlop+oszlopIrany) < 8 && (oszlop + oszlopIrany) >= 0)
            {
                if (jatekter[(sor + sorIrany), (oszlop + oszlopIrany)].Controls.Count == 0 && szam == 0)
                {
                    jatekter[sor + sorIrany, oszlop + oszlopIrany].BackColor = Color.Yellow;
                }
                else if(jatekter[(sor + sorIrany), (oszlop + oszlopIrany)].Controls.Count != 0)
                {
                    mehete = false;
                    if (babuk[sor + sorIrany, oszlop + oszlopIrany].Szin != select.Szin && (select.Name != "paraszt" || szam != 0))
                    {
                        jatekter[sor + sorIrany, oszlop + oszlopIrany].BackColor = Color.Red;
                    }
                }
                
            }
            else
            {
                mehete = false;
            }

            //Hosszú lépéses bábú esetén rekuzív folytatás
            if (nagylepes && mehete)
            {
                hely_szinez(select, (sor + sorIrany), (oszlop + oszlopIrany), sorIrany, oszlopIrany, true);
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

        private void felvalt()
        {
            fel = Math.Abs(fel - 1);
        }
    }
}
