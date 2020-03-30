using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSBCR.modele;
using GSBCR.BLL;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestGSBCR
    {
        [TestMethod]
        public void TestChargerVisiteur()
        {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "le visiteur a131 mdp 30BFD069 non chargée");
            VISITEUR v1 = VisiteurManager.ChargerVisiteur("a131", "");
            Assert.IsNull(v1, "le visiteur a131 est chargée sans mot de passe");
        }

        [TestMethod]
        public void TestChargerRapportVisiteurEnCours()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours("a131");
            foreach (RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                Assert.AreEqual("1", r.RAP_ETAT, "état rapport différent de en cours (1)");
                ok = (r.RAP_NUM >= 51 && r.RAP_NUM <= 59);
                Assert.IsTrue(ok, "n° de rapport faux");
            }

        }
    }
}
