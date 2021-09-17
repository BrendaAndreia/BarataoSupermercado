
namespace Baratao
{
    partial class FormClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirCliente = new FontAwesome.Sharp.IconButton();
            this.btnEditarCliente = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Controls.Add(this.btnExcluirCliente);
            this.panel1.Controls.Add(this.btnEditarCliente);
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 426);
            this.panel1.TabIndex = 1;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirCliente.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExcluirCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirCliente.IconSize = 18;
            this.btnExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCliente.Location = new System.Drawing.Point(506, 324);
            this.btnExcluirCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(112, 44);
            this.btnExcluirCliente.TabIndex = 27;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarCliente.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCliente.IconSize = 18;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(341, 324);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(112, 44);
            this.btnEditarCliente.TabIndex = 26;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastrarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarCliente.IconSize = 18;
            this.btnCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(177, 324);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(112, 44);
            this.btnCadastrarCliente.TabIndex = 25;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AccessibleDescription = "Preço do Produto";
            this.txtTelefone.AccessibleName = "Preço";
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTelefone.Location = new System.Drawing.Point(459, 141);
            this.txtTelefone.MaxLength = 13;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(190, 22);
            this.txtTelefone.TabIndex = 24;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblTelefone.Location = new System.Drawing.Point(380, 145);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 18);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AccessibleDescription = "Preço do Produto";
            this.txtEndereco.AccessibleName = "Preço";
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtEndereco.Location = new System.Drawing.Point(198, 216);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(451, 22);
            this.txtEndereco.TabIndex = 18;
            // 
            // txtCPF
            // 
            this.txtCPF.AccessibleDescription = "Preço do Produto";
            this.txtCPF.AccessibleName = "Preço";
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCPF.Location = new System.Drawing.Point(198, 141);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(164, 22);
            this.txtCPF.TabIndex = 17;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.AccessibleDescription = "Preço do Produto";
            this.txtNomeCliente.AccessibleName = "Preço";
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNomeCliente.Location = new System.Drawing.Point(198, 66);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(451, 22);
            this.txtNomeCliente.TabIndex = 14;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblCPF.Location = new System.Drawing.Point(104, 145);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 18);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblEndereco.Location = new System.Drawing.Point(104, 220);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 18);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(104, 70);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(53, 18);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvClientes.Location = new System.Drawing.Point(697, 66);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(316, 228);
            this.dgvClientes.StandardTab = true;
            this.dgvClientes.TabIndex = 28;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 426);
            this.Controls.Add(this.panel1);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private FontAwesome.Sharp.IconButton btnExcluirCliente;
        private FontAwesome.Sharp.IconButton btnEditarCliente;
        private FontAwesome.Sharp.IconButton btnCadastrarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}