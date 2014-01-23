using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HSp.CsEpo;
using HSp.CsNman;

namespace HSp.FotoDB
{
    public class FotoDbBase : Epo
    {
        public FotoDbBase()
            : base()
        {
        }

        public FotoDbBase(string conn)
            : base(conn)
        {
        }

        public override void Flush()
        {
            base.Flush();

            CsNman.Nman.Instance.Send(new NMessage(this, "OBJFLUSH" + ClassInfo().className, this.oid.OidStr));
        }

        public override bool Delete()
        { 
            bool answ =  base.Delete();

            CsNman.Nman.Instance.Send(new NMessage(this, "OBJDELETE" + ClassInfo().className, this.ClassInfo().className));

            return answ;
        }


    }
}
