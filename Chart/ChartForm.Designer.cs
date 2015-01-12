namespace MiSS_RK4
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.exampleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.labelX0 = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exampleChart)).BeginInit();
            this.SuspendLayout();
            // 
            // exampleChart
            // 
            this.exampleChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea1.Name = "ChartArea1";
            this.exampleChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.exampleChart.Legends.Add(legend1);
            this.exampleChart.Location = new System.Drawing.Point(12, 12);
            this.exampleChart.Name = "exampleChart";
            this.exampleChart.Size = new System.Drawing.Size(1150, 594);
            this.exampleChart.TabIndex = 0;
            this.exampleChart.Text = "exampleChart";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(505, 628);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(97, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start algorytmu";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(370, 627);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStep.TabIndex = 2;
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(190, 628);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(103, 20);
            this.textBoxX0.TabIndex = 3;
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(149, 633);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(20, 13);
            this.labelX0.TabIndex = 4;
            this.labelX0.Text = "X0";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(329, 633);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(29, 13);
            this.labelStep.TabIndex = 5;
            this.labelStep.Text = "Step";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 697);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.exampleChart);
            this.Name = "ChartForm";
            this.Text = "MISS RK4";
            ((System.ComponentModel.ISupportInitialize)(this.exampleChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart exampleChart;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.Label labelStep;
    }
}

