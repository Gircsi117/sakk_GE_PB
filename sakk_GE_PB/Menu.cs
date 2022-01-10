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
    public partial class Menu : UserControl
    {
        public static int[] szin1 = new int[3] { 255, 128, 0 };
        public static int[] szin2 = new int[3] { 0, 0, 0 };

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            this.Dock = DockStyle.Fill;

            int w = Screen.PrimaryScreen.WorkingArea.Width;
            int h = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = (w / 10 * 7);
            this.Height = (h / 10 * 7);
            this.Location = new Point(w / 2 - this.Width / 2, h / 2 - this.Height / 2);

            menu_style();
        }

        private void menu_style()
        {
            int magas = this.Height / 2;
            int egyseg = magas / 24;

            cimLBL.Font = new Font("Arial", cimLBL.Height / 2);

            TextBox[] p_panels = new TextBox[2] { p1TBOX, p2TBOX };

            for (int i = 0; i < p_panels.Length; i++)
            {
                p_panels[i].Font = new Font("Arial", 32);
                p_panels[i].MouseClick += nev_torol;
                p_panels[i].BorderStyle = BorderStyle.FixedSingle;
            }

            Button[] menu_buttons = new Button[3] { startBtn, infoBtn, exitBtn };
            int b_pos = 10;

            for (int i = 0; i < menu_buttons.Length; i++)
            {
                menu_buttons[i].FlatStyle = FlatStyle.Flat;
                menu_buttons[i].FlatAppearance.BorderColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
                menu_buttons[i].FlatAppearance.BorderSize = 3;
                menu_buttons[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
                menu_buttons[i].ForeColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
                menu_buttons[i].BackColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
                menu_buttons[i].Font = new Font("Arial", 18);
                menu_buttons[i].MouseEnter += erint;
                menu_buttons[i].MouseLeave += elhagy;
                menu_buttons[i].Cursor = Cursors.Hand;

                b_pos += 3;
            }

            this.Focus();
        }

        public static void erint(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
            btn.BackColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
        }
        public static void elhagy(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(szin2[0], szin2[1], szin2[2]);
            btn.BackColor = Color.FromArgb(szin1[0], szin1[1], szin1[2]);
        }

        private void nev_torol(object sender, MouseEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            tbox.Text = "";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            global.nev1.Text = p1TBOX.Text;
            global.nev2.Text = p2TBOX.Text;
            this.Visible = false;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Sakk");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
