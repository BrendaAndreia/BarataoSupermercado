
namespace Baratao
{
    partial class FormVendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.btnCadastrarVendedor = new FontAwesome.Sharp.IconButton();
            this.btnExcluirVendedor = new FontAwesome.Sharp.IconButton();
            this.btnEditarVendedor = new FontAwesome.Sharp.IconButton();
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.dgvVendedor);
            this.panel1.Controls.Add(this.btnExcluirVendedor);
            this.panel1.Controls.Add(this.btnEditarVendedor);
            this.panel1.Controls.Add(this.btnCadastrarVendedor);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtIdVendedor);
            this.panel1.Controls.Add(this.txtNomeVendedor);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblIdVendedor);
            this.panel1.Controls.Add(this.lblNomeVendedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 582);
            this.panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "Preço do Produto";
            this.txtPassword.AccessibleName = "Preço";
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Location = new System.Drawing.Point(255, 275);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(350, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUser
            // 
            this.txtUser.AccessibleDescription = "Preço do Produto";
            this.txtUser.AccessibleName = "Preço";
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtUser.Location = new System.Drawing.Point(255, 200);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(350, 22);
            this.txtUser.TabIndex = 17;
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.AccessibleDescription = "Preço do Produto";
            this.txtIdVendedor.AccessibleName = "Preço";
            this.txtIdVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtIdVendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVendedor.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtIdVendedor.Location = new System.Drawing.Point(255, 50);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(350, 22);
            this.txtIdVendedor.TabIndex = 13;
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.AccessibleDescription = "Preço do Produto";
            this.txtNomeVendedor.AccessibleName = "Preço";
            this.txtNomeVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtNomeVendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVendedor.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNomeVendedor.Location = new System.Drawing.Point(255, 125);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(350, 22);
            this.txtNomeVendedor.TabIndex = 14;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblUser.Location = new System.Drawing.Point(161, 204);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 18);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblPassword.Location = new System.Drawing.Point(161, 279);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblIdVendedor.Location = new System.Drawing.Point(161, 54);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(24, 18);
            this.lblIdVendedor.TabIndex = 1;
            this.lblIdVendedor.Text = "ID";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblNomeVendedor.Location = new System.Drawing.Point(161, 129);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(53, 18);
            this.lblNomeVendedor.TabIndex = 0;
            this.lblNomeVendedor.Text = "Nome";
            // 
            // btnCadastrarVendedor
            // 
            this.btnCadastrarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarVendedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastrarVendedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarVendedor.IconSize = 18;
            this.btnCadastrarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarVendedor.Location = new System.Drawing.Point(164, 510);
            this.btnCadastrarVendedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarVendedor.Name = "btnCadastrarVendedor";
            this.btnCadastrarVendedor.Size = new System.Drawing.Size(112, 44);
            this.btnCadastrarVendedor.TabIndex = 19;
            this.btnCadastrarVendedor.Text = "Cadastrar";
            this.btnCadastrarVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarVendedor.UseVisualStyleBackColor = true;
            this.btnCadastrarVendedor.Click += new System.EventHandler(this.btnCadastrarVendedor_Click);
            // 
            // btnExcluirVendedor
            // 
            this.btnExcluirVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirVendedor.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExcluirVendedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirVendedor.IconSize = 18;
            this.btnExcluirVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirVendedor.Location = new System.Drawing.Point(493, 510);
            this.btnExcluirVendedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirVendedor.Name = "btnExcluirVendedor";
            this.btnExcluirVendedor.Size = new System.Drawing.Size(112, 44);
            this.btnExcluirVendedor.TabIndex = 21;
            this.btnExcluirVendedor.Text = "Excluir";
            this.btnExcluirVendedor.UseVisualStyleBackColor = true;
            this.btnExcluirVendedor.Click += new System.EventHandler(this.btnExcluirVendedor_Click);
            // 
            // btnEditarVendedor
            // 
            this.btnEditarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarVendedor.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarVendedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarVendedor.IconSize = 18;
            this.btnEditarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarVendedor.Location = new System.Drawing.Point(328, 510);
            this.btnEditarVendedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarVendedor.Name = "btnEditarVendedor";
            this.btnEditarVendedor.Size = new System.Drawing.Size(112, 44);
            this.btnEditarVendedor.TabIndex = 20;
            this.btnEditarVendedor.Text = "Editar";
            this.btnEditarVendedor.UseVisualStyleBackColor = true;
            this.btnEditarVendedor.Click += new System.EventHandler(this.btnEditarVendedor_Click);
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.AllowUserToAddRows = false;
            this.dgvVendedor.AllowUserToDeleteRows = false;
            this.dgvVendedor.AllowUserToResizeColumns = false;
            this.dgvVendedor.AllowUserToResizeRows = false;
            this.dgvVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVendedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.dgvVendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVendedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVendedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendedor.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVendedor.EnableHeadersVisualStyles = false;
            this.dgvVendedor.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvVendedor.Location = new System.Drawing.Point(640, 50);
            this.dgvVendedor.MultiSelect = false;
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVendedor.RowHeadersVisible = false;
            this.dgvVendedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVendedor.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedor.Size = new System.Drawing.Size(354, 247);
            this.dgvVendedor.StandardTab = true;
            this.dgvVendedor.TabIndex = 22;
            this.dgvVendedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedor_CellClick);
            // 
            // FormVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 582);
            this.Controls.Add(this.panel1);
            this.Name = "FormVendedores";
            this.Text = "Vendedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIdVendedor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private FontAwesome.Sharp.IconButton btnCadastrarVendedor;
        private FontAwesome.Sharp.IconButton btnExcluirVendedor;
        private FontAwesome.Sharp.IconButton btnEditarVendedor;
        private System.Windows.Forms.DataGridView dgvVendedor;
    }
}