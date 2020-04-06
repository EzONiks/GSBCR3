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
    public class RegionDAO
    {
        /// <summary>
        /// recherche une région par son nom
        /// </summary>
        /// <param name="code"></param>
        /// <returns>REGION</returns>
        public REGION FindById(string code)
        {
            REGION reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGIONs
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();

            }
            return reg;

        }

        /// <summary>
        /// charge toutes les régions
        /// </summary>
        /// <returns>List<REGION></returns>
        public List<REGION> FindAll()
        {
            List<REGION> lesReg = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.REGIONs
                          select f;
                lesReg = req.ToList<REGION>();

            }
            return lesReg;
        }

        /// <summary>
        /// recherche une région par son nom
        /// </summary>
        /// <param name="Lib"></param>
        /// <returns>REGION</returns>
        public REGION FindByLib(string Lib)
        {
            REGION reglib = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGIONs
                          where r.REG_NOM == Lib
                          select r;
                reglib = req.SingleOrDefault<REGION>();

            }
            return reglib;

        }
    }
}
