namespace HSp.FotoDB {

  using System;
  using System.Collections;
  using HSp.CsEpo;

  public class Film : FotoDbBase {
	private int			m_id;
	private String 		m_titel;
	private Oid 		m_materialOid, m_kameraOid;
	private int			m_jahr;
	private String		m_kontakt;
	private static bool	orderByName = false;
	private static int	maxId = -1;

	#region properties

	public int Id {
	  get {
		return m_id;
	  }
	  set {
		m_id = value;
	  }
	}

	public String Titel {
	  get {
		return m_titel;
	  }
	  set {
		m_titel = value;
	  }
	}

	public Oid MaterialOid {
	  set {
		m_materialOid = value;
	  }
	  get {
		return m_materialOid;
	  }
	}


	public Oid KameraOid {
	  set {
		m_kameraOid = value;
	  }
	  get {
		return m_kameraOid;
	  }
	}


	public int Jahr {
	  set {
		m_jahr = value;
	  }
	  get {
		return m_jahr;
	  }
	}

	public String Kontakt {
	  set {
		m_kontakt = value;
	  }
	  get {
		return m_kontakt;
	  }
	}

	#endregion
	public Film() : base() {
	  maxId++;
	  this.Id = maxId;
	  this.Titel = "<Neuer Film>";
	}

	public Film(String connStr) : base(connStr) {
	}

	///Setting Database length
	protected override void InitSpecialDbLen() {
	    base.InitSpecialDbLen();
	    
        SetDbLen("Titel", 50); 
	    SetDbLen("Kontakt", 255); 
	    SetDbLen("KameraOid", Oid.DbSize); 
	    SetDbLen("MaterialOid", Oid.DbSize);

        AddJoin("KameraOid", "Kamera");
        AddJoin("MaterialOid", "Material");

	}

	public override String PreferredOrdering() {
	  if(orderByName)
		return "Titel";
	  else
		return "Id";
	}

	public override String ToString() {
	  return Id + ":" + Titel;
	}
	
	
	public override ArrayList Select() {
		ArrayList 	erg;
		erg = base.Select();
		
		maxId = MaxId(erg);
		
		return erg;
	}
	
	public override ArrayList Select(String where, String orderBy) {
		ArrayList 	erg;
		erg = base.Select(where, orderBy);
		
		maxId = MaxId(erg);
		
		return erg;
	}
	
	private int MaxId(ArrayList erg) {
		Film	f;
		int		max = -1;
		
		for(int i=0; i<erg.Count; i++) {
			f = erg[i] as Film;
			if(f.Id > max) max = f.Id;
		}
				
		return max;
	}

    public override object Clone()
    {
        Film newF = base.Clone() as Film;
        newF.Id = maxId;

        return newF;
    }
  }
}
