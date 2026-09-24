namespace WinFormsArreglosMultidimensionales_2027_I
{
    public partial class Form1 : Form
    {
        Multidimentional m1;
        Multidimentional m2;
        Multidimentional m3;
        bool changeMatrix = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!changeMatrix)
                {
                    m1 = Multidimentional.Read(txtbDisplay.Text);
                    lbMatrix1.Text = m1.ToString();
                    changeMatrix = true;
                }
                else
                {
                    m2 = Multidimentional.Read(txtbDisplay.Text);
                    lbMatrix2.Text = m2.ToString();
                    changeMatrix = false;
                }


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m3 = m1 + m2;
            lbResult.Text = m3.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (rdbDeg.Checked)
            {
                lbResult.Text = "Seno de Result en Sexagesimal: ";
            }else if (rdbRad.Checked)
            {
                lbResult.Text = "Seno de Result en Radianes: ";
            }

        }
    }
}
