using System;
using System.Collections.Generic;
using System.Text;
using FingerprintNetSample.DB;
using FingerprintNetSample.DB.Dal;

namespace FingerprintNetSample.DB
{
    public enum GrConnector
    {
        AccessDal
    }
    
    public abstract class DalFactory
    {
        public static IGRDal GetDal(GrConnector connector) 
        {
            switch (connector) 
            {
                case GrConnector.AccessDal: return (IGRDal) Activator.CreateInstance(typeof(AccessDataAccessLayer), true);

                default: return null;
            }
        }
    }
}
