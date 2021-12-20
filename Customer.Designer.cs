using System.Windows.Forms;
using System.Drawing;

namespace CustomerFeedpackSystem
{
    partial class Customer
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
            this.txtCustomer = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtphnNumber = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.TextBox();
            this.Cemail = new System.Windows.Forms.TextBox();
            this.CNumber = new System.Windows.Forms.TextBox();
            this.txtSuggestions = new System.Windows.Forms.Label();
            this.Csuggestions = new System.Windows.Forms.TextBox();
            this.Csave = new System.Windows.Forms.Button();
            this.Cclear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoSize = true;
            this.txtCustomer.Location = new System.Drawing.Point(69, 182);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(109, 17);
            this.txtCustomer.TabIndex = 0;
            this.txtCustomer.Text = "Customer Name";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(75, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(42, 17);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            // 
            // txtphnNumber
            // 
            this.txtphnNumber.AutoSize = true;
            this.txtphnNumber.Location = new System.Drawing.Point(75, 327);
            this.txtphnNumber.Name = "txtphnNumber";
            this.txtphnNumber.Size = new System.Drawing.Size(103, 17);
            this.txtphnNumber.TabIndex = 2;
            this.txtphnNumber.Text = "Phone Number";
            // 
            // cbox
            // 
            this.cbox.Location = new System.Drawing.Point(221, 162);
            this.cbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox.Multiline = true;
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(184, 35);
            this.cbox.TabIndex = 9;
            this.cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomertxtBox_KeyPress);
            // 
            // Cemail
            // 
            this.Cemail.Location = new System.Drawing.Point(221, 238);
            this.Cemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cemail.Multiline = true;
            this.Cemail.Name = "Cemail";
            this.Cemail.Size = new System.Drawing.Size(184, 32);
            this.Cemail.TabIndex = 10;
            this.Cemail.Leave += new System.EventHandler(this.emailtextBox_Leave);
            // 
            // CNumber
            // 
            this.CNumber.Location = new System.Drawing.Point(221, 327);
            this.CNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CNumber.Multiline = true;
            this.CNumber.Name = "CNumber";
            this.CNumber.Size = new System.Drawing.Size(184, 34);
            this.CNumber.TabIndex = 11;
            this.CNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumbertxtbox_KeyPress);
            // 
            // txtSuggestions
            // 
            this.txtSuggestions.AutoSize = true;
            this.txtSuggestions.Location = new System.Drawing.Point(75, 407);
            this.txtSuggestions.Name = "txtSuggestions";
            this.txtSuggestions.Size = new System.Drawing.Size(86, 17);
            this.txtSuggestions.TabIndex = 26;
            this.txtSuggestions.Text = "Suggestions";
            // 
            // Csuggestions
            // 
            this.Csuggestions.Location = new System.Drawing.Point(221, 407);
            this.Csuggestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Csuggestions.Multiline = true;
            this.Csuggestions.Name = "Csuggestions";
            this.Csuggestions.Size = new System.Drawing.Size(184, 51);
            this.Csuggestions.TabIndex = 27;
            // 
            // Csave
            // 
            this.Csave.Location = new System.Drawing.Point(156, 569);
            this.Csave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Csave.Name = "Csave";
            this.Csave.Size = new System.Drawing.Size(107, 53);
            this.Csave.TabIndex = 30;
            this.Csave.Text = "Save";
            this.Csave.UseVisualStyleBackColor = true;
            this.Csave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Cclear
            // 
            this.Cclear.Location = new System.Drawing.Point(292, 569);
            this.Cclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cclear.Name = "Cclear";
            this.Cclear.Size = new System.Drawing.Size(115, 53);
            this.Cclear.TabIndex = 31;
            this.Cclear.Text = "Clear";
            this.Cclear.UseVisualStyleBackColor = true;
            this.Cclear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date time";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(221, 103);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(433, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 530);
            this.panel2.TabIndex = 44;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cclear);
            this.Controls.Add(this.Csave);
            this.Controls.Add(this.Csuggestions);
            this.Controls.Add(this.txtSuggestions);
            this.Controls.Add(this.CNumber);
            this.Controls.Add(this.Cemail);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.txtphnNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void AddElements()
        {           
            Criteria objCriteria = new Criteria();
            int i = 0;
            foreach (Criteria item in objCriteria.getList())
            {
                FlowLayoutPanel pnl = new FlowLayoutPanel() {Name="pnl"+item.CriteriaName.Replace(" ","") };
               
                pnl.Controls.Add(new Label() { Text = item.CriteriaName, Name = "lbl" + item.CriteriaName.Replace(" ", "") });
                i++;
               
                foreach (string cr in new string[] { "Worst","Good", "Very Good", "Excellent" })
                {
                    pnl.Controls.Add(new RadioButton() { Text = cr,Name="rad"+item.CriteriaName.Replace(" ", "") + cr.Replace(" ", "") });                   
                }
                pnl.Dock = DockStyle.Fill;
                pnl.AutoSize = true;
                panel2.Controls.Add(pnl);
            }
        }

        #endregion

        private System.Windows.Forms.Label txtCustomer;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtphnNumber;
        private System.Windows.Forms.TextBox cbox;
        private System.Windows.Forms.TextBox Cemail;
        private System.Windows.Forms.TextBox CNumber;
        private System.Windows.Forms.Label txtSuggestions;
        private System.Windows.Forms.TextBox Csuggestions;
        private System.Windows.Forms.Button Csave;
        private System.Windows.Forms.Button Cclear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private FlowLayoutPanel panel2;
    }
}

