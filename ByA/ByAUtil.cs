using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.IO;

namespace ByA
{
    public class ByAUtil
    {
        public static DataTable convertToDataTable<T>(IList<T> data)
        {
            DataTable table = null;
            if (data != null)
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                table = new DataTable();

                foreach (PropertyDescriptor prop in properties)
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }

                table.TableName = "Table";
            }
            return table;
        }

        //Elaborado por Boris, el dia 28 de Junio de 2013
        //Con el Objetivo de Pasar una Lista a XML, usa convertToDataTable<T>(IList<T> data)
        public static string convertListToXML<T>(IList<T> data){
            DataTable tb =convertToDataTable<T>(data);
            System.IO.StringWriter writer = new System.IO.StringWriter();
            if (tb != null)
            {
                tb.WriteXml(writer, XmlWriteMode.WriteSchema, false);
            }
            return writer.ToString();
        }

        public static void SaveJPG(System.Drawing.Image image, string szFileName)
        {
            //Si ya existe una imagen se tendra que eliminar
            if (System.IO.File.Exists(szFileName) == true)
            {
                System.IO.File.Delete(szFileName);
            }
            //Despues de eliminar la imagen existe se crea otra con el Drawing.Image nuevo
            //Throw New Exception(szFileName)
            image.Save(szFileName);
        }
        public static string Byte2ImagePath(byte[] bytes)
        {
            if (bytes == null)
                return null;
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Bitmap bm = null;
            string oPath = Path.ChangeExtension(Path.GetTempFileName(), ".JPG");
            try
            {
                bm = new System.Drawing.Bitmap(ms);
                SaveJPG(bm, oPath);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return oPath;
        }

        public static string Right(string param, int length)
        {

            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }

        public static string Left(string param, int length)
        {

            string result = param.Substring(0, length);
            return result;
        }

      
    }
}
