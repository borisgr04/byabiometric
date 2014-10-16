using System;
using System.Collections.Generic;
using System.Text;
using GriauleFingerprintLibrary.DataTypes;
using System.Data;

namespace FingerprintNetSample.DB
{
    public interface IGRDal
    {
        void SaveTemplate(FingerprintTemplate fingerPrintTemplate);
        IDataReader GetTemplates();
        IDataReader GetTemplate(int idTemplate);
        void DeleteTemplate(int idTemplate);
        void DeleteTemplate();
    }
}
