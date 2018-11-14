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
            this.nuN = new System.Windows.Forms.NumericUpDown();
            this.nuM = new System.Windows.Forms.NumericUpDown();
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
            this.rbEps = new System.Windows.Forms.RadioButton();
            this.rbIter = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзФайлаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuIters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Info;
            this.btnStart.Location = new System.Drawing.Point(828, 257);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Вычислить";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nuN
            // 
            this.nuN.Location = new System.Drawing.Point(28, 66);
            this.nuN.Margin = new System.Windows.Forms.Padding(4);
            this.nuN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuN.Name = "nuN";
            this.nuN.Size = new System.Drawing.Size(160, 22);
            this.nuN.TabIndex = 1;
            this.nuN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuN.ValueChanged += new System.EventHandler(this.nuM_ValueChanged);
            // 
            // nuM
            // 
            this.nuM.Location = new System.Drawing.Point(28, 128);
            this.nuM.Margin = new System.Windows.Forms.Padding(4);
            this.nuM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuM.Name = "nuM";
            this.nuM.Size = new System.Drawing.Size(160, 22);
            this.nuM.TabIndex = 2;
            this.nuM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuM.ValueChanged += new System.EventHandler(this.nuN_ValueChanged);
            // 
            // nuIters
            // 
            this.nuIters.Location = new System.Drawing.Point(255, 37);
            this.nuIters.Margin = new System.Windows.Forms.Padding(4);
            this.nuIters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIters.Name = "nuIters";
            this.nuIters.Size = new System.Drawing.Size(160, 22);
            this.nuIters.TabIndex = 3;
            this.nuIters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuIters.ValueChanged += new System.EventHandler(this.nuIters_ValueChanged);
            // 
            // tbEps
            // 
            this.tbEps.Location = new System.Drawing.Point(255, 97);
            this.tbEps.Margin = new System.Windows.Forms.Padding(4);
            this.tbEps.Name = "tbEps";
            this.tbEps.Size = new System.Drawing.Size(132, 22);
            this.tbEps.TabIndex = 4;
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.ColumnHeadersVisible = false;
            this.dgvMatrix.Location = new System.Drawing.Point(527, 92);
            this.dgvMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowHeadersVisible = false;
            this.dgvMatrix.Size = new System.Drawing.Size(285, 234);
            this.dgvMatrix.TabIndex = 5;
            this.dgvMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellContentClick);
            this.dgvMatrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrix_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стратегий 1-го игрока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стратегий 2-го игрока";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите точность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Платежная матрица";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(204, 523);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(873, 185);
            this.dgvResult.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 502);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Результат";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.rbEps);
            this.panel1.Controls.Add(this.rbIter);
            this.panel1.Controls.Add(this.tbEps);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nuIters);
            this.panel1.Location = new System.Drawing.Point(18, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 131);
            this.panel1.TabIndex = 13;
            // 
            // rbEps
            // 
            this.rbEps.AutoSize = true;
            this.rbEps.Location = new System.Drawing.Point(20, 62);
            this.rbEps.Margin = new System.Windows.Forms.Padding(4);
            this.rbEps.Name = "rbEps";
            this.rbEps.Size = new System.Drawing.Size(158, 21);
            this.rbEps.TabIndex = 1;
            this.rbEps.Text = "Заданная точность";
            this.rbEps.UseVisualStyleBackColor = true;
            // 
            // rbIter
            // 
            this.rbIter.AutoSize = true;
            this.rbIter.Checked = true;
            this.rbIter.Location = new System.Drawing.Point(15, 22);
            this.rbIter.Margin = new System.Windows.Forms.Padding(4);
            this.rbIter.Name = "rbIter";
            this.rbIter.Size = new System.Drawing.Size(183, 21);
            this.rbIter.TabIndex = 0;
            this.rbIter.TabStop = true;
            this.rbIter.Text = "Огран кол-во итераций";
            this.rbIter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(828, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 74);
            this.button1.TabIndex = 16;
            this.button1.Text = "Проверить наличие седловой точки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(221, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(766, 69);
            this.label7.TabIndex = 17;
            this.label7.Text = "Метод Брауна Робинсона";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nuM);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nuN);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvMatrix);
            this.panel2.Location = new System.Drawing.Point(29, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 368);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Выбирете условие прекращения иттераций";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Введите количество ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВФайлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 52);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.сохранитьВФайлToolStripMenuItem1,
            this.загрузитьИзФайлаToolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip3.TabIndex = 21;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // сохранитьВФайлToolStripMenuItem1
            // 
            this.сохранитьВФайлToolStripMenuItem1.Name = "сохранитьВФайлToolStripMenuItem1";
            this.сохранитьВФайлToolStripMenuItem1.Size = new System.Drawing.Size(146, 24);
            this.сохранитьВФайлToolStripMenuItem1.Text = "Сохранить в файл";
            this.сохранитьВФайлToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьВФайлToolStripMenuItem1_Click);
            // 
            // загрузитьИзФайлаToolStripMenuItem1
            // 
            this.загрузитьИзФайлаToolStripMenuItem1.Name = "загрузитьИзФайлаToolStripMenuItem1";
            this.загрузитьИзФайлаToolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.загрузитьИзФайлаToolStripMenuItem1.Text = "Загрузить из файла";
            this.загрузитьИзФайлаToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьИзФайлаToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3 Метод Брауна Робинсона ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuIters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nuN;
        private System.Windows.Forms.NumericUpDown nuM;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзФайлаToolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

