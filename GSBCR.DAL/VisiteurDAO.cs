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
                context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEURs
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }

        /// <summary>
        /// Met à jour le mdp d'un visiteur
        /// </summary>
        /// <param name="matricule">matricule du visiteur</param>
        /// <param name="mdp">nouveau mdp</param>
        /// <returns>retourne msg de confirmation</returns>
        public string updateMdp(string matricule, string mdp)
        {
            string msg = "";
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req =
                    from v in context.VISITEURs
                    where v.VIS_MATRICULE == matricule
                    select v;

                foreach (VISITEUR vis in req)
                {
                    vis.vis_mdp = mdp;
                }
                try
                {
                    context.SaveChanges();
                    msg = "ok";
                }
                catch (Exception e )
                {
                    msg = "erreur";
                    throw;
                }
            }
            return msg;
        }

        /// <summary>
        /// Met à jour les infos personnelles du visiteur
        /// </summary>
        /// <param name="matricule">matricule </param>
        /// <param name="addr">nouvelle addresse</param>
        /// <param name="ville">nouvelle ville</param>
        /// <param name="cp">nouveau cp</param>
        /// <returns>booléen qui indique si l'opération si bien effectué</returns>
        public Boolean updateInfosVisiteur(string matricule, string addr, string ville, string cp)
        {
            bool msg = true;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                context.Configuration.LazyLoadingEnabled = false;
                var req =
                    from v in context.VISITEURs
                    where v.VIS_MATRICULE == matricule
                    select v;

                foreach (VISITEUR vis in req)
                {
                    vis.VIS_ADRESSE = addr;
                    vis.VIS_CP = cp;
                    vis.VIS_VILLE = ville;
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    msg = false;
                    throw;
                }
            }
            return msg;
        }


    }
}
