using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HSp.CsEpo;

namespace HSp.FotoDB
{
    class ViewFilm : EpoView
    {

        public ViewFilm() : base() 
		{
		}

        public ViewFilm(Epo viewedEpo, object parent)
            : base(viewedEpo, parent)
        { }

        protected override void InitSpecialControls()
        {
            base.InitSpecialControls();

            SetLabel("Id", "#");
            SetGeometry("Id", 0, 0, 14, 0, 4, 1);

            SetLabel("Titel", "Titel");
            SetGeometry("Titel", 0, 1, 14, 1, 40, 1);

            SetLabel("Jahr", "Jahr");
            SetGeometry("Jahr", 0, 2, 14, 2, 4, 1);

            SetLabel("KameraOid", "Kamera");
            SetGeometry("KameraOid", 0, 3, 14, 3, 30, 1);

            SetLabel("MaterialOid", "Material");
            SetGeometry("MaterialOid", 0, 4, 14, 4, 30, 1);

            SetLabel("Kontakt", "Kontaktabzug");
            SetGeometry("Kontakt", 0, 5, 14, 5, 40, 1);
            
        }
    }
}
