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

namespace Baratao
{
    public partial class FormVendedores : Form
    {
        public FormVendedores()
        {
            InitializeComponent();
            CustomizeComponents();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=BRENDA-PC\SQLEXPRESS;Initial Catalog=BARATAO;Integrated Security=True");
        private void CustomizeComponents()
        {
            
            txtIdVendedor.AutoSize = false;
            txtIdVendedor.Size = new Size(350, 35);
            txtNomeVendedor.AutoSize = false;
            txtNomeVendedor.Size = new Size(350, 35);
            txtUser.AutoSize = false;
            txtUser.Size = new Size(350, 35);
            txtPassword.AutoSize = false;
            txtPassword.Size = new Size(350, 35);


        }
        private void populate()
        {
            Con.Open();
            string query = "Select IdVendedor as ID, NomeVendedor as Nome, UserVendedor as Usuário from Vendedores";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvVendedor.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void btnCadastrarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Vendedores values(" + txtIdVendedor.Text + ",'" + txtNomeVendedor.Text + "','" + txtUser.Text + "','" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vendedor cadastrado com sucesso!","Sucesso!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearField()
        {
            txtIdVendedor.Text = "";
            txtNomeVendedor.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void btnEditarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdVendedor.Text == "" || txtNomeVendedor.Text == "" || txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Informe todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "update Vendedores set NomeVendedor ='" + txtNomeVendedor.Text + "', UserVendedor = '" + txtUser.Text + "', Password = '" + txtPassword.Text + "' where IdVendedor = " + txtIdVendedor.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendedor alterado com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVendedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVendedor.Text = dgvVendedor.SelectedRows[0].Cells[0].Value.ToString();
            txtNomeVendedor.Text = dgvVendedor.SelectedRows[0].Cells[1].Value.ToString();
            txtUser.Text = dgvVendedor.SelectedRows[0].Cells[2].Value.ToString();
            


        }

        private void btnExcluirVendedor_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIdVendedor.Text == "")
                {
                    MessageBox.Show("Selecione um vendedor para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "delete from Vendedores where IdVendedor = " + txtIdVendedor.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendedor deletado com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();
                    ClearField();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
