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

            foreach (String line in lines)
            {
                string[] csvParts = line.Split('|');

                int id = Int32.Parse(csvParts[0]);
                string name = csvParts[1];
                string surname = csvParts[2];
                
                //Generating listofBs:
                BindingList<B> listB = new BindingList<B>();

                string[] BIds = csvParts[3].Split(",");

                foreach (string sId in BIds)
                {
                    listB.Add(new B(Int32.Parse(sId)));
                }

                list.Add(new A(id, name, surname, listB));
            }

            return list;
        }



        public void saveList(BindingList<A> list)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {

                foreach (A a in list)
                {
                    string line = a.id + "|" + a.name + "|" + a.surname + "|";

                    //Only saving id of an B, not a whole object
                    foreach (B b in a.listOfBs)
                    {
                        line = line + b.id + ",";
                    }

                    //Remove last comma 
                    line = line.Remove(line.Length - 1, 1);

                    writer.WriteLine(line);
                }
            }
        }
    }
}
