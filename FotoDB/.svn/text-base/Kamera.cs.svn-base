namespace HSp.FotoDB {

  using System;
  using HSp.CsEpo;
  using HSp.FotoDB;

  public class Kamera : FotoDbBase {
	private String m_camName;
	#region properties
	public String Name {
	  get {
		return m_camName;
	  }
	  set {
		m_camName = value;
	  }
	}
	#endregion

	#region Constructors
	public Kamera() : base() {
	  m_camName = "<neue Kamera>";
	}

	public Kamera(String connStr) : base(connStr) {
	}
	#endregion

	protected override void InitSpecialDbLen() {
	  base.InitSpecialDbLen();
	  SetDbLen("Name", 40);
	}


	public override String PreferredOrdering() {
	  return "Name";
	}


	public override String ToString() {
	  String answ = null;

	  if(m_camName != null) {
		if(m_camName.Length>0)
		  answ = m_camName;
		else
		  answ = "./.";
	  }
	  
	  if(answ==null)
		answ = base.ToString();

	  return answ;
	}
  }
}
