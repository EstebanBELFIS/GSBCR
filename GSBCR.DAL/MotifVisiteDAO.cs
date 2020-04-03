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
    public class MotifVisiteDAO
    {
        public MOTIF_VISITE FindById(string code)
        {
            //A faire : rechercher un motif visite par son nom
            MOTIF_VISITE lmv = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                // Rêquete pour récupérer le motif visite par le code
                var req = from m in context.MOTIF_VISITE
                          where m.MOT_CODE == code
                          select m;
                lmv = (MOTIF_VISITE)req;
            }
            return lmv;
        }

        public List<MOTIF_VISITE> FindAll()
        {
            List<MOTIF_VISITE> lmv = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                // Rêquete pour récupérer tout les motif visite 
                var req = from m in context.MOTIF_VISITE
                          select m;
                lmv = req.ToList<MOTIF_VISITE>();

            }
            return lmv;
        }
    }
}
