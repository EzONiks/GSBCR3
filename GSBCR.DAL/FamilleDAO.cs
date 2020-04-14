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
        /// recherche une famille de médicaments par son nom
        /// </summary>
        /// <param name="code"></param>
        /// <returns>FAMILLE</returns>

        public FAMILLE FindById(string code)
        {
            FAMILLE fam = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLEs.Include("laFamille")
                          where f.FAM_CODE == code
                          select f;
                fam = req.SingleOrDefault<FAMILLE>();
            }
            return fam;
        }

        /// <summary>
        /// charge toutes les familles de médicaments
        /// </summary>
        /// <returns>List<FAMILLE></returns>
        public List<FAMILLE> FindAll()
        {
            List<FAMILLE> lesFam = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLEs.Include("laFamille")
                          select f;
                lesFam = req.ToList<FAMILLE>();
            }
            return lesFam;

        }

    }
}
