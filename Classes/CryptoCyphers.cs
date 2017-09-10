using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Crypto
{
    public partial class CryptoCyphers : Form
    {
        public CryptoCyphers()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            switch (CyphersBox.SelectedIndex)
            {
                case 0:
                    Cyphers caesar = new Cyphers();
                    //int[] array = caesar.Test(Message.Text);
                    //for (int i = 0; i < array.Length; i++)
                    //{
                    //    Encrypted.Text += array[i].ToString();
                    //}
                    Encrypted.Text = caesar.EncryptCaesar(Message.Text, Key.Text);
                    break;
                case 1:
                    Cyphers vizhener = new Cyphers();
                    break;
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            switch (CyphersBox.SelectedIndex)
            {
                case 0:
                    Cyphers caesar = new Cyphers();
                    Decrypted.Text = caesar.DecryptCaesar(Encrypted.Text, Key.Text);
                    break;
                case 1:
                    Cyphers vizhener = new Cyphers();
                    break;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Message.Clear();
            Key.Clear();
            Encrypted.Clear();
            Decrypted.Clear();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypted_TextChanged(object sender, EventArgs e)
        {

        }

        private void CyphersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            Decrypted.Clear();
            Decode caesars = new Decode();
            Decrypted.Text = caesars.DecodeCaesar(Encrypted.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string keyfile = "keyfile.txt";
            using (StreamWriter writer = new StreamWriter(keyfile))
            {
                writer.WriteLine(Key.Text);
                writer.Close();
            }
        }
    }
}
