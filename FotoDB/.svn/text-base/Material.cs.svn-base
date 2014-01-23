namespace HSp.FotoDB {

  using System;
  using HSp.CsEpo;

  public class Material : FotoDbBase {
   private String   m_name;
   private Oid    m_artOid;
   private int      m_asa;

   #region properties
   public String Name {
     get {
      return m_name;
     }
     set {
      m_name = value;
     }
   }

   public int Asa {
     get {
      return m_asa;
     }
     set {
      m_asa = value;
     }
   }

   public Oid ArtOid {
     set {
      m_artOid = value;
     }
     get {
      return m_artOid;
     }
   }

   #endregion
   public Material() : base() {
        this.Name = "<neues Material>";
     
   }

   public Material(String connStr) : base(connStr) {
   }

   protected override void InitSpecialDbLen() {
     base.InitSpecialDbLen();
     SetDbLen("Name", 40);
     SetDbLen("ArtOid", Oid.DbSize);

     AddJoin("ArtOid", "FilmArt");
   }

   public override String PreferredOrdering() {
     return "Name";
   }

   public override String ToString() {
     return Name;
   }
  }
}