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

        private void btn1_Click(object sender, EventArgs e)
        {
            // verifica se existe um item selecionado no combo
            if (cboEstados.SelectedIndex != -1)
            {
                String est = cboEstados.SelectedItem.ToString();
                if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
                {
                    // adiciona no sudeste
                    cboSudeste.Items.Add(cboEstados.SelectedItem.ToString());
                    // remover do estado
                    cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                    // colocar o foco
                    cboEstados.Focus();
                }

                else if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
                {
                    // adiciona no Norte
                    cboNorte.Items.Add(cboEstados.SelectedItem.ToString());
                    // remover do estado
                    cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                    // colocar o foco
                    cboEstados.Focus();
                }

                else if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" 
                    | est == "PI" | est == "RN" | est == "SE")
                {
                    // adiciona no Nordeste
                    cboNordeste.Items.Add(cboEstados.SelectedItem.ToString());
                    // remover do estado
                    cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                    // colocar o foco
                    cboEstados.Focus();
                }

                else if (est == "PR" | est == "RS" | est == "SC" )
                {
                    // adiciona no Sul
                    cboSul.Items.Add(cboEstados.SelectedItem.ToString());
                    // remover do estado
                    cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                    // colocar o foco
                    cboEstados.Focus();
                }

                else if (est == "GO" | est == "MT" | est == "MT" | est == "MS" | est == "DF")
                {
                    // adiciona no Centro-Oeste
                    cboCentro.Items.Add(cboEstados.SelectedItem.ToString());
                    // remover do estado
                    cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                    // colocar o foco
                    cboEstados.Focus();
                }


                //Exibir a qtd de itens dentro de cada comboBox
                lblQtdNorte.Text = cboNorte.Items.Count.ToString();
                lblQtdNordeste.Text = cboNordeste.Items.Count.ToString();
                lblQtdCentro.Text = cboCentro.Items.Count.ToString();
                lblQtdSudeste.Text = cboSudeste.Items.Count.ToString();
                lblQtdSul.Text = cboSul.Items.Count.ToString() ;
                // deixar em ordem alfabética
                cboEstados.Sorted = true;
                cboSudeste.Sorted = true;
                cboNorte.Sorted = true;
                cboNordeste.Sorted = true;
                cboSul.Sorted = true;
                cboCentro.Sorted = true;
                // faz a sigla sumir só na tela
                cboEstados.ResetText();


            }



        }

        private void btnNorte_Click(object sender, EventArgs e)
        {

                string est = cboNorte.SelectedItem.ToString();
                if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
                {
                    // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                    cboEstados.Items.Add(cboNorte.SelectedItem.ToString());
                    cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                    cboNorte.ResetText();
                    lblQtdEstados.Text = cboEstados.Items.Count.ToString();
                    lblQtdNorte.Text = cboNorte.Items.Count.ToString();
                    cboEstados.Sorted = true;

                }
            }


        private void btnNordeste_Click(object sender, EventArgs e)
        {
            string est = cboNordeste.SelectedItem.ToString();
            if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboNordeste.SelectedItem.ToString());
                cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());
                cboNordeste.ResetText();
                lblQtdEstados.Text = cboEstados.Items.Count.ToString();
                lblQtdNordeste.Text = cboNordeste.Items.Count.ToString();
                cboEstados.Sorted = true;

            }
        }

        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            string est = cboCentro.SelectedItem.ToString();
            if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboCentro.SelectedItem.ToString());
                cboCentro.Items.Remove(cboCentro.SelectedItem.ToString());
                cboCentro.ResetText();
                lblQtdEstados.Text = cboEstados.Items.Count.ToString();
                lblQtdCentro.Text = cboCentro.Items.Count.ToString();
                cboEstados.Sorted = true;
            }
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            string est = cboSudeste.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboSudeste.SelectedItem.ToString());
                cboSudeste.Items.Remove(cboSudeste.SelectedItem.ToString());
                cboSudeste.ResetText();
                lblQtdEstados.Text = cboEstados.Items.Count.ToString();
                lblQtdSudeste.Text = cboSudeste.Items.Count.ToString();
                cboEstados.Sorted = true;
            }
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            if (est == "SC" | est == "RS" | est == "PR")
            {
                // adiciona no estado, remove do norte, tira o texto só da tela, atualiza o contador, deixa em ordem alfabética e o botão não vai aparecer depois para não dar ruim
                cboEstados.Items.Add(cboSul.SelectedItem.ToString());
                cboSul.Items.Remove(cboSul.SelectedItem.ToString());
                cboSul.ResetText();
                lblQtdEstados.Text = cboEstados.Items.Count.ToString();
                lblQtdSul.Text = cboSul.Items.Count.ToString();
                cboEstados.Sorted = true;
            }
        }
    }
}
