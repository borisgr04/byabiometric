using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using GriauleFingerprintLibrary.DataTypes;

namespace FingerprintNetSample.DB.Dal
{
    public sealed class AccessDataAccessLayer : IGRDal
    {
        public OleDbConnection dbConection;
        public readonly string CONNECTION_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\DB\\FingerPrintSample.mdb";

        private AccessDataAccessLayer() 
        {
            dbConection = new OleDbConnection(CONNECTION_STRING);           
        }

        public void SaveTemplate(FingerprintTemplate fingerprintTemplate) 
        {
            
                using (dbConection)
                {
                    dbConection.Open();

                    string strCommand = "INSERT INTO ENROLL(template,quality) VALUES (?,?)";

                    OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
                    oleCommand.Parameters.Add(new OleDbParameter("@template", OleDbType.VarBinary, fingerprintTemplate.Size, ParameterDirection.Input, false, 0, 0, "ID", DataRowVersion.Current, fingerprintTemplate.Buffer));
                    oleCommand.Parameters.Add(new OleDbParameter("@quality", OleDbType.Integer));
                    oleCommand.Parameters["@quality"].Value = fingerprintTemplate.Quality;
                    oleCommand.ExecuteNonQuery();
                }
            
            
        }

        public IDataReader GetTemplates() 
        {
            
           
                dbConection.Open();

                string strCommand = "SELECT * FROM ENROLL";

                OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);

                return oleCommand.ExecuteReader();
            
        }

        ~AccessDataAccessLayer() 
        {
            if (dbConection.State == ConnectionState.Open) 
            {
                try
                {                  
                    dbConection.Dispose();
                }
                catch { }
            }
        }

        public IDataReader GetTemplate(int idTemplate)
        {
            dbConection.Open();

            string strCommand = "SELECT * FROM ENROLL WHERE ID = ?";

            OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
            oleCommand.Parameters.Add(new OleDbParameter("@ID",idTemplate));

            return oleCommand.ExecuteReader();
        }

        public void DeleteTemplate(int idTemplate) { }

        public void DeleteTemplate() 
        {
            using (dbConection) 
            {
                dbConection.Open();

                string strCommand = "DELETE * FROM ENROLL";

                OleDbCommand oleCommand = new OleDbCommand(strCommand, dbConection);
                oleCommand.ExecuteNonQuery();
            }
        }

    }
}
