namespace WinFormsArreglosMultidimensionales_2027_I
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider;
        Multidimentional m1;
        Multidimentional m2;
        Multidimentional m3;
        bool changeMatrix = false;

        public Form1()
        {
             errorProvider= new ErrorProvider();
            InitializeComponent();
        }

        private void txtbDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (!changeMatrix)
                    {
                        if(  txtbDisplay.Text == ""  )
                        {
                            string error = "Debes de ingresar una matriz";
                            throw new ApplicationException(error);
                        }
                        m1 = Multidimentional.Read(txtbDisplay.Text);
                        lbMatrix1.Text = m1.ToString();
                        changeMatrix = true;

                    }
                    else
                    {
                        if (txtbDisplay.Text == "")
                        {
                            string error = "Debes de ingresar una matriz";
                            throw new ApplicationException(error);
                        }

                        m2 = Multidimentional.Read(txtbDisplay.Text);
                        lbMatrix2.Text = m2.ToString();
                        changeMatrix = false;
                    }

                    this.errorProvider.Clear();
                }
                catch (ApplicationException ex)
                {
                    this.errorProvider.SetError(txtbDisplay, ex.Message);
                }

                catch (FormatException ex ) {
                    MessageBox.Show( "El formato de entrada es incorrecto " );
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("¡Ups!, hay un error " + ex.Message);
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
