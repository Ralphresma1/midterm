namespace CustomerPreview.cs
{
    public partial class Customer_Preview : Form
    {
        public Customer_Preview()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";

            if (rdbmale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }


            if (cbreading.Checked)
            {
                Hobby = "Reading";
            }
            else
            {
                Hobby = "Eating";
            }

            if (rdbmarried.Checked)
            {
                Status = "Married";
            }
            else
            {
                Status = "Single";
            }

            CustomerPreview c = new CustomerPreview();
            c.SetValues(txtcustomername.Text, comboBox1.Text, Gender, Hobby, Status);
            c.Show();
            this.Hide();




        }
    }
}