using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFeedpackSystem
{
    class AdminDashboard
    {
        private string _path = "customerReview.txt";
        public string UserName { get; set; }

        public string Password { get; set; }

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
        
    }

}
