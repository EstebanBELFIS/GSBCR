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
    public class RegionDAO
    {
        public REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            REGION reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGIONs
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();

            }
            return reg;
        }

        public List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            List<REGION> regs = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGIONs
                          select r;
                regs = req.ToList<REGION>();
            }
            return regs;
        }
    }
}
