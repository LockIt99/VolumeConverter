using System;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class volConverter : Form
    {
        public volConverter()
        {
            InitializeComponent();
            txtLitre.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCl.Text= string.Empty;
            txtLitre.Text= string.Empty;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            float centiLitre = 0F;
            try
            {
                 centiLitre = (float) Convert.ToDouble(txtCl.Text);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Invalid value: " + ex.Message);
            }
            float litre = centiLitre / 100;
            txtLitre.Text=  litre.ToString();
        }
    }
}