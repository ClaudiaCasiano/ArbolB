using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB.AB
{
    public class Nodo
    {

        string id;
        string activo;
        string usuario;
        string empresa;
        string depto;
        string fecha;
        string hora;
        string tipo;


        public Nodo(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo)
        {
            this.id = id;
            this.activo = activo;
            this.usuario = usuario;
            this.empresa = empresa;
            this.depto = depto;
            this.fecha = fecha;   
            this.hora = hora;
            this.tipo = tipo;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


    }
}