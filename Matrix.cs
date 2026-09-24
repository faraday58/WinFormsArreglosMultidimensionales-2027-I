

namespace WinFormsArreglosMultidimensionales_2027_I
{
    internal class Matrix
    {
        #region Atributos
        private int m;
        private int n;
        #endregion


        #region Propiedades 

        public int M { 
            get => m;
            set
            { 
                if (value <= 0)
                {
                    m = 2;
                }
                else
                {
                    m = value;
                }
            } 
        }
        public int N { 
            get => n;

            set
            {
                if (value <= 0)
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
            }
        }
    }
        #endregion
}
