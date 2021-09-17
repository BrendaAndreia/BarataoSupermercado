
namespace Baratao
{
    partial class FormProdutos
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
            this.btnExcluirProduto = new FontAwesome.Sharp.IconButton();
            this.btnEditarProduto = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarProduto = new FontAwesome.Sharp.IconButton();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQuantidadeProduto = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panelDesktopProduto = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.panelDesktopProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirProduto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExcluirProduto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirProduto.IconSize = 18;
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.Location = new System.Drawing.Point(282, 515);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(112, 44);
            this.btnExcluirProduto.TabIndex = 2;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarProduto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarProduto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarProduto.IconSize = 18;
            this.btnEditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProduto.Location = new System.Drawing.Point(155, 515);
            this.btnEditarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(112, 44);
            this.btnEditarProduto.TabIndex = 1;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarProduto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastrarProduto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarProduto.IconSize = 18;
            this.btnCadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(30, 515);
            this.btnCadastrarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(112, 44);
            this.btnCadastrarProduto.TabIndex = 0;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblNomeProduto.Location = new System.Drawing.Point(32, 169);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(61, 22);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProduto.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNomeProduto.Location = new System.Drawing.Point(36, 196);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(350, 15);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblPreco.Location = new System.Drawing.Point(32, 268);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(62, 22);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.AccessibleDescription = "Preço do Produto";
            this.txtPreco.AccessibleName = "Preço";
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPreco.Location = new System.Drawing.Point(36, 293);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(78, 15);
            this.txtPreco.TabIndex = 3;
            // 
            // lblQuantidadeProduto
            // 
            this.lblQuantidadeProduto.AutoSize = true;
            this.lblQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblQuantidadeProduto.Location = new System.Drawing.Point(273, 268);
            this.lblQuantidadeProduto.Name = "lblQuantidadeProduto";
            this.lblQuantidadeProduto.Size = new System.Drawing.Size(113, 22);
            this.lblQuantidadeProduto.TabIndex = 4;
            this.lblQuantidadeProduto.Text = "Quantidade";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtQuantidadeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidadeProduto.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(282, 293);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(91, 15);
            this.txtQuantidadeProduto.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblCategoria.Location = new System.Drawing.Point(32, 372);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(97, 22);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // panelDesktopProduto
            // 
            this.panelDesktopProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panelDesktopProduto.Controls.Add(this.dgvProdutos);
            this.panelDesktopProduto.Controls.Add(this.btnExcluirProduto);
            this.panelDesktopProduto.Controls.Add(this.btnEditarProduto);
            this.panelDesktopProduto.Controls.Add(this.cboxCategoria);
            this.panelDesktopProduto.Controls.Add(this.btnCadastrarProduto);
            this.panelDesktopProduto.Controls.Add(this.txtIdProduto);
            this.panelDesktopProduto.Controls.Add(this.lblIdProduto);
            this.panelDesktopProduto.Controls.Add(this.lblCategoria);
            this.panelDesktopProduto.Controls.Add(this.txtQuantidadeProduto);
            this.panelDesktopProduto.Controls.Add(this.lblQuantidadeProduto);
            this.panelDesktopProduto.Controls.Add(this.txtPreco);
            this.panelDesktopProduto.Controls.Add(this.lblPreco);
            this.panelDesktopProduto.Controls.Add(this.txtNomeProduto);
            this.panelDesktopProduto.Controls.Add(this.lblNomeProduto);
            this.panelDesktopProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopProduto.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopProduto.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktopProduto.Name = "panelDesktopProduto";
            this.panelDesktopProduto.Size = new System.Drawing.Size(980, 631);
            this.panelDesktopProduto.TabIndex = 1;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvProdutos.Location = new System.Drawing.Point(425, 80);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(543, 228);
            this.dgvProdutos.StandardTab = true;
            this.dgvProdutos.TabIndex = 15;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.cboxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCategoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(35, 421);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(210, 24);
            this.cboxCategoria.TabIndex = 9;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.AccessibleDescription = "Preço do Produto";
            this.txtIdProduto.AccessibleName = "Preço";
            this.txtIdProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProduto.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtIdProduto.Location = new System.Drawing.Point(35, 105);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(78, 15);
            this.txtIdProduto.TabIndex = 8;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblIdProduto.Location = new System.Drawing.Point(31, 80);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(29, 22);
            this.lblIdProduto.TabIndex = 7;
            this.lblIdProduto.Text = "ID";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 631);
            this.Controls.Add(this.panelDesktopProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.panelDesktopProduto.ResumeLayout(false);
            this.panelDesktopProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCadastrarProduto;
        private FontAwesome.Sharp.IconButton btnExcluirProduto;
        private FontAwesome.Sharp.IconButton btnEditarProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQuantidadeProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panelDesktopProduto;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}