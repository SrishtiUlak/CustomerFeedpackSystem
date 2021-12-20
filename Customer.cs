using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFeedpackSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            AddElements();
            BindGrid();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!(cbox.Text == ""))
            {
                if (!(CNumber.Text == ""))
                {
                    if (CNumber.Text == "^[0-9]{10}$")
                    {

                        try
                        {
                        Criteria objCriteria = new Criteria();
                        List<Review> lstReview = new List<Review>();

                        foreach (Criteria item in objCriteria.getList())
                        {
                            string name = item.CriteriaName.Replace(" ","");
                            FlowLayoutPanel panel = panel2.Controls.Find("pnl" + name,true).FirstOrDefault() as FlowLayoutPanel;
                            if (panel != null)
                            {
                                string feedback = "";
                                string[] feedBacks = new string[] { "Worst", "Good", "Very Good", "Excellent"};
                                foreach (string cr in feedBacks)
                                {
                                   RadioButton rad= panel.Controls.Find("rad" +name + cr.Replace(" ", ""), false).FirstOrDefault() as RadioButton;
                                    if (rad != null)
                                    {
                                        if (rad.Checked)
                                        {

                                            feedback =!String.IsNullOrEmpty(rad.Text)? (feedBacks.ToList().FindIndex(m => m == rad.Text)+1).ToString():"0";
                                            break;

                                        }
                                    }
                                }
                                lstReview.Add(new Review() { CriteriaName = item.CriteriaName, Value = feedback });
                            }
                        }

                        CustomerReview r = new CustomerReview();
                            r.CustomerName = cbox.Text;
                            r.PhoneNumber = (CNumber.Text).ToString();

                            r.Reviews = lstReview;

                        r.Date = DateTime.Now;
                
                        r.Email = Cemail.Text;

                        r.Suggestions = Csuggestions.Text;



                

                        string flag = r.SaveReview(r);

             
                
                        if (flag == "success") {
                            MessageBox.Show("Success");
                            BindGrid();
                    
                    

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured");
                    }
                    }

                    else
                    {
                        MessageBox.Show("Enter 10 digit number ");

                    }

                }

                else
                {
                    MessageBox.Show("Phone Number is empty");

                }




            }
            else
            {
                MessageBox.Show("UserName is empty");

            }

        }

        private void BindGrid()
        {
            Criteria objCriteria = new Criteria();
            
        }
        
    


        private void phoneNumbertxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void CustomertxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void emailtextBox_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        void ValidateEmail()
        {
            if (Cemail.Text.Length > 0) {
                CustomerReview r = new CustomerReview();
                string email = Cemail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(Cemail.Text.Trim())) {
                    MessageBox.Show(email + " is notValid Email Address");
                    Cemail.Focus();
                    return;
                }
            }
             
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cbox.Text = "";
            Cemail.Text = "";
            Csuggestions.Text = "";
            CNumber.Text = "";

          
        }








    }
}
