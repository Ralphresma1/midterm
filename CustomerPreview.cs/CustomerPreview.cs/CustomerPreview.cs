using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerPreview.cs
{
    public partial class CustomerPreview : Form
    {
        public CustomerPreview()
        {
            InitializeComponent();
        }

        public void SetValues(string name, string Country, string Gender, string Status, string Hobbies)
        {
            txtcustomername.Text = name;
            txtcountry.Text = Country;
            txtgender.Text = Gender;
            txtstatus.Text = Status;
            txthobbies.Text = Hobbies;
        }

        private void CustomerPreview_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
