using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using ZH3_FormsApp.Models;

namespace ZH3_FormsApp

{
    public partial class Form1 : Form
    {
        Excel.Application xlAPP;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            //3 pont - Anchor, Scaffold-Db
            InitializeComponent();
        }
        //2 pont
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztos benne, hogy ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) e.Cancel = true;
        }
        void Szerkeszt() 
        {
            panelMain.Controls.Clear();

            hozzadadoUserControl uc = new();
            uc.Dock= DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        //4 pont
        void Nyersanyagok() 
        {
            panelMain.Controls.Clear();

            nyersanyagUserControl uc = new();
            uc.Dock= DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        //12 pont
        void Fogasok() 
        {
            //6 pont
            panelMain.Controls.Clear();

            fogasUserControl uc = new();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void buttonFogas_Click(object sender, EventArgs e)
        {
            Fogasok();
        }
        //7 pont
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }
        void CreateExcel() 
        {
            try
            {
               xlAPP = new Excel.Application();

                xlWB = xlAPP.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlAPP.Visible = true;

                xlAPP.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                xlWB.Close(false,Type.Missing,Type.Missing);
                xlAPP.Quit();
                xlWB = null;
                xlSheet = null;
            }
 
        }
        void CreateTable()
        {
            string[] Header = new string[] { "ID", "Név", "Mennyiségi egység", "Egységár" };

            for (int i = 0; i < Header.Count(); i++)
            {
                xlSheet.Cells[1,i + 1] = Header[i];
            }

            FogasokContext context = new();

            var nyersanyagok = context.Nyersanyagok.ToList();

            object[,] adattomb = new object[nyersanyagok.Count(), Header.Count()];

            for (int i = 0; i < nyersanyagok.Count(); i++)
            {
                adattomb[i, 0] = nyersanyagok[i].NyersanyagId;
                adattomb[i, 1] = nyersanyagok[i].NyersanyagNev;
                adattomb[i, 2] = nyersanyagok[i].MennyisegiEgyseg;
                adattomb[i, 3] = nyersanyagok[i].Egysegar;
            }

            int sorokszama = adattomb.GetLength(0);
            int oszlopokszama = adattomb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokszama, oszlopokszama);
            adatRange.Value2 = adattomb;

            adatRange.Columns.AutoFit();

            Excel.Range fejlecRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 4);
            fejlecRange.Font.Bold = true;
            fejlecRange.Interior.Color = Color.Fuchsia;
        }

        private void buttonNyersanyag_Click(object sender, EventArgs e)
        {
            Nyersanyagok();
        }

        private void buttonSzerkeszt_Click(object sender, EventArgs e)
        {
            Szerkeszt();
        }
    }
}