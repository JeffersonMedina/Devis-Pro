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
using DevisProApp.mysql;
using MySql.Data.MySqlClient;

namespace DevisProApp
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        MySqlCommand sql = new MySqlCommand();

        public void login()
        {
            
            try{
                conexion.AbrirConexion();
                sql.CommandText = "select count(*) from usuario where cedula='"+txt_usuario.Text+"' and password='"+txt_password.Text+"'";
                int valor = int.Parse(sql.ExecuteScalar().ToString());

                if (valor == 1)
                {
                    Form apu = new Frm_apu();
                    apu.ShowDialog();
                }
                else
                {
                    Form login = new Frm_login();
                    login.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void lbl_salir_MouseHover(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
