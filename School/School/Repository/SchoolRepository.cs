using System;
using Model;
using System.ComponentModel;

namespace Repository
{
   public class SchoolRepository
   {
      public int idCounter;
      public BindingList<Model.School> school;


      public void Load()
      {
         throw new NotImplementedException();
      }
      
      public List<Model.School> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void SaveAll()
      {
         throw new NotImplementedException();
      }
      
      public bool UpdateOne(Model.School school)
      {
         throw new NotImplementedException();
      }
      
      public bool DeleteOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public bool AddOne(Model.School school)
      {
         throw new NotImplementedException();
      }
      
      public Model.School FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public bool IsUnique(Model.School school)
      {
         throw new NotImplementedException();
      }
      
   }
}