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
    public class PratricienDAO
    {
        /// <summary>
        /// Permet de recupérer un praticien grâce à son numéro
        /// </summary>
        /// <param name="pranum">PRA_NUM de praticien</param>
        /// <returns>PRATICIEN</returns>
        public PRATICIEN FindById(Int16 pranum)
        {
            PRATICIEN pra = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from p in context.PRATICIENs.Include("LeType")
                          where p.PRA_NUM == pranum
                          select p;
                pra = req.SingleOrDefault<PRATICIEN>();
            }
            return pra;
        }

        public List<PRATICIEN> FindAll()
        {
            List<PRATICIEN> pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIENs.Include("LeType")
                          select p;
                pas = req.ToList<PRATICIEN>();

            }
            return pas;
        }

        /// <summary>
        /// Permet de récupérer tous les praticiens d'une catégorie
        /// </summary>
        /// <param name="code">code de type_praticien</param>
        /// <returns>List<PRATICIEN></returns>
        public List<PRATICIEN> FindByType(string code)
        {
            List<PRATICIEN> pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from tp in context.PRATICIENs.Include("leType")
                          where tp.TYP_CODE == code
                          select tp;
                pas = req.ToList<PRATICIEN>();
            }
            return pas;
        }
    }
}
