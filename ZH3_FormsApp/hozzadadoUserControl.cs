using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_FormsApp.Models;

namespace ZH3_FormsApp
{
    public partial class hozzadadoUserControl : UserControl
    {
        FogasokContext context = new();
        public hozzadadoUserControl()
        {
            InitializeComponent();
        }
        void listNyers() 
        {
            var szurt = ((Nyersanyagok)listBoxNyers.SelectedItem);

            var kivalaszott = (from x in context.MennyisegiEgysegek
                              where x.MennyisegiEgysegId == szurt.MennyisegiEgysegId
                              select x).FirstOrDefault();


        }
        void listFogas() 
        {
            var id = ((Fogasok)listBoxFogas.SelectedItem).FogasId;

            var hozzavalok = from x in context.Receptek
                             where x.FogasId == id
                             select new
                             {
                                 x.Nyersanyag.NyersanyagNev,
                                 x.Mennyiseg4fo,
                                 x.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                                 Ar = x.Mennyiseg4fo * (double?)x.Nyersanyag.Egysegar
                             };
            dataGridViewMain.DataSource= hozzavalok.ToList();
        }
        void szurFogas() 
        {
            var szurt = from x in context.Fogasok
                        where x.FogasNev.Contains(textBoxFogas.Text)
                        select x;

            listBoxFogas.DataSource = szurt.ToList();
            listBoxFogas.DisplayMember = "FogasNev";
        }
        void szurNyers() 
        {
            var szurt = from x in context.Nyersanyagok
                        where x.NyersanyagNev.Contains(textBoxNyers.Text)
                        select new
                        {
                            Név = x.NyersanyagNev,
                            Mennyiség = x.MennyisegiEgyseg,
                            Ar = x.Egysegar
                        };

            listBoxNyers.DataSource = szurt.ToList();
            listBoxNyers.DisplayMember = "Név";
        }

        private void hozzadadoUserControl_Load(object sender, EventArgs e)
        {
            szurFogas();
            szurNyers();
            listFogas();
        }

        private void textBoxFogas_TextChanged(object sender, EventArgs e)
        {
            szurFogas();
        }

        private void textBoxNyers_TextChanged(object sender, EventArgs e)
        {
            szurNyers();
        }

        private void listBoxFogas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listFogas();
        }

        private void listBoxNyers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
