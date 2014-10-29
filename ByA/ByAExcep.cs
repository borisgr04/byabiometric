using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;

namespace ByA
{
   public class ByAExcep
    {
        public static void AdminException(ByARpt byaRpt, System.Data.Entity.Validation.DbEntityValidationException ex)
        {
            foreach (var eve in ex.EntityValidationErrors)
            {
                foreach (var valErr in eve.ValidationErrors)
                {
                    byaRpt.Mensaje += valErr.PropertyName + ":" + valErr.ErrorMessage + "<br/>";
                }
            }
            byaRpt.Error = true;
        }

        public static void AdminException(ByARpt byaRpt, Exception ex)
        {
            if (ex.InnerException.InnerException != null)
            {
                byaRpt.Mensaje = ex.InnerException.InnerException.Message; ;
                byaRpt.Error = true;
            }
            else
            {
                byaRpt.Mensaje = ex.Message;
                byaRpt.Error = true;
            }
        }
    }
}
