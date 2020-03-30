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
    public class PratricienDAO
    {
        public PRATICIEN FindById(Int16 pranum)
        {

            PRATICIEN pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIENs.Include("LeType")
                          where p.PRA_NUM == pranum
                          select p;
                pas = (PRATICIEN)req;
            }
            return pas;
        }

        public List<PRATICIEN> FindAll()
        {
            List<PRATICIEN> pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIENs.Include("LeType")
                          select p;
                pas = req.ToList<PRATICIEN>();

            }
            return pas;
        }

        public List<PRATICIEN> FindByType(string code)
        {
            //A faire : charger tous les praticiens d'un type

            List<PRATICIEN> pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                // On créé un manager pour le type
                TypePraticienDAO type_praticien_manager = new TypePraticienDAO();
                // On cherche le type correspondant au code envoyé en paramêtre
                TYPE_PRATICIEN type_praticien = type_praticien_manager.FindById(code);

                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;

                // On finit par chercher les PRATICIENS correspondant à ce type
                var req = from p in context.PRATICIENs.Include("LeType")
                          where p.LeType == type_praticien
                          select p;
                pas = req.ToList<PRATICIEN>();
            }
            return pas;
        }
    }
}
