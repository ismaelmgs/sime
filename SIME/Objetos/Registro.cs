using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIME.Objetos
{
    [Serializable]
    public class Registro
    {
        private int _iIdCliente = 0;
        private int _iIdProveedor = 0;
        private int _Id_Tipo_Persona;
        private string _Razon_Social;
        private string _Sector;
        private string _Primer_Nombre;
        private string _Segundo_Nombre;
        private string _App_Pat;
        private string _App_Mat;
        private string _RFC;
        private string _Calle;
        private string _Num_Ext ;
        private string _Num_Int ;
        private string _CP;
        private string _Colonia;
        private string _Mpio_Del;
        private string _Ciudad;
        private string _Pais;
        private DateTime _Fec_Nac;
        private string _Identificacion;
        private int _Id_Status;
        private string _Usuario_Registro;
        private DateTime _Fecha_Registro;
        private string _Contacto_Servicios;
        private string _Tel_Cont_serv;
        private string _Mail_Cont_serv;
        private string _Contacto_Administrativo;
        private string _Tel_Cont_adm;
        private string _Mail_Cont_adm;


        public int iIdProveedor
        {
            get { return _iIdProveedor; }
            set { _iIdProveedor = value; }
        }

        public int iIdCliente
        {
            get { return _iIdCliente; }
            set { _iIdCliente = value; }
        }

        public int Id_Tipo_Persona
        {
            get { return _Id_Tipo_Persona; }
            set { _Id_Tipo_Persona = value; }
        }

        public string Razon_Social
        {
            get { return _Razon_Social; }
            set { _Razon_Social = value; }
        }

        public string Sector
        {
            get { return _Sector; }
            set { _Sector = value; }
        }

        public string Primer_Nombre
        {
            get { return _Primer_Nombre; }
            set { _Primer_Nombre = value; }
        }

        public string Segundo_Nombre
        {
            get { return _Segundo_Nombre; }
            set { _Segundo_Nombre = value; }
        }

        public string App_Pat
        {
            get { return _App_Pat; }
            set { _App_Pat = value; }
        }

        public string App_Mat
        {
            get { return _App_Mat; }
            set { _App_Mat = value; }
        }

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }

        public string Num_Ext
        {
            get { return _Num_Ext; }
            set { _Num_Ext = value; }
        }

        public string Num_Int
        {
            get { return _Num_Int; }
            set { _Num_Int = value; }
        }

        public string CP
        {
            get { return _CP; }
            set { _CP = value; }
        }

        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; }
        }

        public string Mpio_Del
        {
            get { return _Mpio_Del; }
            set { _Mpio_Del = value; }
        }

        public string Ciudad
        {
            get { return _Ciudad; }
            set { _Ciudad = value; }
        }

        public string Pais
        {
            get { return _Pais; }
            set { _Pais = value; }
        }

        public DateTime Fec_Nac
        {
            get { return _Fec_Nac; }
            set { _Fec_Nac = value; }
        }

        public string Identificacion
        {
            get { return _Identificacion; }
            set { _Identificacion = value; }
        }

        public int Id_Status
        {
            get { return _Id_Status; }
            set { _Id_Status = value; }
        }

        public string Usuario_Registro
        {
            get { return _Usuario_Registro; }
            set { _Usuario_Registro = value; }
        }

        public DateTime Fecha_Registro
        {
            get { return _Fecha_Registro; }
            set { _Fecha_Registro = value; }
        }

        public string Contacto_Servicios
        {
            get { return _Contacto_Servicios; }
            set { _Contacto_Servicios = value; }
        }

        public string Tel_Cont_serv
        {
            get { return _Tel_Cont_serv; }
            set { _Tel_Cont_serv = value; }
        }

        public string Mail_Cont_serv
        {
            get { return _Mail_Cont_serv; }
            set { _Mail_Cont_serv = value; }
        }

        public string Contacto_Administrativo
        {
            get { return _Contacto_Administrativo; }
            set { _Contacto_Administrativo = value; }
        }

        public string Tel_Cont_adm
        {
            get { return _Tel_Cont_adm; }
            set { _Tel_Cont_adm = value; }
        }

        public string Mail_Cont_adm
        {
            get { return _Mail_Cont_adm; }
            set { _Mail_Cont_adm = value; }
        }
    }
}