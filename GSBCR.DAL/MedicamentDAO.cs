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
    public class MedicamentDAO
    {
        public MEDICAMENT FindById(string depot)
        {
            //rechercher un médicament par son nom de dépot
            MEDICAMENT med = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENTs.Include("laFamille")
                          where m.MED_DEPOTLEGAL == depot
                          select m;
                med = req.SingleOrDefault<MEDICAMENT>();

            }
            return med;
        }

        public List<MEDICAMENT> FindAll()
        {
            //charger tous les médicaments
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MEDICAMENTs.Include("laFamille")
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            //On retourne la liste des medicaments
            return meds;
            
        }

        public List<MEDICAMENT> FindByFamille(string code)
        {
            //charger tous les médicaments d'une meme famille
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;

                FamilleDAO famille = new FamilleDAO();
                FAMILLE code_famille = famille.FindById(code);

                var req = from m in context.MEDICAMENTs.Include("laFamille") where m.LaFamille == code_famille
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            //On retourne la liste des medicaments d'une meme famille
            return meds;
        }
    }
}
