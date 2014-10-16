using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriauleFingerprintLibrary.DataTypes;

namespace FingerprintNetSample.DB.AEF
{
    public class FingerprintTemplateDTO
    {
        public int ID { get; set; }
        public byte[] Buffer { get; set; }
        public int Quality { get; set; }
        public int Size { get; set; }
    }
   public class EnrollDAO
    {
        public void SaveTemplate(FingerprintTemplate fingerPrintTemplate)
        {
            using(fpEntities db = new fpEntities()){
                    
                enroll nuevo = new enroll();

                nuevo.quality = fingerPrintTemplate.Quality;
                nuevo.template = fingerPrintTemplate.Buffer;
            
                db.enroll.Add(nuevo);

                db.SaveChanges();
            }
            
        }

        public List<FingerprintTemplateDTO> GetTemplates()
        {
            List<FingerprintTemplateDTO> lst;
            using(fpEntities db = new fpEntities()){

                lst = db.enroll.Select(
                    t => new FingerprintTemplateDTO
                    { 
                        Quality=(int)t.quality,
                         Buffer= t.template,
                          ID= t.ID
                }).ToList();

            
            }
            return lst;
        }

        public FingerprintTemplateDTO GetTemplate(int idTemplate)
        {
            FingerprintTemplateDTO fpt;
            using (fpEntities db = new fpEntities())
            {

                fpt = db.enroll.Where(t => t.ID == idTemplate).Select(
                    t => new FingerprintTemplateDTO
                    {
                        Quality = (int)t.quality,
                        Buffer = t.template,
                         ID = t.ID
                    }).FirstOrDefault();
            }
            return fpt;
        }

        public void DeleteTemplate(int idTemplate)
        {
            throw new NotImplementedException();
        }

        public void DeleteTemplate()
        {
            throw new NotImplementedException();
        }
    }

    
}
