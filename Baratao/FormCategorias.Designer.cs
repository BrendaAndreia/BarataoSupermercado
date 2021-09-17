
namespace Baratao
{
    partial class FormCategorias
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
            this.lblNomeCategoria = new System.Windows.Forms.Label();
            this.txtDescCategoria = new System.Windows.Forms.TextBox();
            this.lblDescCategoria = new System.Windows.Forms.Label();
            this.btnExcluirCategoria = new FontAwesome.Sharp.IconButton();
            this.btnEditarCategoria = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarCategoria = new FontAwesome.Sharp.IconButton();
            this.panelDesktopCategoria = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCategoria
            // 
            this.lblNomeCategoria.AutoSize = true;
            this.lblNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblNomeCategoria.Location = new System.Drawing.Point(13, 215);
            this.lblNomeCategoria.Name = "lblNomeCategoria";
            this.lblNomeCategoria.Size = new System.Drawing.Size(53, 18);
            this.lblNomeCategoria.TabIndex = 6;
            this.lblNomeCategoria.Text = "Nome";
            // 
            // txtDescCategoria
            // 
            this.txtDescCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtDescCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescCategoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDescCategoria.Location = new System.Drawing.Point(16, 314);
            this.txtDescCategoria.Name = "txtDescCategoria";
            this.txtDescCategoria.Size = new System.Drawing.Size(173, 20);
            this.txtDescCategoria.TabIndex = 1;
            // 
            // lblDescCategoria
            // 
            this.lblDescCategoria.AutoSize = true;
            this.lblDescCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.lblDescCategoria.Location = new System.Drawing.Point(12, 293);
            this.lblDescCategoria.Name = "lblDescCategoria";
            this.lblDescCategoria.Size = new System.Drawing.Size(85, 18);
            this.lblDescCategoria.TabIndex = 0;
            this.lblDescCategoria.Text = "Descrição";
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.FlatAppearance.BorderSize = 2;
            this.btnExcluirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirCategoria.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnExcluirCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnExcluirCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcluirCategoria.IconSize = 18;
            this.btnExcluirCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCategoria.Location = new System.Drawing.Point(304, 401);
            this.btnExcluirCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(106, 35);
            this.btnExcluirCategoria.TabIndex = 2;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.FlatAppearance.BorderSize = 2;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarCategoria.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnEditarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCategoria.IconSize = 18;
            this.btnEditarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCategoria.Location = new System.Drawing.Point(167, 401);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(103, 35);
            this.btnEditarCategoria.TabIndex = 1;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.FlatAppearance.BorderSize = 2;
            this.btnCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarCategoria.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastrarCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.btnCadastrarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarCategoria.IconSize = 18;
            this.btnCadastrarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(17, 401);
            this.btnCadastrarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrarCategoria.TabIndex = 0;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // panelDesktopCategoria
            // 
            this.panelDesktopCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panelDesktopCategoria.Controls.Add(this.btnExcluirCategoria);
            this.panelDesktopCategoria.Controls.Add(this.dgvCategorias);
            this.panelDesktopCategoria.Controls.Add(this.btnEditarCategoria);
            this.panelDesktopCategoria.Controls.Add(this.btnCadastrarCategoria);
            this.panelDesktopCategoria.Controls.Add(this.txtNomeCategoria);
            this.panelDesktopCategoria.Controls.Add(this.txtIdCategoria);
            this.panelDesktopCategoria.Controls.Add(this.label1);
            this.panelDesktopCategoria.Controls.Add(this.lblNomeCategoria);
            this.panelDesktopCategoria.Controls.Add(this.txtDescCategoria);
            this.panelDesktopCategoria.Controls.Add(this.lblDescCategoria);
            this.panelDesktopCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopCategoria.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktopCategoria.Name = "panelDesktopCategoria";
            this.panelDesktopCategoria.Size = new System.Drawing.Size(944, 471);
            this.panelDesktopCategoria.TabIndex = 3;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.DarkCyan;
            this.dgvCategorias.Location = new System.Drawing.Point(413, 151);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(519, 145);
            this.dgvCategorias.StandardTab = true;
            this.dgvCategorias.TabIndex = 14;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtNomeCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCategoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNomeCategoria.Location = new System.Drawing.Point(16, 236);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(173, 20);
            this.txtNomeCategoria.TabIndex = 13;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.AccessibleDescription = "Preço do Produto";
            this.txtIdCategoria.AccessibleName = "Preço";
            this.txtIdCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.txtIdCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCategoria.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtIdCategoria.Location = new System.Drawing.Point(16, 151);
            this.txtIdCategoria.Multiline = true;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(173, 22);
            this.txtIdCategoria.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(140)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 471);
            this.Controls.Add(this.panelDesktopCategoria);
            this.Name = "FormCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            this.panelDesktopCategoria.ResumeLayout(false);
            this.panelDesktopCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNomeCategoria;
        private System.Windows.Forms.TextBox txtDescCategoria;
        private System.Windows.Forms.Label lblDescCategoria;
        private FontAwesome.Sharp.IconButton btnExcluirCategoria;
        private FontAwesome.Sharp.IconButton btnEditarCategoria;
        private FontAwesome.Sharp.IconButton btnCadastrarCategoria;
        private System.Windows.Forms.Panel panelDesktopCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}