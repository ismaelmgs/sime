using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Clases
{
    public static class Utils
    {
        /// <summary>
        /// Obtiene el Id Empleado del usuario en session
        /// </summary>
        public static string GetIdEmpUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.sIdEmp = "9";
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).sIdEmp;
            }
        }

        /// <summary>
        /// Obtiene el nombre del usuario en session
        /// </summary>
        public static string GetNombreUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.sNombre = "(usuario)";
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).sNombre;
            }
        }
    }
}