using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFeedpackSystem
{
    class Criteria
    {
        private string _path = "criteria.txt";

        
        public string CriteriaName { get; set; }
       

        public string SaveReview(Criteria data)
        {
            string str = JsonConvert.SerializeObject(data, Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
        }

        public List<Criteria> getList()
        {
            string d = Utility.ReadFromTextFile(_path);
            if (d != null)
            {
                List<Criteria> lst = JsonConvert.DeserializeObject<List<Criteria>>(d);
                return lst;
            }
            return null;
        }

      


    }
}
