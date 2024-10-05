using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILEMAKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (FileStream fs = new FileStream("FILEMAKE", FileMode.Create, FileAccess.Write))
                    {
                        fs.SetLength(Convert.ToInt64(textBox1.Text));
                    }
                }
                catch
                {
                }
            });
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
