﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL
{
    public class VisiteurDAO
    {
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public VISITEUR FindById(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEURs
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }

        /// <summary>
        /// Modification du mot de passe du visiteur
        /// </summary>
        /// <param name="v">Les données du visiteur</param>
        /// <returns></returns>
        public VISITEUR ModifierMDP(VISITEUR v)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry(v).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return vis;
        }

        /// <summary>
        /// Modification des informations de l'utilisateur
        /// </summary>
        /// <param name="v">Les données du visiteur</param>
        /// <returns></returns>
        public VISITEUR ModifierInfos(VISITEUR v)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry(v).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return vis;
        }

    }
}
