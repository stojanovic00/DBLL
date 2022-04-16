using System;
using System.ComponentModel;

namespace Model
{
   public class Subject
   {
      public int id;
      public string name;
      public string yearOfStudying;
      
      public BindingList<Student> student;
   
   }
}