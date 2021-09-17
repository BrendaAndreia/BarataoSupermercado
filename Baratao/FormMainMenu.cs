using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Baratao
{
    public partial class FormMainMenu : Form
    {
        //fields 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormMainMenu()
        {
          
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //struct color
        private struct Colors
        {
            public static Color color1 = Color.FromArgb(255, 212, 50);
            public static Color color2 = Color.FromArgb(255, 255, 255);
            public static Color color3 = Color.FromArgb(144, 203, 251);
            public static Color color4 = Color.FromArgb(145, 145, 145);
        }

        //metodos
        private void ActiveBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                //Btn
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borda esquerda
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icone Atual Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableBtn()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(14, 37, 51);
                currentBtn.ForeColor = Color.FromArgb(15, 177, 191);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(15, 177, 191);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open olny form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color1);
            OpenChildForm(new FormProdutos());
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color2);
            OpenChildForm(new FormVendedores());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color3);
            OpenChildForm(new FormCategorias());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color4);
            OpenChildForm(new FormClientes());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(115, 177, 191);
            lblTitleChildForm.Text = "Home";
        }

        ////Arrastando Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            
                WindowState = FormWindowState.Maximized;
            
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
