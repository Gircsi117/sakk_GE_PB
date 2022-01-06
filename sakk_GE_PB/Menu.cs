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
        }
    }
}
