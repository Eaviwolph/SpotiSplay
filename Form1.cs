using System.Runtime.InteropServices;

namespace SpotiSplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
            Form frm = new Form();
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
    }
}