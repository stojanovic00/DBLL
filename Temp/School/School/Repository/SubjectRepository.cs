using System;

namespace Repository
{
   public class SubjectRepository
   {
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
      
      public boolean UpdateOne(Model.Subject subject)
      {
         throw new NotImplementedException();
      }
      
      public boolean DeleteOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public boolean AddOne(Model.Subject subject)
      {
         throw new NotImplementedException();
      }
      
      public Model.Subject FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public boolean IsUnique(Model.Subject subject)
      {
         throw new NotImplementedException();
      }
      
      public int idCounter;
      
      public System.Collections.Generic.List<Subject> subject;
      
      
      public System.Collections.Generic.List<Subject> Subject
      {
         get
         {
            if (subject == null)
               subject = new System.Collections.Generic.List<Subject>();
            return subject;
         }
         set
         {
            RemoveAllSubject();
            if (value != null)
            {
               foreach (Model.Subject oSubject in value)
                  AddSubject(oSubject);
            }
         }
      }
      
      
      public void AddSubject(Model.Subject newSubject)
      {
         if (newSubject == null)
            return;
         if (this.subject == null)
            this.subject = new System.Collections.Generic.List<Subject>();
         if (!this.subject.Contains(newSubject))
            this.subject.Add(newSubject);
      }
      
      
      public void RemoveSubject(Model.Subject oldSubject)
      {
         if (oldSubject == null)
            return;
         if (this.subject != null)
            if (this.subject.Contains(oldSubject))
               this.subject.Remove(oldSubject);
      }
      
      
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllSubject()
      {
         if (subject != null)
            subject.Clear();
      }
   
   }
}