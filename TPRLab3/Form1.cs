using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace TPRLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game game;



        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbIter.Checked)
                {
                    int iter = (int)nuIters.Value;
                    game.Calculate(iter);
                }
                else
                {
                    double eps = double.Parse(tbEps.Text);
                    game.Calculate(eps);
                }

                Output();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Output()
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("k");
            dt.Columns.Add("jk");

            for (int i = 0; i < game.gk.m; i++)
                dt.Columns.Add("gk" + (i + 1));

            dt.Columns.Add("Mk");
            dt.Columns.Add("Vk");

            for (int i = 0; i < game.hk.m; i++)
                dt.Columns.Add("hk" + (i + 1));

            dt.Columns.Add("ik");



            int len = dt.Columns.Count;
            object[] arr = new object[len];

            for (int i = 0; i < game.Mk.Length; i++)
            {
                int pos = 0;
                arr[pos++] = i + 1;
                arr[pos++] = game.jk[i] + 1;

                for (int j = 0; j < game.gk.m; j++)
                    arr[pos++] = game.gk[i, j];

                arr[pos++] = game.Mk[i] + 1;
                arr[pos++] = game.Vk[i] + 1;

                for (int j = 0; j < game.hk.m; j++)
                    arr[pos++] = game.hk[i, j];

                arr[pos++] = game.ik[i] + 1;
                dt.Rows.Add(arr);

            }

            dgvResult.DataSource = dt;


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            dgvMatrix.ColumnCount = dgvMatrix.RowCount = 1;
            dgvMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMatrix.AllowUserToAddRows = false;
        }

        private void nuM_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.RowCount = (int)nuN.Value;

            Input();
        }

        private void nuN_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.ColumnCount = (int)nuM.Value;
            Input();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter sw = new StreamWriter(sfd.FileName);
            if (rbIter.Checked)
            {
                sw.WriteLine("iter");
                sw.WriteLine(nuIters.Value);
            }
            else
            {
                sw.WriteLine("eps");
                sw.WriteLine(tbEps.Text);
            }
            game.Save(sw);
            sw.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(ofd.FileName);
            string s = sr.ReadLine();

            if (s == "iter")
            {
                int iters = int.Parse(sr.ReadLine());
                rbIter.Checked = true;
                nuIters.Value = iters;
            }
            else
            {
                double eps = double.Parse(sr.ReadLine());
                rbEps.Checked = true;
                tbEps.Text = eps.ToString();
            }
            game.Load(sr);
            sr.Close();

            dgvMatrix.RowCount = game.N;
            dgvMatrix.ColumnCount = game.M;

            nuM.Value = game.M;
            nuN.Value = game.N;



            for (int i = 0; i < game.N; i++)
                for (int j = 0; j < game.M; j++)
                    dgvMatrix[j, i].Value = game.PayMatrix[i, j];

        }

        void Input()
        {
            Matrix mat = new Matrix((int)nuN.Value, (int)nuM.Value);
            for (int i = 0; i < mat.n; i++)
                for (int j = 0; j < mat.m; j++)
                    if (dgvMatrix[j, i] != null && dgvMatrix[j, i].Value != null)
                    {
                        if (double.TryParse(dgvMatrix[j, i].Value.ToString(), out double d))
                            mat[i, j] = d;
                    }

            game.input(mat);
        }


        private void dgvMatrix_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Input();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.Check())
                MessageBox.Show("Есть седловая точка");
            else
                MessageBox.Show("Нет седловой точки");
        }

        private void dgvMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).ShowDialog();
            //MessageBox.Show("Данная программа разработана для оптимизации работы кадрового агентства", "О программе");
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new Form2()).ShowDialog();
        }

        private void сохранитьВФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter sw = new StreamWriter(sfd.FileName);
            if (rbIter.Checked)
            {
                sw.WriteLine("iter");
                sw.WriteLine(nuIters.Value);
            }
            else
            {
                sw.WriteLine("eps");
                sw.WriteLine(tbEps.Text);
            }
            game.Save(sw);
            sw.Close();
        }

        private void загрузитьИзФайлаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(ofd.FileName);
            string s = sr.ReadLine();
            string s2 = sr.ReadLine();

            var game = new Game();
            game.Load(sr);
            sr.Close();

            dgvMatrix.RowCount = game.N;
            dgvMatrix.ColumnCount = game.M;

            nuM.Value = game.M;
            nuN.Value = game.N;



            for (int i = 0; i < game.N; i++)
                for (int j = 0; j < game.M; j++)
                    dgvMatrix[j, i].Value = game.PayMatrix[i, j];

            if (s == "iter")
            {
                int iters = int.Parse(s2);
                rbIter.Checked = true;
                nuIters.Value = iters;
            }
            else
            {
                double eps = double.Parse(s2);
                rbEps.Checked = true;
                tbEps.Text = eps.ToString();
            }
            Input();
        }

        private void nuIters_ValueChanged(object sender, EventArgs e)
        {
            Input();
        }
    }
}
