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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
            CustomizeComponents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=BRENDA-PC\SQLEXPRESS;Initial Catalog=BARATAO;Integrated Security=True");

        private void CustomizeComponents()
        {
            txtIdCategoria.AutoSize = false;
            txtIdCategoria.Size = new Size(250, 35);
            txtNomeCategoria.AutoSize = false;
            txtNomeCategoria.Size = new Size(250, 35);
            txtDescCategoria.AutoSize = false;
            txtDescCategoria.Size = new Size(250, 35);

        }

        private void Populate()
        {
            Con.Open();
            string query = "Select IdCategoria as 'ID', NomeCategoria as 'Nome', DescCategoria as 'Descrição' from Categoria";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvCategorias.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCategoria.Text = dgvCategorias.SelectedRows[0].Cells[0].Value.ToString();
            txtNomeCategoria.Text = dgvCategorias.SelectedRows[0].Cells[1].Value.ToString();
            txtDescCategoria.Text = dgvCategorias.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Categoria values(" + txtIdCategoria.Text + ",'" + txtNomeCategoria.Text + "','" + txtDescCategoria.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria cadastrada com sucesso!" "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            Populate();
        }
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIdCategoria.Text == "")
                {
                    MessageBox.Show("Selecione uma categoria para excluir!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "delete from Categoria where IdCategoria = "+txtIdCategoria.Text+" ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ClearField();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            Populate();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCategoria.Text == "" || txtNomeCategoria.Text == "" || txtDescCategoria.Text == "")
                {
                    MessageBox.Show("Informe todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "update Categoria set NomeCategoria ='" + txtNomeCategoria.Text + "', DescCategoria = '" + txtDescCategoria.Text + "' where IdCategoria = " + txtIdCategoria.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            Populate();
        }
      

        private void ClearField()
        {
            txtDescCategoria.Text = "";
            txtIdCategoria.Text = "";
            txtNomeCategoria.Text = "";
        }
    }
 }

