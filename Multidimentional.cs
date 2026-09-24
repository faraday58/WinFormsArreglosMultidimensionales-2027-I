
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
            string[] columns = rows[0].Split(','); //1 2 3

            Multidimentional m1 = new Multidimentional(rows.Length,columns.Length );
            for(int i = 0; i < m1.M; i++)
            {
                columns = rows[i].Split(',');
                for (int j= 0; j < m1.N; j++)
                {
                    m1.A[i, j] = float.Parse(columns[j]);
                }
            }

            return m1;
        }

        public static Multidimentional operator +(Multidimentional m1, Multidimentional m2   )
        {
            Multidimentional m3 = new Multidimentional(m1.M,m1.N);

            for(int  i = 0; i < m1.M; i++)
            {
                for(int j=0; j< m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }
            return m3;
        }

        public override string ToString()
        {
            //1 2 3
            //4 5 6

            string A = "";
            for (int i = 0; i < M; i++)
            {
                for (int j= 0; j< N; j++)
                {
                    A = String.Concat(A," ", this.A[i,j]);
                }
                A = String.Concat(A, "\n");
             }


            return A;
        }
    }
}
