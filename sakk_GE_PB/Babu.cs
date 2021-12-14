using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sakk_GE_PB
{
    class Babu
    {
        private PictureBox maga;
        private int sor;
        private int oszlop;
        private string name;
        private bool status;
        private int szin;

        public int Sor { get => sor; set => sor = value; }
        public int Oszlop { get => oszlop; set => oszlop = value; }
        public string Name { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }
        public int Szin { get => szin; set => szin = value; }
        public PictureBox Maga { get => maga; set => maga = value; }

        public Babu(PictureBox ez, int sor, int oszlop, string name, int szin)
        {
            this.maga = ez;
            this.sor = sor;
            this.oszlop = oszlop;
            this.name = name;
            this.status = true;
            this.szin = szin;
        }
    }
}
