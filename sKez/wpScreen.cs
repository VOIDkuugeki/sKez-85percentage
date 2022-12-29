using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sKez
{
    public partial class wpScreen : Form
    {
        public wpScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void settingIcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userIcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void silentBtn_Click(object sender, EventArgs e)
        {

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// Draggable panel:
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pagesTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void customBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            cancelBtn.Visible = true;
            newBtn.Visible = true;
            dltBtn.Visible = true;
            editBtn.Visible = false;
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancelBtn.Visible = false;
            newBtn.Visible = false;
            dltBtn.Visible = false;
            editBtn.Visible = true;
        }

        private void userIcon_Click(object sender, EventArgs e)
        {

        }

        private void userPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void signupBtn_MouseEnter(object sender, EventArgs e)
        {
            signupBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void signupBtn_MouseLeave(object sender, EventArgs e)
        {
            signupBtn.Font = new System.Drawing.Font("Meiryo UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form childForm = new userAccess_1();
            childForm.ShowDialog();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Form childForm = new userAccess_2();
            childForm.ShowDialog();
        }

        private void workspaceBtn_Click(object sender, EventArgs e)
        {
            workspaceBtn.ForeColor = Color.Black;
            calendarBtn.ForeColor = Color.DarkGray;
            pageControl.SelectTab(0);
        }

        private void calendarBtn_Click_1(object sender, EventArgs e)
        {
            calendarBtn.ForeColor = Color.Black;
            workspaceBtn.ForeColor = Color.DarkGray;
            pageControl.SelectTab(1);
        }
    }
}
