using System.Linq;
using System.Windows.Forms;

namespace CustomerFeedpackSystem
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbl);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 23);
            this.lbl.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(485, 150);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void AddElements()
        {
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.Dock = DockStyle.Fill;

            for (int i = 0; i < 4; i++)
            {
                pnl.Controls.Add(new RadioButton() { Text = "RadioButton" + i });
            }

            this.Controls.Add(pnl);


            //TextBox textbox = new TextBox();
            //int count = panel.Controls.OfType<TextBox>().ToList().Count;
            //textbox.Location = new System.Drawing.Point(10, 25 * count);
            //textbox.Size = new System.Drawing.Size(80, 20);
            //textbox.Name = "txt_" + (count + 1);
            //panel.Controls.Add(textbox);
            //Criteria objCriteria = new Criteria();
            //foreach (Criteria item in objCriteria.getList())
            //{
            //    System.Windows.Forms.Panel panel3 = new System.Windows.Forms.Panel();
            //    System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            //    lbl.Text = item.CriteriaName;

            //    System.Windows.Forms.Panel panel4 = new System.Windows.Forms.Panel();
            //    // panel4.Location = new System.Drawing.Point(70, 200);

            //    foreach (string cr in new string[] { "Good", "Best" })
            //    {
            //        System.Windows.Forms.RadioButton rad = new System.Windows.Forms.RadioButton();
            //        rad.Text = cr;
            //        panel4.Controls.Add(rad);
            //    }

            //    panel3.Controls.Add(lbl);
            //    panel3.Controls.Add(panel4);
            //    panel3.Location = new System.Drawing.Point(56, 206);


            //    panel3.SuspendLayout();
            //    panel4.SuspendLayout();
            //    this.SuspendLayout();
            //}
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl;
    }
}
