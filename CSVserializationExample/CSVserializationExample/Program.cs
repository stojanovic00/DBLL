//Goal of this program is just to read and write from custom csv file  
//BindingList is used so this code can be easily transfered to main project
//Console.WriteLine("Hello, World!");

using System.ComponentModel;
using CSVserializationExample;



BindingList<A> listA;
BindingList<B> listB;

//LOADING lists

listB = new BindingList<B>();
BDataHandler Bhandler = new BDataHandler();

listB = Bhandler.loadList();

foreach(B b in listB)
{
    b.printMe();
}



listA = new BindingList<A>();
ADataHandler Ahandler = new ADataHandler();

listA = Ahandler.loadList();


//LNKING
//Now we need to link all B objects to ids in As list of Bs

foreach(A a in listA)
{
    //Extract all ids from listOfBs and then clear list
    //List is cleared so it can be populated with references of objects that are in list of all Bs
    //so listB and A.listOfBs will work with same objects
    List<int> ids = new List<int>();
    foreach(B b in a.listOfBs)
    {
        ids.Add(b.id); 
    }

    a.listOfBs.Clear();

    foreach(int id in ids)
    {
        foreach(B b in listB)
        {
            if(b.id == id)
            {
                a.listOfBs.Add(b);
            }
        }
    }
}


Console.WriteLine("This print is just so you have where to put breakpoint to see aftermath of linking in debugger.");



