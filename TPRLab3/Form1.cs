using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                Matrix mat = new Matrix((int)nuN.Value, (int)nuM.Value);
                for (int i = 0; i < mat.n; i++)
                    for (int j = 0; j < mat.m; j++)
                        mat[i, j] = double.Parse(dgvMatrix[j, i].Value.ToString());

                game.input(mat);

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
            dgvResult.Rows.Clear();
            dgvResult.Columns.Clear();

            dgvResult.Columns.Add("k", "k");
            dgvResult.Columns.Add("jk", "jk");

            for (int i = 0; i < game.gk.m; i++)
                dgvResult.Columns.Add("gk" + (i + 1), "gk" + (i + 1));

            dgvResult.Columns.Add("Mk", "Mk");
            dgvResult.Columns.Add("Vk", "Vk");

            for (int i = 0; i < game.hk.m; i++)
                dgvResult.Columns.Add("hk" + (i + 1), "hk" + (i + 1));

            dgvResult.Columns.Add("ik", "ik");


            for (int i = 0; i < game.Mk.Length; i++)
            {
                dgvResult.Rows.Add();

                dgvResult[0, i].Value = i + 1;
                dgvResult[1, i].Value = game.jk[i] + 1;
                dgvResult["Mk", i].Value = game.Mk[i];
                dgvResult["Vk", i].Value = game.Vk[i];
                dgvResult["ik", i].Value = game.ik[i] + 1;

                for (int j = 0; j < game.gk.m; j++)
                    dgvResult["gk" + (j + 1), i].Value = game.gk[i, j];

                for (int j = 0; j < game.hk.m; j++)
                    dgvResult["hk" + (j + 1), i].Value = game.hk[i, j];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            dgvMatrix.ColumnCount = dgvMatrix.RowCount = 1;
            dgvMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void nuM_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.RowCount = (int)nuM.Value;
        }

        private void nuN_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.ColumnCount = (int)nuN.Value;
        }
    }
}
