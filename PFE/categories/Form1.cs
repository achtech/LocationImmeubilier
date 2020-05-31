using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.entities;

namespace WindowsFormsApp2.categories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GlocationAppartementEntities1 db ;
        public void remplirCombo()
        {
            comboBox1.DataSource = db.Categories.Select(p => new { ID_categorie = p.id_categories, libelle_ategorie = p.libelle }).ToList();
            comboBox1.DisplayMember = "libelle_ategorie";
            comboBox1.ValueMember = "ID_categorie";
        }

        private void addButtom_Click(object sender, EventArgs e)
        {
 
            String libCat = libelleCategorie.Text;
            int cat = db.Categories.Where(c => c.libelle == libCat).Count();
            if(cat == 0)
            {
                Category categorie = new Category();
                categorie.libelle = libelleCategorie.Text;
                db.Categories.Add(categorie);
                db.SaveChanges();
                MessageBox.Show("Categorie ajouter avec succes");
            }
            else
            {
                MessageBox.Show("Categorie existe deja");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new GlocationAppartementEntities1();
            remplirCombo();
            // display info categorie in dataGrid
            dataGridViewCat.DataSource = db.Categories.Select(p => new { ID_categorie = p.id_categories, libelle_ategorie = p.libelle }).ToList();
        }

        private void annuletBtm_Click(object sender, EventArgs e)
        {
            try
            {
                String libCat = libelleCategorie.Text;
                Category cat = db.Categories.Where(c => c.libelle == libCat).First();
                db.Categories.Remove(cat);
                db.SaveChanges();
                MessageBox.Show("Categorie supprimer avec succes");

            }
            catch
            {
                MessageBox.Show("Categorie existe pas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCat = int.Parse(comboBox1.SelectedValue.ToString());
            dataGridViewCat.DataSource = db.Categories.Where(c => c.id_categories == idCat).Select(p => new { ID_categorie = p.id_categories, libelle_ategorie = p.libelle }).ToList();

        }
    }
}
