using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String displayButton = "";

            if (txtCar.Text.Equals("") == false
                && txtCategorie.Text.Equals("")==false
                && txtCar.Text.Equals("")==false
                && txtEngine.Text.Equals("") == false
                && txtTraction.Text.Equals("") == false
                &&txtPrice.Text.Equals("")==false) {

                displayButton += "Masina: " + txtCar.Text + "\n";
                displayButton += "Modelul: " + txtModel.Text + "\n";
                displayButton += "Motor: " + txtEngine.Text + "\n";
                displayButton += "Categorie: " + txtCategorie.Text + "\n";
                displayButton += "Tractiune: " + txtTraction.Text + "\n";
                displayButton += "Pret: " + txtPrice.Text + "\n";
                lblDisplay.Text = displayButton;
                lblDisplay.Visible = true;

            }
            else if (txtCar.Text.Equals("")){
                MessageBox.Show("Lipseste car");
            }else if (txtModel.Text.Equals(""))
            {
                MessageBox.Show("Introduceti modelul");
            }
            else if (txtEngine.Text.Equals(""))
            {
                MessageBox.Show("Introduceti Motorul..");
            }
            else if (txtCategorie.Text.Equals(""))
            {
                MessageBox.Show("Introduceti Categoria..");
            }
            else if (txtTraction.Text.Equals(""))
            {
                MessageBox.Show("Introduceti Tractiunea...");
            }
            else if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Introduceti Pretul...");
            }

          
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCar.Text = "";
            txtCategorie.Text = "";
            txtEngine.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtTraction.Text = "";

            lblDisplay.Visible = false;
        }

        private void txtCar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
