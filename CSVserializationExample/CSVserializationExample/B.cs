
namespace CSVserializationExample
{
    public class B
    {
        //Same goes for id, as for class A
        public int id;
        public string name;
        public int amount;



        public B() {
            Random rnd = new Random();
            id = rnd.Next(100,1000);
        }

        //Used when loading files from A.csv
        public B(int id) {
            this.id = id;
        }

        public B(string name, int amount)
        {
            Random rnd = new Random();
            id = rnd.Next(100,1000);

            this.name = name;
            this.amount = amount;
        }

        //Used for loading from file
        public B(int id,string name, int amount)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
        }


       public void  printMe()
        {
            Console.WriteLine("id: " + id + " Name: " + name + " Amount: " + amount);  
        }
    }
}
