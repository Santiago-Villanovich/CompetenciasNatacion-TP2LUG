using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class txtDNI : UserControl
    {
        public txtDNI()
        {
            InitializeComponent();
        }

        public void LimpiarTxt()
        {
            this.textBox1.Text = null;
        }
        public void Escribir(string str)
        {
            textBox1.Text = str;
        }
        public string retornarDNI()
        {
            return textBox1.Text;
        }

        public Boolean VerificarDNI()
        {
            Regex re = new Regex(@"^([0-9]{1,2})\.([0-9]{3})\.([0-9]{3})$"); 

            if(re.IsMatch(this.textBox1.Text.Trim()))
            { 
                return true;
            }
            else 
            { 
                return false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
