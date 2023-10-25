using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDeGestionTaches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }











        List<string> tache = new List<string>();
     

        private void button1_Click(object sender, EventArgs e)
        {
            string tacheAjouter = textBox1.Text;
            tache.Add(tacheAjouter);
            MettreAJourListBox();
        }

        private void MettreAJourListBox()
        {

             listBox1.Items.Clear();

            foreach (string information in tache)
            {
                listBox1.Items.Add(information);
            }
        }























            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texteARechercher = textBox1.Text;
            if (tache.Contains(texteARechercher))
            {
           
                listBox2.Items.Add(texteARechercher);

                
                tache.Remove(texteARechercher);

              
                MettreAJourListBox();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string texteASupprimer = textBox1.Text;
            if (tache.Contains(texteASupprimer))
            {
                tache.Remove(texteASupprimer);
                MettreAJourListBox();
            }

            }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
