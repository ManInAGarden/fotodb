using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HSp.CsEpo;


namespace HSp.FotoDB
{
    public class ViewMaterial : EpoView
    {

         public ViewMaterial() : base() 
		{
		}

         public ViewMaterial(Epo viewedEpo, object parent)
            : base(viewedEpo, parent)
        { }

        protected override void InitSpecialControls()
        {
            base.InitSpecialControls();

            SetLabel("Name", "Name");
            SetGeometry("Name", 0, 0, 14, 0, 40, 1);

            SetLabel("Asa", "ASA");
            SetGeometry("Asa", 0, 1, 14, 1, 4, 1);

            SetLabel("ArtOid", "Filmtyp");
            SetGeometry("ArtOid", 0, 2, 14, 2, 20, 1);
        }
    }
}
