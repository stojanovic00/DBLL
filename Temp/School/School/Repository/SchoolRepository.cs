using System;

namespace Repository
{
   public class SchoolRepository
   {
      public void Load()
      {
         throw new NotImplementedException();
      }
      
      public List<School> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void SaveAll()
      {
         throw new NotImplementedException();
      }
      
      public boolean UpdateOne(Model.School school)
      {
         throw new NotImplementedException();
      }
      
      public boolean DeleteOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public boolean AddOne(Model.School school)
      {
         throw new NotImplementedException();
      }
      
      public Model.School FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public boolean IsUnique(Model.School school)
      {
         throw new NotImplementedException();
      }
      
      public int idCounter;
      
      public System.Collections.Generic.List<School> school;
      
      
      public System.Collections.Generic.List<School> School
      {
         get
         {
            if (school == null)
               school = new System.Collections.Generic.List<School>();
            return school;
         }
         set
         {
            RemoveAllSchool();
            if (value != null)
            {
               foreach (Model.School oSchool in value)
                  AddSchool(oSchool);
            }
         }
      }
      
      
      public void AddSchool(Model.School newSchool)
      {
         if (newSchool == null)
            return;
         if (this.school == null)
            this.school = new System.Collections.Generic.List<School>();
         if (!this.school.Contains(newSchool))
            this.school.Add(newSchool);
      }
      
      
      public void RemoveSchool(Model.School oldSchool)
      {
         if (oldSchool == null)
            return;
         if (this.school != null)
            if (this.school.Contains(oldSchool))
               this.school.Remove(oldSchool);
      }
      
      
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllSchool()
      {
         if (school != null)
            school.Clear();
      }
   
   }
}