using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrame.Models
{

    public class Vote
    {
        
        public string votenom { get; set; }
        public IEnumerable<Activite> ListAct { get { return Utilitaire.Utils.getInstance().getListActivite();  } set { } }
    }
}