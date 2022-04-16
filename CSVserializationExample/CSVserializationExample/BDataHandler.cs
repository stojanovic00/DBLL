using System.ComponentModel;

namespace CSVserializationExample
{
    public class BDataHandler
    {
        private string path = @"..\..\..\data\B.csv";
           public BindingList<B> loadList()
        {

            BindingList<B> list = new BindingList<B>(); 

            string[] lines = File.ReadAllLines(path);
            
            foreach(String line in lines)
            {
                string[] csvParts = line.Split('|');

                list.Add(new B(Int32.Parse(csvParts[0]), csvParts[1],Int32.Parse(csvParts[2])));
            }

            return list;
        }
    }
}
