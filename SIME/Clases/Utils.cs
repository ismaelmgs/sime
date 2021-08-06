using SIME.Objetos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace SIME.Clases
{
    public static class Utils
    {
        /// <summary>
        /// Metodo para convertir una imagen en byte
        /// </summary>
        /// <param name="img">Imagen</param>
        /// <returns></returns>
        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }
        
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

        /// <summary>
        /// Obtiene el email del usuario en session
        /// </summary>
        public static string GetMailUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.sCorreoE = "(correo@mail)";
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).sCorreoE;
            }
        }

        /// <summary>
        /// Obtiene el perfil del usuario en session
        /// </summary>
        public static int GetPerfilUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.iPerfil = 0;
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).iPerfil;
            }
        }

        /// <summary>
        /// Obtiene el id del usuario en el sistema para proveedores
        /// </summary>
        public static int GetIdProveedor
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.iIdSistema = 0;
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).iIdSistema;
            }
        }

        /// <summary>
        /// Obtiene el nombre del perfil del usuario en session
        /// </summary>
        public static string GetDescPerfilUsuario
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserIdentity"] == null)
                {
                    UserIdentity oUsuario = new UserIdentity();
                    oUsuario.sDescPerfil = string.Empty;
                    System.Web.HttpContext.Current.Session["UserIdentity"] = oUsuario;
                }

                return ((UserIdentity)System.Web.HttpContext.Current.Session["UserIdentity"]).sDescPerfil;
            }
        }

        /// <summary>
        /// Convierte string en Base64 a texto
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static string DecodeBase64ToString(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            return myStr;
        }

        /// <summary>
        /// Convierte texto string en Base64
        /// </summary>
        /// <param name="valor">Valor a reemplazar</param>
        /// <returns></returns>
        public static string EncodeStrToBase64(string valor)
        {
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
            string myBase64 = Convert.ToBase64String(myByte);
            return myBase64;
        }
    }
}