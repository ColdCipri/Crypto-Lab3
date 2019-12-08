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
        Dictionary<char, int> alphabet = new Dictionary<char, int>(27) { };
        public Form1()
        {
            InitializeComponent();
            generateDictionary();
        }

        private void generateDictionary()
        {
            alphabet.Add('_', 0);
            alphabet.Add('A', 1);
            alphabet.Add('B', 2);
            alphabet.Add('C', 3);
            alphabet.Add('D', 4);
            alphabet.Add('E', 5);
            alphabet.Add('F', 6);
            alphabet.Add('G', 7);
            alphabet.Add('H', 8);
            alphabet.Add('I', 9);
            alphabet.Add('J', 10);
            alphabet.Add('K', 11);
            alphabet.Add('L', 12);
            alphabet.Add('M', 13);
            alphabet.Add('N', 14);
            alphabet.Add('O', 15);
            alphabet.Add('P', 16);
            alphabet.Add('Q', 17);
            alphabet.Add('R', 18);
            alphabet.Add('S', 19);
            alphabet.Add('T', 20);
            alphabet.Add('U', 21);
            alphabet.Add('V', 22);
            alphabet.Add('W', 23);
            alphabet.Add('X', 24);
            alphabet.Add('Y', 25);
            alphabet.Add('Z', 26);
        }
    }
}
