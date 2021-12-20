using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFeedpackSystem
{
    public partial class Admin : Form
    {
        public object dataGridView { get; private set; }

        public Admin()
        {
            InitializeComponent();
            BindGrid();
            bindCriteria();
           // BindChart();
        }    
        private void BindGrid()
        {
            string[] feedBacks = new string[] { "Worst", "Good", "Very Good", "Excellent" };
            CustomerReview a = new CustomerReview();
            List<CustomerReview> listReview = a.List();
    
            DataTable dt = Utility.ConvertToDataTablecr(listReview);
           
            gridReview.DataSource = dt;

            //Bind Chart
            DataTable dtCount = new DataTable();
            dtCount.Columns.Add("count", typeof(int));
            dtCount.Columns.Add("criteria", typeof(string));
            IEnumerable<DataRow> drs = dt.AsEnumerable();
            string selCriteria = lBox.SelectedIndex == -1 ? "test" : lBox.SelectedItem.ToString();// (lBox.SelectedItem as DataRowView)["criteria"].ToString();

            foreach (string item in feedBacks)
            {
                DataRow dr = dtCount.NewRow();
                dr["criteria"] = item;
                dr["count"] = drs.Where(m => m.Field<string>(selCriteria).Trim() == item).ToList().Count;
                dtCount.Rows.Add(dr);
            }


            // DataTable dt = dtCount
            chartFeedback.DataSource = dtCount;
            chartFeedback.Name = "course";
            chartFeedback.Series["Series1"].XValueMember = "criteria";
            chartFeedback.Series["Series1"].YValueMembers = "count";
            this.chartFeedback.Titles.Remove(this.chartFeedback.Titles.FirstOrDefault());
          
            chartFeedback.Series["Series1"].IsValueShownAsLabel = true;
            
        }
      




        private void button1_Click(object sender, EventArgs e)
        {
            Criteria a = new Criteria();
            string criteria = txtCriteria.Text;

            if (!(criteria == ""))
            {
                if (!a.getList().Any(x => x.CriteriaName.ToLower() == criteria.ToLower()))
                {

                    a.CriteriaName = txtCriteria.Text;
                    string result = a.SaveReview(a);
                    if (result == "success")
                    {
                        bindCriteria();

                    }
                }
                else
                {
                    MessageBox.Show("This name already exists.");
                }
            }
            else
            {
                MessageBox.Show("The criteria is null");
            }

        }
        public void bindCriteria()
        {
            Criteria objCriteria = new Criteria();
            lBox.DataSource = objCriteria.getList().Select(x => x.CriteriaName).ToList();
        }

        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void sortByPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerReview student = new CustomerReview();
            List<CustomerReview> studentList = student.List();
            if (sortByPicker.SelectedItem.ToString().Equals("Name (Ascending)"))
            {
                List<CustomerReview> list = student.sortByFirstNameAsc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                gridReview.DataSource = dt;
            }
            else if (sortByPicker.SelectedItem.ToString().Equals("Name (Descending)"))
            {
                List<CustomerReview> list = student.sortByFirstNameDesc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                gridReview.DataSource = dt;
            }
            else if (sortByPicker.SelectedItem.ToString().Equals("DateTime (Ascending)"))
            {
                List<CustomerReview> list = student.sortByDateAsc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                gridReview.DataSource = dt;
            }
            else if (sortByPicker.SelectedItem.ToString().Equals("DatTime (Descending)"))
            {
                List<CustomerReview> list = student.sortByDateDesc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                gridReview.DataSource = dt;
            }

        }
    }
}
