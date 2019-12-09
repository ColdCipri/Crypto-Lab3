using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Criptography
{
    public partial class Form1 : Form
    {
        int p = 43, q = 47, n, elem = 5, euler, k = 2, toDecrypt, euclidian = 0;    //Public key = kE(n,elem)
        String plaintext, cipher, toEncrypt;                                        //Private key = kD = elem ^ (-1) mod euler
        public Form1()
        {
            InitializeComponent();
            Utils.generateDictionary();
        }

        private void button_switch_Click(object sender, EventArgs e)
        {
            if (textBox_plaintext.Enabled)
            {
                textBox_cipher.Enabled = true;
                textBox_plaintext.Enabled = false;
                textBox_cipher.Text = "";
            }
            else
            {
                textBox_cipher.Enabled = false;
                textBox_plaintext.Enabled = true;
                textBox_plaintext.Text = "";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            p = Convert.ToInt32(numericUpDown_p.Value);
            q = Convert.ToInt32(numericUpDown_q.Value);
            if (!Utils.isPrime(p))
            {
                MessageBox.Show("P is not prime!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Utils.isPrime(q))
            {
                MessageBox.Show("Q is not prime!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_plaintext.Text.Length == 0 && textBox_plaintext.Enabled)
            {
                MessageBox.Show("The plaintext is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_cipher.Text.Length == 0 && textBox_cipher.Enabled)
            {
                MessageBox.Show("The cipher is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_plaintext.Enabled)
            {
                plaintext = textBox_plaintext.Text.ToString();
                n = p * q;
                euler = Utils.eulerFunction(p, q);

                //If the default e (elem) is not good this if generates another e
                if (!(((elem > 1) && (elem < euler)) && (Utils.gcd(elem, euler) == 1)))
                    elem = Utils.generateE(euler);

                label_result.Text = "";

                int i = 0;
                while (plaintext.Length > 0)
                {
                    //If we have the length even (because k = 2) we use those 2 chars to encrypt them and append them to result label.
                    if (i % k == 1 && plaintext.Length != 1)
                    {
                        toEncrypt += plaintext[i];
                        plaintext = plaintext.Substring(i + 1);
                        label_result.Text += Utils.binaryPow(Utils.convertToNumbers(toEncrypt), elem, n) + " ";
                        toEncrypt = "";
                        i = -1;
                    }
                    //If we use a plain text of length odd then there is in the last pair of chars only one char so we need to take care of this case.
                    else if (i % k == 1 && plaintext.Length == 1)
                    {
                        plaintext = "";
                        label_result.Text += Utils.binaryPow(Utils.convertToNumbers(toEncrypt), elem, n) + " ";
                        toEncrypt = "";
                        i = -1;
                    }
                    //If the iterator is even we continue
                    else
                    {
                        toEncrypt += plaintext[i];
                    }

                    i++;
                }

                //remove the last space if it exists
                String removeSpace = label_result.Text.ToString();
                if (removeSpace[removeSpace.Length - 1] == ' ')
                {
                    removeSpace = removeSpace.Substring(0, removeSpace.Length - 1);
                    label_result.Text = removeSpace;
                }

                //Copy the result to clipboard after it is shown
                System.Windows.Forms.Clipboard.SetText(label_result.Text);
            }
            else if (textBox_cipher.Enabled)
            {
                label_result.Text = "";

                cipher = textBox_cipher.Text.ToString() + ' ';

                //Here we get the Private key by doing elem ^ (-1) mod eular
                euclidian = Utils.euclidianAlgorithm(euler, elem);

                while (cipher.Length > 0)
                {
                    toDecrypt = Convert.ToInt32(cipher.Substring(0, cipher.IndexOf(' '))); //we use the number we got from the first post to the first occurence of a space
                    label_result.Text += Utils.convertToString(Utils.binaryPow(toDecrypt,euclidian, n)) + " "; //here we convert to string the result
                    cipher = cipher.Substring(cipher.IndexOf(' ') + 1); //and we get rid of the part we already used.
                }

                //Copy the result to clipboard after it is shown
                System.Windows.Forms.Clipboard.SetText(label_result.Text);
            }
        }
    }
}
