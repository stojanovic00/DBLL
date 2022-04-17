//Goal of this program is just to read and write from custom csv file  
//Put a breakpoint in code and inspect states of listA and listB through debugger
//BindingList is used so this code can be easily transfered to main project

using System.ComponentModel;
using CSVserializationExample;


BindingList<A> listA;
BindingList<B> listB;

//DESERIALIZING
listB = new BindingList<B>();
BDataHandler Bhandler = new BDataHandler();
listB = Bhandler.loadList();

//When loading A, only ids of Bs in listOfBs are loaded
//Actual B objects will be added in LINKING section
listA = new BindingList<A>();
ADataHandler Ahandler = new ADataHandler();
listA = Ahandler.loadList();


//LINKING
//Now we need to link all B objects to ids in As list of Bs
//This logic should be in linking services in real project
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
//WORK - START

//In this section you can try manipualting with lists of As and Bs


//WORK - END

//SERIALIZING

Bhandler.saveList(listB);
Ahandler.saveList(listA);
