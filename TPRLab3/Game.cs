using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRLab3
{
    class Game
    {
        Matrix PayMatrix;
        //  int iterCount;
        public int[] ik, jk;
        public Matrix gk, hk;
        public double[] Mk, Vk;
        // double eps;
        public Game()
        {

            PayMatrix = new Matrix();
        }
        public Game(Matrix payMat)
        {
            //iterCount = iter;
            PayMatrix = payMat;
        }
        public void input(Matrix payMat)
        {
            PayMatrix = payMat;
        }

        (double minimax, int pos) MiniMax(Matrix paymat)
        {
            double[] maxs = new double[paymat.m];
            for (int j = 0; j < paymat.m; j++)
            {
                maxs[j] = paymat[0, j];
                for (int i = 1; i < paymat.n; i++)
                    if (paymat[i, j] > maxs[j])
                        maxs[j] = paymat[i, j];
            }
            double res = maxs.Min();
            return (res, Array.IndexOf(maxs, res));
        }
        (double maximin, int pos) MaxiMin(Matrix paymat)
        {
            double[] mins = new double[paymat.m];
            for (int j = 0; j < paymat.m; j++)
            {
                mins[j] = paymat[0, j];
                for (int i = 1; i < paymat.n; i++)
                    if (paymat[i, j] < mins[j])
                        mins[j] = paymat[i, j];
            }
            double res = mins.Max();
            return (res, Array.IndexOf(mins, res));
        }
        public void Calculate(int iters)
        {
            int iterCount = iters;

            ik = new int[iterCount];
            jk = new int[iterCount];
            gk = new Matrix(iterCount, PayMatrix.m);
            hk = new Matrix(iterCount, PayMatrix.n);

            Mk = new double[iterCount];
            Vk = new double[iterCount];

            int i, j;
            double M, V;
            //// стратегии на 1 шаге

            i = 0; j = 0;

            ik[0] = i;
            jk[0] = j;

            for (int k = 0; k < PayMatrix.m; k++)
                gk[0, k] = PayMatrix[k, i];

            for (int k = 0; k < PayMatrix.n; k++)
                hk[0, k] = PayMatrix[j, k];

            M = gk[0, 0];
            for (int k = 1; k < gk.m; k++)
                if (gk[0, k] < M)
                {
                    M = gk[0, k];
                    i = k;
                }

            V = hk[0, 0];
            for (int k = 1; k < gk.m; k++)
                if (hk[0, k] > V)
                {
                    V = hk[0, k];
                    j = k;
                }

            Mk[0] = M;
            Vk[0] = V;
            ik[1] = i;
            jk[1] = j;
            for (int iter = 1; iter < iterCount; iter++)
            {

                for (int k = 0; k < PayMatrix.m; k++)
                    gk[iter, k] = gk[iter - 1, k] + PayMatrix[k, j];



                for (int k = 0; k < hk.m; k++)
                    hk[iter, k] = hk[iter - 1, k] + PayMatrix[i, k];


                i = 0; M = gk[iter, 0];
                for (int k = 1; k < gk.m; k++)
                    if (gk[iter, k] < M)
                    {
                        M = gk[iter, k];
                        i = k;
                    }
                M /= (iter + 1);

                V = hk[iter, 0];
                j = 0;
                for (int k = 1; k < gk.m; k++)
                    if (hk[iter, k] > V)
                    {
                        V = hk[iter, k];
                        j = k;
                    }
                V /= (iter + 1);

                if (iter != iterCount - 1)
                {
                    ik[iter + 1] = i;
                    jk[iter + 1] = j;
                }


                Vk[iter] = V;
                Mk[iter] = M;
            }
        }


        public void Calculate(double eps)
        {
            //this.eps = eps;

            var ik = new List<int>();//[iterCount];
            var jk = new List<int>();//[iterCount];
            var gk = new List<List<double>>();// Matrix(iterCount, PayMatrix.m);
            var hk = new List<List<double>>();//new Matrix(iterCount, PayMatrix.n);

            var Mk = new List<double>();//[iterCount];
            var Vk = new List<double>();//double[iterCount];

            int i, j;
            double M, V;
            //// стратегии на 1 шаге

            i = 0; j = 0;

            ik.Add(i);
            jk.Add(j);
            gk.Add(new List<double>());
            for (int k = 0; k < PayMatrix.m; k++)
                gk[0].Add(PayMatrix[k, i]);

            hk.Add(new List<double>());
            for (int k = 0; k < PayMatrix.n; k++)
                hk[0].Add(PayMatrix[j, k]);

            M = gk[0].Min();
            i = gk[0].IndexOf(M);

            V = hk[0].Max();
            j = hk[0].IndexOf(V);

            Mk.Add(M);
            Vk.Add(V);
            ik.Add(i);
            jk.Add(j);
            int iter = 1;
            while (Math.Abs(V - M) > eps)
            {

                gk.Add(new List<double>());
                for (int k = 0; k < PayMatrix.m; k++)
                    gk[iter].Add(gk[iter - 1][k] + PayMatrix[k, j]);


               hk.Add(new List<double>());
                for (int k = 0; k < hk[iter - 1].Count; k++)
                    hk[iter].Add(hk[iter - 1][k] + PayMatrix[i, k]);


                M = gk[0].Min();
                i = gk[0].IndexOf(M);

                V = hk[0].Max();
                j = hk[0].IndexOf(V);

                M /= (iter + 1);
                V /= (iter + 1);
                ik.Add(i);
                jk.Add(j);

                Vk.Add(V);
                Mk.Add(M);
                iter++;
            }

            this.Mk = Mk.ToArray();
            this.Vk = Vk.ToArray();

            this.jk = jk.ToArray();
            this.ik = ik.ToArray();

            this.gk = Matrix.FromList(gk);
            this.hk = Matrix.FromList(hk);


        }
    }
}
