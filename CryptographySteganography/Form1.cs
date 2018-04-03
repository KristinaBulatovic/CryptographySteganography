using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptographySteganography
{
    public partial class Form1 : Form
    {
        CrypSteg crypSteg;
        public Form1()
        {
            InitializeComponent();
            crypSteg = new CrypSteg();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            crypSteg.ShowDialog();
        }
    }
}
