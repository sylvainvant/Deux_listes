using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiche1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_list2.Items.AddRange(lb_liste1.Items);
            lb_liste1.Items.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("La zone de saisie est vide");
            }
            else
            {
                lb_liste1.Items.Add(textBox1.Text);
                textBox1.Text = "";	// ou tb_saisie.Clear()
                textBox1.Focus();
            }
        }

        private void tb_saissie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text =="")
            {
                MessageBox.Show("La zone de saisie est vide");
            }
            else
            {
                lb_list2.Items.Add(textBox2.Text);
                textBox2.Text = "";	// ou tb_saisie.Clear()
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lb_liste1.Text == "")
            {
                MessageBox.Show("Vous avez cliquer sur '-' sans item sélectionné dans la liste");
            }
            else
            {
                lb_liste1.Items.RemoveAt(lb_liste1.SelectedIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lb_list2.Text == "")
            {
                MessageBox.Show("Vous avez cliquer sur '-'sans item sélectionné dans la liste");
            }
            else
            {
                lb_list2.Items.RemoveAt(lb_list2.SelectedIndex);
            }
        }

        private void lb_list2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quitter l'application?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();

     
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_liste1.Items.AddRange(lb_list2.Items);
            lb_list2.Items.Clear();
        }
     




      
            
           
        
    }
}
