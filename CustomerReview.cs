using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFeedpackSystem
{
    public class Review {
        public string CriteriaName { get; set; }
        public string Value { get; set; }
    }
    class CustomerReview
    {
        private string _path = "customerReview.txt";
    

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string Suggestions { get; set; }
        public List<Review> Reviews { get; set; }



        public string SaveReview(CustomerReview data)
        {
            string str = JsonConvert.SerializeObject(data, Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
        }

        public List<CustomerReview> List()
        {
            string d = Utility.ReadFromTextFile(_path);
            if (d != null)
            {
                List<CustomerReview> lst = JsonConvert.DeserializeObject<List<CustomerReview>>(d);
                return lst;
            }
            return null;
        }

        public List<CustomerReview> sortByFirstNameAsc(List<CustomerReview> customerList)
        {
            if (customerList != null)
            {
                for (int i = 0; i < customerList.Count - 1; i++)
                {
                    for (int j = i + 1; j < customerList.Count; j++)
                    {
                        if (customerList[i].CustomerName.CompareTo(customerList[j].CustomerName) > 0)
                        {
                            CustomerReview tempStudent = customerList[i];
                            customerList[i] = customerList[j];
                            customerList[j] = tempStudent;
                        }
                    }
                }
                return customerList;
            }
            return null;
        }

        public List<CustomerReview> sortByFirstNameDesc(List<CustomerReview> customerList)
        {
            if (customerList != null)
            {
                for (int i = 0; i < customerList.Count - 1; i++)
                {
                    for (int j = i + 1; j < customerList.Count; j++)
                    {
                        if (customerList[i].CustomerName.CompareTo(customerList[j].CustomerName) < 0)
                        {
                            CustomerReview tempStudent = customerList[i];
                            customerList[i] = customerList[j];
                            customerList[j] = tempStudent;
                        }
                    }
                }
                return customerList;
            }
            return null;
        }

        public List<CustomerReview> sortByDateAsc(List<CustomerReview> customerList)
        {
            if (customerList != null)
            {
                for (int i = 0; i < customerList.Count - 1; i++)
                {
                    for (int j = i + 1; j < customerList.Count; j++)
                    {
                        if (customerList[i].PhoneNumber.CompareTo(customerList[j].PhoneNumber) > 0)
                        {

                            CustomerReview tempStudent = customerList[i];
                            customerList[i] = customerList[j];
                            customerList[j] = tempStudent;

                        }
                    }
                }
                return customerList;
            }
            return null;
        }

        public List<CustomerReview> sortByDateDesc(List<CustomerReview> studentList)
        {
            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].PhoneNumber.CompareTo(studentList[j].PhoneNumber) < 0)
                        {
                            CustomerReview tempStudent = studentList[i];
                            studentList[i] = studentList[j];
                            studentList[j] = tempStudent;
                        }
                    }
                }
                return studentList;
            }
            return null;
        }



    }
}
