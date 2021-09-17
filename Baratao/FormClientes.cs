using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baratao
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            CustomizeComponents();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=BRENDA-PC\SQLEXPRESS;Initial Catalog=BARATAO;Integrated Security=True");
        private void CustomizeComponents()
        {
            txtNomeCliente.AutoSize = false;
            txtNomeCliente.Size = new Size(450, 35);
            txtCPF.AutoSize = false;
            txtCPF.Size = new Size(165, 35);
            txtTelefone.AutoSize = false;
            txtTelefone.Size = new Size(165, 35);
            txtEndereco.AutoSize = false;
            txtEndereco.Size = new Size(450, 35);


        }
        private void ClearField()
        {
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtNomeCliente.Text = "";
            txtNomeCliente.Select();
        }


        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCPF.Text == "" || txtNomeCliente.Text == "" || txtEndereco.Text == "" || txtTelefone.Text == "")
                {
                    MessageBox.Show("Informe todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "insert into Clientes values(" + txtCPF.Text + ",'" + txtNomeCliente.Text + "'," + txtTelefone.Text + ",'" + txtEndereco.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Con.Close();
            populate();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCPF.Text == "" || txtNomeCliente.Text == "" || txtTelefone.Text == "" || txtEndereco.Text == "")
                {
                    MessageBox.Show("Informe todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "update Clientes set NomeCliente ='" + txtNomeCliente.Text + "', Telefone = " + txtTelefone.Text + ", Endereco = '" + txtEndereco.Text + "' where CPF = " + txtCPF.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente alterado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                 
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Con.Close();
            populate();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCPF.Text == "")
                {
                    MessageBox.Show("Selecione um Cliente para excluir!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM Clientes WHERE CPF = " + txtCPF.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Con.Close();
            populate();

        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCPF.Text = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            txtNomeCliente.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            txtTelefone.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
           
        }
        private void populate()
        {
            Con.Open();
            string query = "Select CPF, NomeCliente as Nome, Telefone from Clientes";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvClientes.DataSource = ds.Tables[0];
            Con.Close();

        }
    }
}

