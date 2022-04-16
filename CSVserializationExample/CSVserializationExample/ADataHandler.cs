using System.ComponentModel;

namespace CSVserializationExample
{
    public class ADataHandler
    {
        private string path = @"..\..\..\data\A.csv";
           public BindingList<A> loadList()
        {

            BindingList<A> list = new BindingList<A>(); 

            string[] lines = File.ReadAllLines(path);
            
            foreach(String line in lines)
            {
                string[] csvParts = line.Split('|');

                int id = Int32.Parse(csvParts[0]);
                string name = csvParts[1];
                string surname = csvParts[2];

                BindingList<B> listB = new BindingList<B>();

                string[]BIds = csvParts[3].Split(",");

                foreach(string sId in BIds)
                {
                    listB.Add(new B(Int32.Parse(sId)));  
                }

                list.Add(new A(id, name, surname, listB));

            }

            return list;
        }
    }
}
