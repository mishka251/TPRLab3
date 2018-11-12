namespace TPRLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.nuM = new System.Windows.Forms.NumericUpDown();
            this.nuN = new System.Windows.Forms.NumericUpDown();
            this.nuIters = new System.Windows.Forms.NumericUpDown();
            this.tbEps = new System.Windows.Forms.TextBox();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbIter = new System.Windows.Forms.RadioButton();
            this.rbEps = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nuM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuIters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(244, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Расчитать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nuM
            // 
            this.nuM.Location = new System.Drawing.Point(43, 64);
            this.nuM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuM.Name = "nuM";
            this.nuM.Size = new System.Drawing.Size(120, 20);
            this.nuM.TabIndex = 1;
            this.nuM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuM.ValueChanged += new System.EventHandler(this.nuM_ValueChanged);
            // 
            // nuN
            // 
            this.nuN.Location = new System.Drawing.Point(199, 64);
            this.nuN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuN.Name = "nuN";
            this.nuN.Size = new System.Drawing.Size(120, 20);
            this.nuN.TabIndex = 2;
            this.nuN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuN.ValueChanged += new System.EventHandler(this.nuN_ValueChanged);
            // 
            // nuIters
            // 
            this.nuIters.Location = new System.Drawing.Point(201, 32);
            this.nuIters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIters.Name = "nuIters";
            this.nuIters.Size = new System.Drawing.Size(120, 20);
            this.nuIters.TabIndex = 3;
            this.nuIters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbEps
            // 
            this.tbEps.Location = new System.Drawing.Point(216, 88);
            this.tbEps.Name = "tbEps";
            this.tbEps.Size = new System.Drawing.Size(100, 20);
            this.tbEps.TabIndex = 4;
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            this.dgvMatrix.Location = new System.Drawing.Point(43, 185);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.Size = new System.Drawing.Size(188, 144);
            this.dgvMatrix.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стратегий 1-го игрока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стратегий 2-го игрока";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Точность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Платежная матрица";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(46, 361);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(655, 150);
            this.dgvResult.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Результат";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbEps);
            this.panel1.Controls.Add(this.rbIter);
            this.panel1.Controls.Add(this.tbEps);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nuIters);
            this.panel1.Location = new System.Drawing.Point(368, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 133);
            this.panel1.TabIndex = 13;
            // 
            // rbIter
            // 
            this.rbIter.AutoSize = true;
            this.rbIter.Checked = true;
            this.rbIter.Location = new System.Drawing.Point(11, 18);
            this.rbIter.Name = "rbIter";
            this.rbIter.Size = new System.Drawing.Size(142, 17);
            this.rbIter.TabIndex = 0;
            this.rbIter.TabStop = true;
            this.rbIter.Text = "Огран кол-во итераций";
            this.rbIter.UseVisualStyleBackColor = true;
            // 
            // rbEps
            // 
            this.rbEps.AutoSize = true;
            this.rbEps.Location = new System.Drawing.Point(15, 50);
            this.rbEps.Name = "rbEps";
            this.rbEps.Size = new System.Drawing.Size(122, 17);
            this.rbEps.TabIndex = 1;
            this.rbEps.Text = "Заданная точность";
            this.rbEps.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.nuN);
            this.Controls.Add(this.nuM);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuIters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nuM;
        private System.Windows.Forms.NumericUpDown nuN;
        private System.Windows.Forms.NumericUpDown nuIters;
        private System.Windows.Forms.TextBox tbEps;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEps;
        private System.Windows.Forms.RadioButton rbIter;
    }
}

