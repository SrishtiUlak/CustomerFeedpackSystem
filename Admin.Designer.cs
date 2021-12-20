namespace CustomerFeedpackSystem
{
    partial class Admin
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gridReview = new System.Windows.Forms.DataGridView();
            this.chartFeedback = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortByPicker = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReview
            // 
            this.gridReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReview.Location = new System.Drawing.Point(751, 65);
            this.gridReview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridReview.Name = "gridReview";
            this.gridReview.RowHeadersWidth = 51;
            this.gridReview.RowTemplate.Height = 24;
            this.gridReview.Size = new System.Drawing.Size(427, 234);
            this.gridReview.TabIndex = 0;
            // 
            // chartFeedback
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFeedback.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFeedback.Legends.Add(legend1);
            this.chartFeedback.Location = new System.Drawing.Point(12, 374);
            this.chartFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartFeedback.Name = "chartFeedback";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFeedback.Series.Add(series1);
            this.chartFeedback.Size = new System.Drawing.Size(1205, 254);
            this.chartFeedback.TabIndex = 5;
            this.chartFeedback.Text = "chartFeedback";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Criteria";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(171, 65);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCriteria.Multiline = true;
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(179, 53);
            this.txtCriteria.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Criteria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 16;
            this.lBox.Location = new System.Drawing.Point(431, 42);
            this.lBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(239, 196);
            this.lBox.TabIndex = 10;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Criteria";
            // 
            // sortByPicker
            // 
            this.sortByPicker.FormattingEnabled = true;
            this.sortByPicker.Items.AddRange(new object[] {
            "Name (Ascending)",
            "Name (Descending)",
            "Date Time (Ascending)",
            "Date Time (Descending)"});
            this.sortByPicker.Location = new System.Drawing.Point(751, 36);
            this.sortByPicker.Name = "sortByPicker";
            this.sortByPicker.Size = new System.Drawing.Size(121, 24);
            this.sortByPicker.TabIndex = 12;
            this.sortByPicker.SelectedIndexChanged += new System.EventHandler(this.sortByPicker_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 663);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1205, 254);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1320, 1055);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.sortByPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartFeedback);
            this.Controls.Add(this.gridReview);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.gridReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortByPicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}