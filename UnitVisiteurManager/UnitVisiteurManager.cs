using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSBCR.modele;
using GSBCR.BLL;

namespace UnitVisiteurManager
{
    [TestClass]
    public class UnitVisiteurManager
    {
        [TestMethod]
        public void testChargerVisiteur()
        {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "le visiteur a131 mdp 30BFD069 non chargée");
            VISITEUR v1 = VisiteurManager.ChargerVisiteur("a131", "");
            Assert.IsNotNull(v1, "le visiteur a131 est chargée sans mot de passe");
        }
    }
}
