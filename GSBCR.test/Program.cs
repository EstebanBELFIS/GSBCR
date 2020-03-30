using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                System.Console.WriteLine("----------Menu test----------");
                Console.WriteLine("1. charger les rapports en cours d'un visiteur");
                Console.WriteLine("2. créer un nouveau rapport");
                Console.WriteLine("3. modifier un rapport");
                Console.WriteLine("4. charger les visiteurs d'une région");
                Console.WriteLine("5. charger un visiteur");
                Console.WriteLine("6. charger les rapports non consultés des visiteurs d'une région");
                Console.WriteLine("7. charger les rapports consultés des visiteurs d'une région");
                Console.WriteLine("8. charger les rapports terminés du visiteur"); //ChargerRapportVisiteurFinis
                Console.WriteLine("9. charger un praticien");
                Console.WriteLine("10. Quitter");
                Console.WriteLine("Votre choix");
                
                n = Convert.ToInt16(Console.ReadLine());
                switch (n)
                {
                    case 1: test_ChargerRapportVisiteurEnCours();
                        break;
                    case 2: test_insert();
                        break;
                    case 3: test_update();
                        break;
                    case 4: test_ChargerVisiteurRegion();
                        break;
                    case 5: test_ChargerVisiteur();
                        break;
                    case 6: test_ChargerRapportNonConsultésVisiteursRegion();
                        break;
                    case 7: test_ChargerRapportConsultésVisiteursRegion();
                        break;
                    case 8: test_ChargerRapportVisiteurFinis();
                        break;
                    case 9: test_ChargerPraticien();
                        break;
                    case 10: Console.WriteLine("Fin du test");
                        break;
                    default: Console.WriteLine("Mauvais choix");
                        break;
                }      
            } while (n != 6);
            
            Console.ReadKey();
        }

        static void test_ChargerRapportVisiteurFinis()
        {
            Console.WriteLine("Entrez le matricule visiteur :");
            string mv = Console.ReadLine();
            try
            {
                List<RAPPORT_VISITE> lesRapportsFinis = VisiteurManager.ChargerRapportVisiteurFinis(mv);
                foreach (var r in lesRapportsFinis)
                {
                    Console.WriteLine("matricule {0}, n° rapport {1}", r.RAP_MATRICULE, r.RAP_NUM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }

        static void test_ChargerRapportNonConsultésVisiteursRegion()
        {
            Console.WriteLine("Entrez le code région :");
            string cr = Console.ReadLine();
            try
            {
                List<RAPPORT_VISITE> lesRapportsNonConsultes = DelegueManager.ChargerRapportRegionNonLus(cr);
                foreach (var r in lesRapportsNonConsultes)
                {
                    Console.WriteLine("matricule {0}, n° rapport {1}", r.RAP_MATRICULE, r.RAP_NUM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }

        static void test_ChargerRapportConsultésVisiteursRegion()
        {
            Console.WriteLine("Entrez le code région :");
            string cr = Console.ReadLine();
            try
            {
                List<RAPPORT_VISITE> lesRapportsConsultes = DelegueManager.ChargerRapportRegionLus(cr);
                foreach (var r in lesRapportsConsultes)
                {
                    Console.WriteLine("matricule {0}, n° rapport {1}", r.RAP_MATRICULE, r.RAP_NUM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }

        static void test_ChargerRapportVisiteurEnCours()
        {
            Console.WriteLine("Entrez le n° visiteur :"); //exemple a131, r58, a17, a55
            string m = Console.ReadLine();
            List<string> lesMatricules = new List<string>();
            try
            {
                List<RAPPORT_VISITE> lesRapportsEnCours = VisiteurManager.ChargerRapportVisiteurEncours(m);
                foreach (var r in lesRapportsEnCours)
                {
                    Console.WriteLine("matricule {0}, no rapport {1}",r.RAP_MATRICULE, r.RAP_NUM);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
            
        }

        static void test_insert()
        {
            Console.WriteLine("Entrez le n° visiteur :"); //exemple a131, r58, a17, a55
            string m = Console.ReadLine();
            //création rapport
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = m;
            r.RAP_MOTIF = "NA";
            r.RAP_PRANUM= 7;
            r.RAP_DATVISIT = new DateTime(2020, 2, 1, 0, 0, 0);
            r.RAP_ETAT = "1";
            r.RAP_CONFIANCE= "1";
            r.RAP_BILAN = "Tout va bien!";
            r.RAP_MED1 = "3MYC7";
            try
            {
                VisiteurManager.CreateRapport(r);
                Console.WriteLine("numéro de rapport créé: " + r.RAP_NUM.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }

        static void test_update()
        {
            Console.WriteLine("Entrez le n° visiteur :"); //exemple a131, r58, a17, a55
            string m = Console.ReadLine();
            Console.WriteLine("Entrez le n° rapport :"); 
            int no = int.Parse(Console.ReadLine());
            try
            {
                //récupération  rapport
                RAPPORT_VISITE r = VisiteurManager.ChargerRapportVisite(m, no);
                if (r != null)
                {
                    r.RAP_MOTIF = "AU";
                    r.RAP_PRANUM = 7;
                    r.RAP_DATVISIT = new DateTime(2020, 2, 1, 0, 0, 0);
                    r.RAP_ETAT = "2";
                    r.RAP_CONFIANCE = "1";
                    r.RAP_BILAN = "Tout va bien!";
                    r.RAP_MED1 = "3MYC7";
                    VisiteurManager.MajRapport(r);
                    Console.WriteLine("rapport modifié: " + r.RAP_NUM.ToString());
                }
                else
                {
                    Console.WriteLine("aucun rapport trouvé");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }

        static void test_ChargerVisiteurRegion()
        {
            Console.WriteLine("Entrez code région :"); //exemple BG
            string r= Console.ReadLine();
            try
            {
                List<VISITEUR> lv = DelegueManager.ChargerVisiteurByRegion(r);
                foreach (VISITEUR v in lv)
                {
                    Console.WriteLine("Visiteur : " + v.VIS_MATRICULE + " " + v.VIS_NOM + " " + v.Vis_PRENOM);
                
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
            
        }

        static void test_ChargerVisiteur()
        {
            Console.WriteLine("Entrez le n° visiteur :"); //exemple a131, r58, a17, a55
            string m = Console.ReadLine();
            Console.WriteLine("Entrez le mot de passe :"); //exemple 30BFD069
            string mdp = Console.ReadLine();
            try
            {
                VISITEUR v = VisiteurManager.ChargerVisiteur(m, mdp);
                VAFFECTATION vaff = VisiteurManager.ChargerAffectationVisiteur(m);
                if (v != null && vaff !=null)
                {
                    Console.WriteLine("Visiteur " + v.VIS_NOM + " " + v.Vis_PRENOM);
                    Console.WriteLine("dernière affectation : {0} , {1}, {2}", vaff.TRA_ROLE, vaff.REG_CODE, vaff.JJMMAA);
                }
                else
                {
                    Console.WriteLine("visiteur absent ou mdp erroné");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }

        static void test_ChargerPraticien()
        {
            Console.WriteLine("Entrez le n° praticien :"); //exemple 1, 20, 10, 15
            short pn = Convert.ToInt16(Console.ReadLine());
            try
            {
                PRATICIEN p = VisiteurManager.ChargerLePraticien(pn);
                if (p != null)
                {
                    Console.WriteLine("Praticne " + p.PRA_NOM + " " + p.PRA_PRENOM);
                    Console.WriteLine("Adresse : {0} , {1}, {2}", p.PRA_ADRESSE, p.PRA_CP, p.PRA_VILLE);
                }
                else
                {
                    Console.WriteLine("Praticien absent");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
        }
    }
}
