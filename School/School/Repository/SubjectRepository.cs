using System;
using Model;
using System.ComponentModel;

namespace Repository
{

   public class SubjectRepository
   {
      public int idCounter;
      public BindingList<Subject> subject;


      public void Load()
      {
         throw new NotImplementedException();
      }
      
      public List<Subject> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void SaveAll()
      {
         throw new NotImplementedException();
      }
      
      public bool UpdateOne(Model.Subject subject)
      {
         throw new NotImplementedException();
      }
      
      public bool DeleteOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public bool AddOne(Model.Subject subject)
      {
         throw new NotImplementedException();
      }
      
      public Model.Subject FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public bool IsUnique(Model.Subject subject)
      {
         throw new NotImplementedException();
      }
   
   }
}