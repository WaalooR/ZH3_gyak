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
    public partial class fogasUserControl : UserControl
    {
        FogasokContext context = new();       
        public fogasUserControl()
        {
            InitializeComponent();
        }
        private void szurFogas()
        {
            var szurt = from x in context.Fogasok
                        where x.FogasNev.Contains(textBoxFogas.Text)
                        select x;
                        
            listBoxFogas.DataSource = szurt.ToList();
            listBoxFogas.DisplayMember = "FogasNev";

            fogasokBindingSource.DataSource = szurt.ToList();
        }
        void kiIr()
        {
            var szurt = ((Fogasok)listBoxFogas.SelectedItem);

            textBoxFogasNeve.Text = szurt.FogasNev;
            if (szurt.Leiras == null) textBoxFogasLeiras.Text = "Nincs elérhető leírás";
            else textBoxFogasLeiras.Text = szurt.Leiras;
        }

        private void textBoxFogasKeres_TextChanged(object sender, EventArgs e)
        {
            szurFogas();
        }

        private void listBoxFogasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiIr();
        }

        private void fogasUserControl_Load(object sender, EventArgs e)
        {
            szurFogas();
            kiIr();
        }
    }
}
