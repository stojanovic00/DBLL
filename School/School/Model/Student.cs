using System;
using Model;
using System.ComponentModel;

namespace Model
{
   public class Student
   {
      public string idNumber;
      public string name;
      public string surname;
      public DateTime dateOfBirth;
      
      public School school;
      public BindingList<Subject> subject;
   }
}