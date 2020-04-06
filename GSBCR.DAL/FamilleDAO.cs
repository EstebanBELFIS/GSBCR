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
        /// <summary>
        /// On va chercher toutes les famille d'un code famille spécifique
        /// </summary>
        /// <param name="code">Code de la famille</param>
        /// <returns>On retourne le nom de la famille</returns>
        public FAMILLE FindById(string code)
        {
            FAMILLE code_famille = null;
            //On récupere les informations d'une famille par rapport à un Id passé en parametre
            using (var context = new GSB_VisiteEntities())
            {
                //Requete qui recupère les informations de la famille
                var req = from f in context.FAMILLEs
                          where f.FAM_CODE == code
                          select f;
                code_famille = (FAMILLE)req;
            }
            // On retourne le nom de la famille
            return code_famille;
        }

        /// <summary>
        /// On va chercher toutes les familles
        /// </summary>
        /// <returns>On retorne toutes les familles</returns>
        public List<FAMILLE> FindAll()
        {
            List<FAMILLE> fams = null;
            //On va chercher toutes les familles qu'il existe
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLEs
                          select f;
                fams = req.ToList<FAMILLE>();
            }
            //On retoure la liste des famille
            return fams;
        }
    }
}
