using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class FingerprintTemplateDTO
    {
        public int ID { get; set; }
        public byte[] Buffer { get; set; }
        public int Quality { get; set; }
        public int Size { get; set; }
    }

    public class mEnroll
    {
        bd_esEntities ctx;

        public void SaveTemplate(FingerprintTemplateDTO fingerPrintTemplate)
        {

            using (bd_esEntities db = new bd_esEntities())
            {

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
            using (bd_esEntities db = new bd_esEntities())
            {

                lst = db.enroll.Select(
                    t => new FingerprintTemplateDTO
                    {
                        Quality = (int)t.quality,
                        Buffer = t.template,
                        ID = t.ID
                    }).ToList();


            }
            return lst;
        }

        public int GetIdUltimoTemplate()
        {
            int IdUltimaHuella;
            using (bd_esEntities db = new bd_esEntities())
            {
                enroll Huella = db.enroll.OrderByDescending(t => t.ID).FirstOrDefault();
                IdUltimaHuella = Huella.ID;
            }
            return IdUltimaHuella;
        }

        public FingerprintTemplateDTO GetTemplate(int idTemplate)
        {
            FingerprintTemplateDTO fpt;
            using (bd_esEntities db = new bd_esEntities())
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
            using (ctx = new bd_esEntities())
            {
                enroll huella = ctx.enroll.Where(t => t.ID == idTemplate).FirstOrDefault();
                if (huella != null)
                {
                    ctx.enroll.Remove(huella);
                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch
                    {
                    }
                }
            }
        }

        public void DeleteTemplate()
        {
            throw new NotImplementedException();
        }
    }
}
