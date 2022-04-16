using System;
using Model;
using System.ComponentModel;

namespace Repository
{
   public class AdressRepository
   {
      public int idCounter;
      public BindingList<Adress> adress;

      public void Load()
      {
         throw new NotImplementedException();
      }
      
      public List<Adress> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void SaveAll()
      {
         throw new NotImplementedException();
      }
      
      public bool UpdateOne(Model.Adress adress)
      {
         throw new NotImplementedException();
      }
      
      public bool DeleteOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public bool AddOne(Model.Adress adress)
      {
         throw new NotImplementedException();
      }
      
      public Model.Adress FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public bool IsUnique(Model.Adress adress)
      {
         throw new NotImplementedException();
      }
   }
}