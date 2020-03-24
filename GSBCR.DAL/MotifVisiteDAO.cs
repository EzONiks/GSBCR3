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
    public class MotifVisiteDAO
    {
        /// <summary>
        /// Retourne le motif de visite correspondant au code
        /// </summary>
        /// <param name="code">code motif visite</param>
        /// <returns>MOTIF_VISITE</returns>
        public MOTIF_VISITE FindById(string code)
        {
            MOTIF_VISITE mot = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MOTIF_VISITE
                          where m.MOT_CODE == code
                          select m;
                mot = req.SingleOrDefault<MOTIF_VISITE>();

            }
            return mot;
        }

        /// <summary>
        /// Retourne tous les motifs de visite
        /// </summary>
        /// <returns>List<MOTIF_VISITE></returns>
        public List<MOTIF_VISITE> FindAll()
        {
            List<MOTIF_VISITE> lmv = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE
                          select m;
                lmv = req.ToList<MOTIF_VISITE>();

            }
            return lmv;
        }
    }
}
