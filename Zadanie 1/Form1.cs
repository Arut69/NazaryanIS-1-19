using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Detalis
        {
            public int stoimost;
            public int data;
            public abstract void Info(ListBox l);
            public Detalis(int stoimostt, int dataa)
            {
                stoimost = stoimostt;
                data = dataa;
            }
        }
        class Procesor : Detalis
        {
            public int kol_yad;
            public int kol_pot;
            public int chastota;
            public override void Info(ListBox l)
            {
                l.Items.Add($"Стоимость - {stoimost}, Год выпуска - {data}, Колличество ядер - {kol_yad}, Колличество потоков - {kol_pot}, Частота - {chastota}");
            }
            public Procesor(int kol_yadd, int kol_pott, int chastotaa, int stoimost, int data) : base(data, stoimost)
            {
                kol_yad = kol_yadd;
                kol_pot = kol_pott;
                chastota = chastotaa;
            }
        }
        class Vidyuha : Detalis
        {
            public int chastotaGPU;
            public int moshnost;
            public int pamyat;
            public override void Info(ListBox l)
            {
                l.Items.Add($"ЧастотаGPU - {chastotaGPU}, Производительность - {moshnost}, Обьем памяти - {pamyat}, Стоимость - {stoimost}, Год выпуска - {data}");
            }
            public Vidyuha(int chastotaGPUU, int moshnostt, int pamyatt, int stoimost, int data) : base(data, stoimost)
            {
                chastotaGPU = chastotaGPUU;
                moshnost = moshnostt;
                pamyat = pamyatt;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procesor sot = new Procesor(16, 4, 8, 2019, 23000);
            sot.Info(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vidyuha sot = new Vidyuha(16, 23000, 32, 2019, 15000);
            sot.Info(listBox2);
        }
    }
}
