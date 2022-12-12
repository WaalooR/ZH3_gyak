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
    public partial class nyersanyagUserControl : UserControl
    {
        FogasokContext context = new(); 
        public nyersanyagUserControl()
        {
            InitializeComponent();
        }
        void szurNyers() 
        {
            var szurt = from x in context.Nyersanyagok
                        where x.NyersanyagNev.Contains(textBoxNyers.Text)
                        select x;
                        
            listBoxNyers.DataSource = szurt.ToList();
            listBoxNyers.DisplayMember = "NyersanyagNev";

            nyersanyagokBindingSource1.DataSource= szurt.ToList();
        }
        private void nyersanyagUserControl_Load(object sender, EventArgs e)
        {
            szurNyers();
        }

        private void textBoxNyersKeres_TextChanged(object sender, EventArgs e)
        {
            szurNyers();
        }
    }
}
