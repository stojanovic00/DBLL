using System;
using Model;
using System.ComponentModel;

namespace Model
{
   public class School
   {
      public int id;
      public string name;
      public SchoolType type;
      
      public BindingList<Subject> subject;
      
      
   }
}