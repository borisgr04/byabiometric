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

        public ByARpt CambioContraseña(string uRol, string antiguoPassword, string newPassword)
        {
            ByARpt res = new ByARpt();
            using (ctx = new bd_esEntities())
            {
                usuarios usuario = ctx.usuarios.Where(t => t.Usuario == uRol).FirstOrDefault();
                if (usuario.Contraseña == antiguoPassword)
                {
                    usuario.Contraseña = newPassword;
                    try
                    {
                        ctx.SaveChanges();
                        res.Error = false;
                        res.Mensaje = "Se cambio contraseña";
                    }
                    catch
                    {
                        res.Error = true;
                        res.Mensaje = "No se pudo cambiar contraseña...";
                    }
                }
                else
                {
                    res.Error = true;
                    res.Mensaje = "La contraseña antigua no es correcta...";
                }
            }
            return res;
        }
    }
}
