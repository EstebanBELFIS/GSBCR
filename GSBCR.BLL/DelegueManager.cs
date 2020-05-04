using System;
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
            // Création des variables
            List<RAPPORT_VISITE> lrv = new List<RAPPORT_VISITE>();
            List<VISITEUR> lv = ChargerVisiteurByRegion(code);
            List<string> lvm = new List<string>();
            List<int> le = new List<int>();
            le.Add(2);
            // Récupere le matricule visiteur de chaque visiteur de la liste V et l'ajoute dans la liste string lvm
            foreach (VISITEUR v in lv)
            {
                lvm.Add(v.VIS_MATRICULE);
            }
            // Récupère le rapport de visite et le stocke dans la liste de rapport de visite lrv
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
            // Création des variables
            List<RAPPORT_VISITE> lrv = new List<RAPPORT_VISITE>();
            List<VISITEUR> lv = ChargerVisiteurByRegion(r);
            List<string> lvm = new List<string>();
            List<int> le = new List<int>();
            le.Add(3);
            // Récupere le matricule visiteur de chaque visiteur de la liste V et l'ajoute dans la liste string lvm
            foreach (VISITEUR v in lv)
            {
                lvm.Add(v.VIS_MATRICULE);
            }
            // Récupère le rapport de visite et le stocke dans la liste de rapport de visite lrv
            lrv = new RapportVisiteDAO().FindByEtatEtVisiteur(lvm, le);
            return lrv;
        }

        /// <summary>
        /// Permet de charger les rapports terminés et consultés (état 3) d'un visiteur
        /// </summary>
        /// <param name="m">matricule visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurLus(String m)
        {
            //A faire : charger les rapports terminés (état = 2 ou 3) du visiteur
            // Création des variables
            List<string> lvm = new List<string>();
            lvm.Add(m);
            List<int> le = new List<int>();
            le.Add(3);
            // Récupère le rapport et le stocke dans la liste rapport visite lr
            List<RAPPORT_VISITE> lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lvm, le);
            return lr;
        }
    }
}
