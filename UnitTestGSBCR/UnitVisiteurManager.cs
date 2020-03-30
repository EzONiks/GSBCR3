using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> 80832adc77a77b6f822a2589b4fc26a04727092d
using GSBCR.modele;
using GSBCR.BLL;

namespace UnitTestGSBCR
{
    [TestClass]
    public class UnitVisiteurManager
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
<<<<<<< HEAD
            foreach (RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                Assert.AreEqual("1", r.RAP_ETAT, "état rapport différent de en cours (1)");
                ok = (r.RAP_NUM >= 57 && r.RAP_NUM <= 62);
                Assert.IsTrue(ok, "n° de rapport faux");
            }

=======
            foreach(RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                Assert.AreEqual("1",r.RAP_ETAT, "état rapport différent de en cours (1)");
                ok = (r.RAP_NUM >= 57 && r.RAP_NUM <=62); 
                Assert.IsTrue(ok,"n° de rapport faux");
            }
           
        }

        public void TestChargerRapportVisiteurFinis()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurFinis("a131");
            foreach (RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                Assert.AreEqual("2", r.RAP_ETAT, "état rapport différent de terminé (2)");
                Assert.AreEqual("3", r.RAP_ETAT, "état rapport différent de terminé (3)");
                ok = (r.RAP_NUM >= 57 && r.RAP_NUM <= 62);
                Assert.IsTrue(ok, "n° de rapport faux");
            }
>>>>>>> 80832adc77a77b6f822a2589b4fc26a04727092d
        }
    }
}
