namespace lab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label15 = new System.Windows.Forms.Label();
            this.Sigma2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Dx2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Mx2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.radioButton_simpson = new System.Windows.Forms.RadioButton();
            this.radioButton_triangle = new System.Windows.Forms.RadioButton();
            this.radioButton_gamma = new System.Windows.Forms.RadioButton();
            this.radioButton_exp = new System.Windows.Forms.RadioButton();
            this.radioButton_gauss = new System.Windows.Forms.RadioButton();
            this.radioButton_uniform = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.La = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sigma = new System.Windows.Forms.TextBox();
            this.Dx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label445 = new System.Windows.Forms.Label();
            this.Mx = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.label3465 = new System.Windows.Forms.Label();
            this.R0 = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.label2465 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1157, 463);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "sigma  ";
            // 
            // Sigma2
            // 
            this.Sigma2.Location = new System.Drawing.Point(1224, 460);
            this.Sigma2.Name = "Sigma2";
            this.Sigma2.Size = new System.Drawing.Size(125, 22);
            this.Sigma2.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1157, 435);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Dx ";
            // 
            // Dx2
            // 
            this.Dx2.Location = new System.Drawing.Point(1224, 432);
            this.Dx2.Name = "Dx2";
            this.Dx2.Size = new System.Drawing.Size(125, 22);
            this.Dx2.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1157, 407);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Mx ";
            // 
            // Mx2
            // 
            this.Mx2.Location = new System.Drawing.Point(1224, 404);
            this.Mx2.Name = "Mx2";
            this.Mx2.Size = new System.Drawing.Size(125, 22);
            this.Mx2.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1787, 277);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 17);
            this.label21.TabIndex = 42;
            // 
            // radioButton_simpson
            // 
            this.radioButton_simpson.AutoSize = true;
            this.radioButton_simpson.Location = new System.Drawing.Point(1197, 309);
            this.radioButton_simpson.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_simpson.Name = "radioButton_simpson";
            this.radioButton_simpson.Size = new System.Drawing.Size(94, 21);
            this.radioButton_simpson.TabIndex = 48;
            this.radioButton_simpson.Text = "Симпсона";
            this.radioButton_simpson.UseVisualStyleBackColor = true;
            this.radioButton_simpson.CheckedChanged += new System.EventHandler(this.RadioButton_simpson_CheckedChanged);
            // 
            // radioButton_triangle
            // 
            this.radioButton_triangle.AutoSize = true;
            this.radioButton_triangle.Location = new System.Drawing.Point(1197, 281);
            this.radioButton_triangle.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_triangle.Name = "radioButton_triangle";
            this.radioButton_triangle.Size = new System.Drawing.Size(113, 21);
            this.radioButton_triangle.TabIndex = 47;
            this.radioButton_triangle.Text = "Треугольное";
            this.radioButton_triangle.UseVisualStyleBackColor = true;
            this.radioButton_triangle.CheckedChanged += new System.EventHandler(this.RadioButton_triangle_CheckedChanged);
            // 
            // radioButton_gamma
            // 
            this.radioButton_gamma.AutoSize = true;
            this.radioButton_gamma.Location = new System.Drawing.Point(1197, 253);
            this.radioButton_gamma.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_gamma.Name = "radioButton_gamma";
            this.radioButton_gamma.Size = new System.Drawing.Size(71, 21);
            this.radioButton_gamma.TabIndex = 46;
            this.radioButton_gamma.Text = "Гамма";
            this.radioButton_gamma.UseVisualStyleBackColor = true;
            this.radioButton_gamma.CheckedChanged += new System.EventHandler(this.RadioButton_gamma_CheckedChanged);
            // 
            // radioButton_exp
            // 
            this.radioButton_exp.AutoSize = true;
            this.radioButton_exp.Location = new System.Drawing.Point(1197, 226);
            this.radioButton_exp.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_exp.Name = "radioButton_exp";
            this.radioButton_exp.Size = new System.Drawing.Size(155, 21);
            this.radioButton_exp.TabIndex = 45;
            this.radioButton_exp.Text = "Экспоненциальное";
            this.radioButton_exp.UseVisualStyleBackColor = true;
            this.radioButton_exp.CheckedChanged += new System.EventHandler(this.RadioButton_exp_CheckedChanged);
            // 
            // radioButton_gauss
            // 
            this.radioButton_gauss.AutoSize = true;
            this.radioButton_gauss.Location = new System.Drawing.Point(1197, 197);
            this.radioButton_gauss.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_gauss.Name = "radioButton_gauss";
            this.radioButton_gauss.Size = new System.Drawing.Size(111, 21);
            this.radioButton_gauss.TabIndex = 44;
            this.radioButton_gauss.Text = "Гауссовское";
            this.radioButton_gauss.UseVisualStyleBackColor = true;
            this.radioButton_gauss.CheckedChanged += new System.EventHandler(this.RadioButton_gauss_CheckedChanged);
            // 
            // radioButton_uniform
            // 
            this.radioButton_uniform.AutoSize = true;
            this.radioButton_uniform.Location = new System.Drawing.Point(1197, 169);
            this.radioButton_uniform.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_uniform.Name = "radioButton_uniform";
            this.radioButton_uniform.Size = new System.Drawing.Size(118, 21);
            this.radioButton_uniform.TabIndex = 43;
            this.radioButton_uniform.Text = "Равномерное";
            this.radioButton_uniform.UseVisualStyleBackColor = true;
            this.radioButton_uniform.CheckedChanged += new System.EventHandler(this.RadioButton_uniform_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1261, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1261, 102);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1261, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 50;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(1197, 348);
            this.calculate_button.Margin = new System.Windows.Forms.Padding(4);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(152, 33);
            this.calculate_button.TabIndex = 57;
            this.calculate_button.Text = "Старт";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1150, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1158, 312);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1194, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1194, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1194, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "label1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(435, 21);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ci";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(663, 529);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-180, 580);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Xi";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(200, 124);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1765, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "2k/n ";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1767, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "pi/4          0.7853981";
            this.label10.Visible = false;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(1834, 459);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(88, 22);
            this.check.TabIndex = 18;
            this.check.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1765, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "La ";
            this.label8.Visible = false;
            // 
            // La
            // 
            this.La.Location = new System.Drawing.Point(1834, 431);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(88, 22);
            this.La.TabIndex = 14;
            this.La.Visible = false;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(1834, 403);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(88, 22);
            this.p.TabIndex = 12;
            this.p.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1767, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "p ";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1767, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "sigma  ";
            this.label6.Visible = false;
            // 
            // Sigma
            // 
            this.Sigma.Location = new System.Drawing.Point(1834, 375);
            this.Sigma.Name = "Sigma";
            this.Sigma.Size = new System.Drawing.Size(88, 22);
            this.Sigma.TabIndex = 10;
            this.Sigma.Visible = false;
            // 
            // Dx
            // 
            this.Dx.Location = new System.Drawing.Point(1834, 347);
            this.Dx.Name = "Dx";
            this.Dx.Size = new System.Drawing.Size(88, 22);
            this.Dx.TabIndex = 8;
            this.Dx.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1767, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dx ";
            this.label5.Visible = false;
            // 
            // label445
            // 
            this.label445.AutoSize = true;
            this.label445.Location = new System.Drawing.Point(1767, 322);
            this.label445.Name = "label445";
            this.label445.Size = new System.Drawing.Size(29, 17);
            this.label445.TabIndex = 7;
            this.label445.Text = "Mx ";
            this.label445.Visible = false;
            // 
            // Mx
            // 
            this.Mx.Location = new System.Drawing.Point(1834, 319);
            this.Mx.Name = "Mx";
            this.Mx.Size = new System.Drawing.Size(88, 22);
            this.Mx.TabIndex = 6;
            this.Mx.Visible = false;
            // 
            // start
            // 
            this.start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.start.Location = new System.Drawing.Point(1768, 270);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(154, 31);
            this.start.TabIndex = 16;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label3465
            // 
            this.label3465.AutoSize = true;
            this.label3465.Location = new System.Drawing.Point(1767, 231);
            this.label3465.Name = "label3465";
            this.label3465.Size = new System.Drawing.Size(34, 17);
            this.label3465.TabIndex = 5;
            this.label3465.Text = "R0  ";
            this.label3465.Visible = false;
            // 
            // R0
            // 
            this.R0.Location = new System.Drawing.Point(1834, 231);
            this.R0.Name = "R0";
            this.R0.Size = new System.Drawing.Size(88, 22);
            this.R0.TabIndex = 4;
            this.R0.Text = "191";
            this.R0.Visible = false;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(1834, 200);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(88, 22);
            this.M.TabIndex = 2;
            this.M.Text = "131071";
            this.M.Visible = false;
            // 
            // label2465
            // 
            this.label2465.AutoSize = true;
            this.label2465.Location = new System.Drawing.Point(1765, 200);
            this.label2465.Name = "label2465";
            this.label2465.Size = new System.Drawing.Size(23, 17);
            this.label2465.TabIndex = 3;
            this.label2465.Text = "m ";
            this.label2465.Visible = false;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(1767, 174);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(25, 17);
            this.label156.TabIndex = 1;
            this.label156.Text = "A  ";
            this.label156.Visible = false;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(1834, 171);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(88, 22);
            this.A.TabIndex = 0;
            this.A.Text = "65521";
            this.A.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1624, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton_simpson);
            this.Controls.Add(this.radioButton_triangle);
            this.Controls.Add(this.radioButton_gamma);
            this.Controls.Add(this.radioButton_exp);
            this.Controls.Add(this.radioButton_gauss);
            this.Controls.Add(this.radioButton_uniform);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Sigma2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Dx2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Mx2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.check);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.La);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.p);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sigma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dx);
            this.Controls.Add(this.label445);
            this.Controls.Add(this.Mx);
            this.Controls.Add(this.label3465);
            this.Controls.Add(this.R0);
            this.Controls.Add(this.label2465);
            this.Controls.Add(this.M);
            this.Controls.Add(this.label156);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР1 ";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Sigma2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Dx2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Mx2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton radioButton_simpson;
        private System.Windows.Forms.RadioButton radioButton_triangle;
        private System.Windows.Forms.RadioButton radioButton_gamma;
        private System.Windows.Forms.RadioButton radioButton_exp;
        private System.Windows.Forms.RadioButton radioButton_gauss;
        private System.Windows.Forms.RadioButton radioButton_uniform;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox check;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox La;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sigma;
        private System.Windows.Forms.TextBox Dx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label445;
        private System.Windows.Forms.TextBox Mx;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label3465;
        private System.Windows.Forms.TextBox R0;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.Label label2465;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.TextBox A;
    }
}

