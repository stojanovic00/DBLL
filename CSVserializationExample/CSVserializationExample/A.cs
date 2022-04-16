using System.ComponentModel;

namespace CSVserializationExample
{
    public class A
    {
        //For this example id generating algorithm won't be realized
        //Random number generator will be used, but that is far by correct solution
        public int id;
        public string name;
        public string surname;

        public BindingList<B> listOfBs;


        public A() {
            Random rnd = new Random();
            id = rnd.Next(100,1000);
        }

        public A(string name, string surname)
        {
            Random rnd = new Random();
            id = rnd.Next(100,1000);

            this.name = name;   
            this.surname = surname;   

            listOfBs = new BindingList<B>();    
        }

        //Used when loading A from csv
        public A(int id,string name, string surname, BindingList<B> listB)
        {
            this.id = id;
            this.name = name;   
            this.surname = surname;
            this.listOfBs = new BindingList<B>();
            this.listOfBs = listB;
        }

       public void  printMe()
        {
          //TODO  
        }

    }
}
