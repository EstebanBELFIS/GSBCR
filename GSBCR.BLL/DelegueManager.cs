﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class DelegueManager
    {
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurByRegion(string regionCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            VISITEUR vis;
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindByRegion(regionCode);
            foreach (VAFFECTATION vaff in lvaff)
            {
                vis = new VisiteurDAO().FindById(vaff.VIS_MATRICULE);
                lv.Add(vis);
            }
            return lv;
        }
        /// <summary>
        /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
        /// </summary>
        /// <param name="code">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(String code)
        {
            //A faire : charger les rapports terminés et non lus (état = 2 ) des visiteurs d'une région
            List<RAPPORT_VISITE> lrv = new List<RAPPORT_VISITE>();
            List<VISITEUR> lv = ChargerVisiteurByRegion(code);
            List<string> lvm = new List<string>();
            List<int> le = new List<int>();
            le.Add(2);
            foreach (VISITEUR v in lv)
            {
                lvm.Add(v.VIS_MATRICULE);
            }
            lrv = new RapportVisiteDAO().FindByEtatEtVisiteur(lvm, le);
            return lrv;
        }
        /// <summary>
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(String r)
        {
            //A faire : charger les rapports terminés (état = 3) des visiteurs d'une région
            List<RAPPORT_VISITE> lrv = new List<RAPPORT_VISITE>();
            List<VISITEUR> lv = ChargerVisiteurByRegion(r);
            List<string> lvm = new List<string>();
            List<int> le = new List<int>();
            le.Add(3);
            foreach (VISITEUR v in lv)
            {
                lvm.Add(v.VIS_MATRICULE);
            }
            lrv = new RapportVisiteDAO().FindByEtatEtVisiteur(lvm, le);
            return lrv;
        }
    }
}
