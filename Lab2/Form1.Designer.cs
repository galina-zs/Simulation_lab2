﻿namespace Lab2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heightLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.heightNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.angleNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.speedNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.launchButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 150);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(12, 22);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 20);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height:";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleLabel.Location = new System.Drawing.Point(12, 58);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(54, 20);
            this.angleLabel.TabIndex = 2;
            this.angleLabel.Text = "Angle:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(12, 96);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(60, 20);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed:";
            // 
            // heightNumericUpDown1
            // 
            this.heightNumericUpDown1.Location = new System.Drawing.Point(93, 22);
            this.heightNumericUpDown1.Name = "heightNumericUpDown1";
            this.heightNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.heightNumericUpDown1.TabIndex = 4;
            this.heightNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // angleNumericUpDown1
            // 
            this.angleNumericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.angleNumericUpDown1.Location = new System.Drawing.Point(93, 58);
            this.angleNumericUpDown1.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angleNumericUpDown1.Name = "angleNumericUpDown1";
            this.angleNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.angleNumericUpDown1.TabIndex = 5;
            this.angleNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.angleNumericUpDown1.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // speedNumericUpDown2
            // 
            this.speedNumericUpDown2.Location = new System.Drawing.Point(93, 96);
            this.speedNumericUpDown2.Name = "speedNumericUpDown2";
            this.speedNumericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.speedNumericUpDown2.TabIndex = 6;
            this.speedNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // launchButton
            // 
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launchButton.Location = new System.Drawing.Point(255, 22);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 7;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(281, 96);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(49, 20);
            this.timerLabel.TabIndex = 8;
            this.timerLabel.Text = "00:00";
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseButton.Location = new System.Drawing.Point(344, 58);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 9;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.Location = new System.Drawing.Point(255, 58);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.speedNumericUpDown2);
            this.Controls.Add(this.angleNumericUpDown1);
            this.Controls.Add(this.heightNumericUpDown1);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown1;
        private System.Windows.Forms.NumericUpDown angleNumericUpDown1;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown2;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button continueButton;
    }
}

