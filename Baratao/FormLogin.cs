using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baratao
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CustomizeComponents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=BRENDA-PC\SQLEXPRESS;Initial Catalog=BARATAO;Integrated Security=True");


        ////Arrastando Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void CustomizeComponents()
        {
            txtUser.AutoSize = false;
            txtUser.Size = new Size(350, 35);
            txtPassword.AutoSize = false;
            txtPassword.Size = new Size(350, 35);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "Select * from Vendedores where UserVendedor = '" + txtUser.Text +"' AND Password = '"+txtPassword.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataTable();
            sda.Fill(ds);

            if (ds.Rows.Count == 1)
            {
                FormMainMenu principal = new FormMainMenu();
                this.Close();
                principal.Show();
                
            }
            else
            {
                MessageBox.Show("Usuário/Senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Select();
            }
            Con.Close();
        }
    }
}
