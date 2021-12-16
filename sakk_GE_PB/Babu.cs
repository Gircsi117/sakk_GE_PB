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
        private List<int[]> iranyok; //"futo", "kiraly", "huszar", "paraszt", "kiralyno", "bastya"
        private bool nagylepes;

        public int Sor { get => sor; set => sor = value; }
        public int Oszlop { get => oszlop; set => oszlop = value; }
        public string Name { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }
        public int Szin { get => szin; set => szin = value; }
        public PictureBox Maga { get => maga; set => maga = value; }
        public List<int[]> Iranyok { get => iranyok; set => iranyok = value; }
        public bool Nagylepes { get => nagylepes; set => nagylepes = value; }

        public Babu(PictureBox ez, int sor, int oszlop, string name, int szin)
        {
            this.maga = ez;
            this.sor = sor;
            this.oszlop = oszlop;
            this.name = name;
            this.status = true;
            this.szin = szin;

            if (name == "futo")
            {
                iranyok = new List<int[]>()
                {
                    new int[]{ 1, -1 },
                    new int[]{ 1, 1 },
                    new int[]{ -1, 1 },
                    new int[]{ -1, -1 },
                };
                nagylepes = true;
            }
            else if (name == "kiraly")
            {
                iranyok = new List<int[]>()
                {
                    new int[]{ 1, -1 },
                    new int[]{ 1, 0 },
                    new int[]{ 1, 1 },
                    new int[]{ 0, 1 },
                    new int[]{ -1, 1 },
                    new int[]{ -1, 0 },
                    new int[]{ -1, -1 },
                    new int[]{ 0, -1 },
                };
                nagylepes = false;
            }
            else if (name == "huszar")
            {
                iranyok = new List<int[]>()
                {
                    new int[]{ 1, -2 },
                    new int[]{ 2, -1 },
                    new int[]{ 2, 1 },
                    new int[]{ 1, 2 },
                    new int[]{ -1, 2 },
                    new int[]{ -2, 1 },
                    new int[]{ -2, -1 },
                    new int[]{ -1, -2 },
                };
                nagylepes = false;
            }
            else if (name == "paraszt")
            {
                if (szin == 1)
                {
                    iranyok = new List<int[]>()
                    {
                        new int[]{ 1, 0 },
                        new int[]{ 1, -1 },
                        new int[]{ 1, 1 }
                    };
                    nagylepes = false;
                }
                else
                {
                    iranyok = new List<int[]>()
                    {
                        new int[]{ -1, 0 },
                        new int[]{ -1, -1 },
                        new int[]{ -1, 1 }
                    };
                    nagylepes = false;
                }
            }
            else if (name == "kiralyno")
            {
                iranyok = new List<int[]>()
                {
                    new int[]{ 1, -1 },
                    new int[]{ 1, 0 },
                    new int[]{ 1, 1 },
                    new int[]{ 0, 1 },
                    new int[]{ -1, 1 },
                    new int[]{ -1, 0 },
                    new int[]{ -1, -1 },
                    new int[]{ 0, -1 },
                };
                nagylepes = true;
            }
            else
            {
                iranyok = new List<int[]>()
                {
                    new int[]{ 1, 0 },
                    new int[]{ -1, 0 },
                    new int[]{ 0, 1 },
                    new int[]{ 0, -1 },
                };
                nagylepes = true;
            }
        }
    }
}
