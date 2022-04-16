using System;

namespace Repository
{
   public class AdressRepository
   {
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
      
      public boolean UpdateOne(Model.Adress adress)
      {
         throw new NotImplementedException();
      }
      
      public boolean DeleteOne(int id)
      {
         throw new NotImplementedException();
      }
      
      public boolean AddOne(Model.Adress adress)
      {
         throw new NotImplementedException();
      }
      
      public Model.Adress FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public boolean IsUnique(Model.Adress adress)
      {
         throw new NotImplementedException();
      }
      
      public int idCounter;
      
      public System.Collections.Generic.List<Adress> adress;
      
      
      public System.Collections.Generic.List<Adress> Adress
      {
         get
         {
            if (adress == null)
               adress = new System.Collections.Generic.List<Adress>();
            return adress;
         }
         set
         {
            RemoveAllAdress();
            if (value != null)
            {
               foreach (Model.Adress oAdress in value)
                  AddAdress(oAdress);
            }
         }
      }
      
      
      public void AddAdress(Model.Adress newAdress)
      {
         if (newAdress == null)
            return;
         if (this.adress == null)
            this.adress = new System.Collections.Generic.List<Adress>();
         if (!this.adress.Contains(newAdress))
            this.adress.Add(newAdress);
      }
      
      
      public void RemoveAdress(Model.Adress oldAdress)
      {
         if (oldAdress == null)
            return;
         if (this.adress != null)
            if (this.adress.Contains(oldAdress))
               this.adress.Remove(oldAdress);
      }
      
      
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAdress()
      {
         if (adress != null)
            adress.Clear();
      }
   
   }
}