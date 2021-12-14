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
        static List<Babu> leutottek = new List<Babu>() { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        }
    }
}
