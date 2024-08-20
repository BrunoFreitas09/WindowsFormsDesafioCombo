using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDesafioCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verifica se existe um item selecionado no combo 
            if (cboEstados.SelectedIndex != -1)
            {
                lblQtdEstados.Text = cboEstados.Items.Count.ToString();
            }
        }
    }
}
