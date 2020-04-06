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
        /// <summary>
        /// On va chercher le médcament qui appartient à un depot légal spécifique
        /// </summary>
        /// <param name="depot">Valeur d'un dépot légal</param>
        /// <returns>On retourne le médicament</returns>
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

        /// <summary>
        /// On va chercher tous les médicaments existant
        /// </summary>
        /// <returns>On retour tous les médicaments trouvés</returns>
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

        /// <summary>
        /// On va chercher tous les médicaments appartenant à une même famille
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
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
