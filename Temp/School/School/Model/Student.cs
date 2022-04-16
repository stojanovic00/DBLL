using System;

namespace Model
{
   public class Student
   {
      public string idNumber;
      public string name;
      public string surname;
      public DateTime dateOfBirth;
      
      public School school;
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
               foreach (Subject oSubject in value)
                  AddSubject(oSubject);
            }
         }
      }
      
      
      public void AddSubject(Subject newSubject)
      {
         if (newSubject == null)
            return;
         if (this.subject == null)
            this.subject = new System.Collections.Generic.List<Subject>();
         if (!this.subject.Contains(newSubject))
            this.subject.Add(newSubject);
      }
      
      
      public void RemoveSubject(Subject oldSubject)
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
      public Adress adress;
   
   }
}