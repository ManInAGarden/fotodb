namespace HSp.FotoDB {

  using System;
  using HSp.CsEpo;

  public class Katalog : Epo {
   private String    m_bezeichnung;

   #region properties

   public String Bezeichnung {
     get {
      return m_bezeichnung;
     }
     set {
      m_bezeichnung = value;
     }
   }
   #endregion


   public Katalog() : base() {
   }

   public Katalog(String connStr) : base(connStr) {
   }

   ///Setting Databse length
   protected override void InitSpecialDbLen() {
     base.InitSpecialDbLen();
     SetDbLen("Bezeichnung", 35);
   }
   
   public override String ToString() {
      
      if(Bezeichnung!=null)
         return Bezeichnung;
      else
         return base.ToString();
   }
  }
}