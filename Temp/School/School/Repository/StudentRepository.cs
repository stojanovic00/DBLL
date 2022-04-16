using System;

namespace Repository
{
   public class StudentRepository
   {
      public void Load()
      {
         throw new NotImplementedException();
      }
      
      public List<Student> GetAll()
      {
         throw new NotImplementedException();
      }
      
      public void SaveAll()
      {
         throw new NotImplementedException();
      }
      
      public boolean UpdateOne(Model.Student student)
      {
         throw new NotImplementedException();
      }
      
      public boolean DeleteOne(string id)
      {
         throw new NotImplementedException();
      }
      
      public boolean AddOne(Model.Student student)
      {
         throw new NotImplementedException();
      }
      
      public Model.Student FindById(string id)
      {
         throw new NotImplementedException();
      }
      
      public boolean IsUnique(Model.Student student)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.Generic.List<Student> student;
      
      
      public System.Collections.Generic.List<Student> Student
      {
         get
         {
            if (student == null)
               student = new System.Collections.Generic.List<Student>();
            return student;
         }
         set
         {
            RemoveAllStudent();
            if (value != null)
            {
               foreach (Model.Student oStudent in value)
                  AddStudent(oStudent);
            }
         }
      }
      
      
      public void AddStudent(Model.Student newStudent)
      {
         if (newStudent == null)
            return;
         if (this.student == null)
            this.student = new System.Collections.Generic.List<Student>();
         if (!this.student.Contains(newStudent))
            this.student.Add(newStudent);
      }
      
      
      public void RemoveStudent(Model.Student oldStudent)
      {
         if (oldStudent == null)
            return;
         if (this.student != null)
            if (this.student.Contains(oldStudent))
               this.student.Remove(oldStudent);
      }
      
      
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllStudent()
      {
         if (student != null)
            student.Clear();
      }
   
   }
}