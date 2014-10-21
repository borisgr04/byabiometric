using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using Entidades;
using ByA;

namespace BLL
{
    public class Autentificacion
    {
        bd_esEntities ctx;
        public es_rtpLogin Login(string usuario, string password)
        {
            es_rtpLogin res = new es_rtpLogin();
            using (ctx = new bd_esEntities())
            {
                usuarios usu = ctx.usuarios.Where(t => t.Usuario == usuario && t.Contraseña == password).FirstOrDefault();
                if (usu != null)
                {
                    res.permiso = true;
                    res.rol = usu.Rol;
                }
                else
                {
                    res.permiso = false;
                }
            }
            return res;
        }
    }
}
