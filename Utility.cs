using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFeedpackSystem
{
    class Utility
    {
        public static void WriteToTextFile(string path, string data, bool append = true, int count = 1)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(path, append: append))
            {

                if (!append)
                {
                    //remove opening bracket "[" from data passed
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    //remove last bracket "]" from data passed
                    data = data.Trim().Substring(0, data.Trim().Length - 1);
                }
                if (count != 0)

                {
                    data = data + ",";
                }
                writer.WriteLine(data);
            }
        }
        public static string ReadFromTextFile(string path)
        {
            if (File.Exists(path))
            {
                string data;
                using (StreamReader r = new StreamReader(path))
                {
                    data = r.ReadToEnd();
                }
                if (data != "")
                {
                    data = "[" + data + "]";
                }
                return data;
            }
            return null;
        }
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);

                }
            }
            return table;
        }

        public static DataTable ConvertToDataTablecr(IList<CustomerReview> data)
        {
            string[] feedBacks = new string[] { "Worst", "Good", "Very Good", "Excellent" };

            Criteria objCriteria = new Criteria();
            var listCriteria = objCriteria.getList();

            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(CustomerReview));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            List<Review> lst;

             
            if (data != null)
            {
                lst = data.LastOrDefault().Reviews.ToList();
            }

                foreach (var item in listCriteria) {
                table.Columns.Add(item.CriteriaName);

                   }
            if (data != null)
            {
                foreach (CustomerReview item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    

                    foreach(var i in item.Reviews)
                    {
                        int index =!string.IsNullOrEmpty(i.Value)? Convert.ToInt32(i.Value):0;
                        row[i.CriteriaName] = index>0 ? feedBacks[index-1]:i.Value;

                        //table.Rows.Add(row);
                    }
                    table.Rows.Add(row);

                }
                
            }
            return table;
        }
    }
}
