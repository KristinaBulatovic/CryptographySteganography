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
    public partial class CrypSteg : Form
    {
        string url = "";
        Cryptography crypt;

        public CrypSteg()
        {
            InitializeComponent();
            crypt = new Cryptography();
        }

        public string OpenPicture()
        {
            string url = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                url = ofd.FileName;
                return url;
            }
            return url;
        }

        public void SavePicture(Bitmap img)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPG|*.jpg|PNG|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string url = sfd.FileName;
                img.Save(url);
            }

        }

        private void ExitApp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (url != "")
            {
                //string key = crypt.Key(textBox1.Text);
                Bitmap img = new Bitmap(pb_image.Image);

                string text;
                string key;
                if (cb_algorithm.SelectedIndex == 1)
                {
                    text = crypt.Encrypt_TriplDES(tb_password.Text, tb_text.Text);
                }
                else if (cb_algorithm.SelectedIndex == 2)
                {
                    text = crypt.DES_Encrypt(tb_text.Text);
                }
                else if (cb_algorithm.SelectedIndex == 3)
                {
                    key = crypt.Key(tb_password.Text);
                    text = crypt.Encrypt_AES(key, tb_text.Text);
                }
                else text = tb_text.Text;

                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);
                        //RGB
                        if (i < 1 && j < text.Length)
                        {
                            //Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.R);
                            //Console.WriteLine("G[" + i + "][" + j + "] : " + pixel.G);
                            //Console.WriteLine("B[" + i + "][" + j + "] : " + pixel.B);
                            char letter = Convert.ToChar(text.Substring(j, 1));
                            int value = Convert.ToInt32(letter);
                            //Console.WriteLine("Letter: " + letter + "\n Value: " + value);
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                        }
                        if (i == img.Width - 1 && j == img.Height - 1)
                        {
                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, text.Length));
                        }
                    }
                }
                SavePicture(img);
            }
            else MessageBox.Show("Load the picture!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            if (url != "")
            {
                Bitmap img = new Bitmap(pb_image.Image);
                Color lpixel = img.GetPixel(img.Width - 1, img.Height - 1);
                int messlen = lpixel.B;
                string message = "";

                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        Color pixel = img.GetPixel(i, j);
                        //RGB
                        if (i < 1 && j < messlen)
                        {
                            //Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.R);
                            //Console.WriteLine("G[" + i + "][" + j + "] : " + pixel.G);
                            //Console.WriteLine("B[" + i + "][" + j + "] : " + pixel.B);
                            int value = pixel.B;
                            //Console.WriteLine("Value: " + value);
                            char c = Convert.ToChar(value);

                            //string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                            string letter = c.ToString();

                            message += letter;

                        }
                    }
                }
                //string key = spc.Key(textBox1.Text);
                string text;
                string key;
                if (cb_algorithm.SelectedIndex == 1)
                {
                    text = crypt.Decrypt_TriplDES(tb_password.Text, message);
                }
                else if (cb_algorithm.SelectedIndex == 2)
                {
                    text = crypt.DES_Decrypt(message);
                }
                else if (cb_algorithm.SelectedIndex == 3)
                {
                    key = crypt.Key(tb_password.Text);
                    text = crypt.Decrypt_AES(key, message);
                }
                else text = message;

                if (text != "")
                {
                    tb_text.Text = text;
                    //MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Enter the correct algorithm and key!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Load the picture!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_algorithm.SelectedIndex = 0;
            tb_password.Text = "";
            tb_text.Text = "";
            pb_image.ImageLocation = "";
            url = "";
        }

        private void pb_image_Click(object sender, EventArgs e)
        {
            url = OpenPicture();
            if (url != "")
            {
                pb_image.ImageLocation = url;
            }
        }

        private void CrypSteg_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void cb_algorithm_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void tb_text_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void btn_encrypt_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void btn_decrypt_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void btn_clear_KeyDown(object sender, KeyEventArgs e)
        {
            ExitApp(e);
        }

        private void cb_algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_algorithm.SelectedIndex == 0 || cb_algorithm.SelectedIndex == 2)
            {
                tb_password.Enabled = false;
            }
            else tb_password.Enabled = true;
        }
    }
}
