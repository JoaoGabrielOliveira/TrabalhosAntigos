using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Locadora
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();

            
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if(bar.Value < 100)
            {
                bar.Value = bar.Value + 1;
                
            }
            else
            {
                tmr.Enabled = false;
                login page = new login();
                page.Show();
                this.Hide();
            }

        }
    }
}
