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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            CustomizeComponents();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=BRENDA-PC\SQLEXPRESS;Initial Catalog=BARATAO;Integrated Security=True");
        private void CustomizeComponents()
        {
            txtNomeProduto.AutoSize = false;
            txtNomeProduto.Size = new Size(350, 35);
            txtIdProduto.AutoSize = false;
            txtIdProduto.Size = new Size(350, 35);
            txtPreco.AutoSize = false;
            txtPreco.Size = new Size(100, 35);
            txtQuantidadeProduto.AutoSize = false;
            txtQuantidadeProduto.Size = new Size(100, 35);
            cboxCategoria.AutoSize = false;
            cboxCategoria.Size = new Size(210, 25);


        }
        private void populate()
        {
            Con.Open();
            string query = "Select * from Produtos";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvProdutos.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void FillCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select NomeCategoria from Categoria", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NomeCategoria", typeof(string));
            dt.Load(rdr);
            cboxCategoria.ValueMember = "NomeCategoria";
            cboxCategoria.DataSource = dt;
            Con.Close();
        }
        private void FormProdutos_Load(object sender, EventArgs e)
        {
            FillCombo();
        }
        //Cadastrar start
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Produtos values("+txtIdProduto.Text+",'"+txtNomeProduto.Text+ "'," + txtPreco.Text + "," + txtQuantidadeProduto.Text + ",'" + cboxCategoria.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            populate();
        }
        
 
        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProduto.Text = dgvProdutos.SelectedRows[0].Cells[0].Value.ToString();
            txtNomeProduto.Text = dgvProdutos.SelectedRows[0].Cells[1].Value.ToString();
            txtPreco.Text = dgvProdutos.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantidadeProduto.Text = dgvProdutos.SelectedRows[0].Cells[3].Value.ToString();
            cboxCategoria.Text = dgvProdutos.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtIdProduto.Text == "")
                {
                    MessageBox.Show("Selecione um produto para excluir!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Con.Open();
                    string query = "delete from Produtos where IdProduto = " + txtIdProduto.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto deletado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProduto.Text == "" || txtNomeProduto.Text == "" || txtPreco.Text == "" || txtQuantidadeProduto.Text == "")
                {
                    MessageBox.Show("Informe todos os campos!");
                }
                else
                {
                    Con.Open();
                    string query = "update Produtos set NomeProduto ='" + txtNomeProduto.Text + "', Preco = " + txtPreco.Text + ", QtdProduto = " +txtQuantidadeProduto.Text + ", CategoriaProduto = '" + cboxCategoria.SelectedValue.ToString() + "' where IdProduto = " + txtIdProduto.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto alterado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
        private void ClearField()
        {
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            txtQuantidadeProduto.Text = "";
            cboxCategoria.Text = "";
        }
    }
}
