using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public class FamilleDAO
    {
        public FAMILLE FindById(string code)
        {
            FAMILLE code_famille = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from f in context.FAMILLEs
                          where f.FAM_CODE == code
                          select f;
                code_famille = (FAMILLE)req;
            }

            return code_famille;
        }

        public List<FAMILLE> FindAll()
        {
            List<FAMILLE> fams = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLEs
                          select f;
                fams = req.ToList<FAMILLE>();
            }
            return fams;
        }
    }
}
