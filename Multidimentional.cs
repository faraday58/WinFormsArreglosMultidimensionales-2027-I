
namespace WinFormsArreglosMultidimensionales_2027_I
{
    internal class Multidimentional:Matrix
    {
        private float[,] A;

        #region Constructores
        public Multidimentional(int m,int n) : base()
        {
            M = m;
            N = n;
            A = new float[M, N];
        }
        #endregion

        public static Multidimentional Read(string A)
        {
            //1 2 3
            //4 5 6
            //Matriz ingresada por el usuario
            // 1,2,3;4,5,6
            string[] rows = A.Split(';');
            string[] columns = rows[0].Split(',');

            Multidimentional matrix = new Multidimentional(rows.Length,columns.Length );
            for(int i = 0; i < matrix.M; i++)
            {
                for(int j= 0; j < matrix.N; j++)
                {
                    matrix
                }
            }

        }

    }
}
