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
    public class TypePraticienDAO
    {
        public TYPE_PRATICIEN FindById(string code)
        {
            TYPE_PRATICIEN type_praticien = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                // Rêquete pour récupérer le type praticien à l'aide de l'id 
                var req = from p in context.TYPE_PRATICIEN
                          where p.TYP_CODE == code
                          select p;
                type_praticien = (TYPE_PRATICIEN)req;
            }
            return type_praticien;
        }

        public List<TYPE_PRATICIEN> FindAll()
        {
            List<TYPE_PRATICIEN> pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                // Rêquete pour récupérer tout les types praticiens
                var req = from p in context.TYPE_PRATICIEN
                          select p;
                pas = req.ToList<TYPE_PRATICIEN>();
            }
            return pas;
        }

    }
}
