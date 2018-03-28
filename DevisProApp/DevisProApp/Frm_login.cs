using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevisProApp.Clases;
using MySql.Data.MySqlClient;

namespace DevisProApp
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        Login logeo = new Login();
                        
        private void lbl_salir_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (logeo.Logeo(txt_usuario.Text, txt_password.Text))
            {
                Form apu = new Frm_apu();
                apu.Show();
            }
            else
            {
                
            }
        }
    }
}
