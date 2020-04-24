using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv3_ralasic
{
    class Dataset:Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }

        public Prototype Clone()
        {
            List<List<string>> dataClone = new List<List<string>>();

            foreach(List<string> row in this.data)
            {
                List<string> line = new List<string>();
                foreach (string element in row)
                {
                    line.Add(element);
                }
                dataClone.Add(line);
            }
            Dataset prototypeData = (Dataset)this.MemberwiseClone();
            prototypeData.data = dataClone;
            return (Prototype)prototypeData;
        }
        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();
            IList<List<string>> dataForString = this.GetData();
            foreach (List<string> row in dataForString)
            {
                foreach (string element in row)
                {
                    stringbuilder.Append(element).Append(",");
                }
                stringbuilder.Append("\n");
            }
            return stringbuilder.ToString();
        }

        public void ClearData()
        {
            this.data.Clear();
        }
    }
}
