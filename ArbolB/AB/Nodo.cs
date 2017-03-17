using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public int pos;


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
            this.pos = 0;
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


        public bool Esletra()
        {
            try
            {
                int c = Id[pos];
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("es letra");
                return true;
            }

        }


        public int num()
        {
            string u = "dd";
            string n = Id[pos].ToString();
        
            if (Id[pos].GetType() == u.GetType())
            {
                int ac =  Encoding.ASCII.GetBytes(n)[0];
                return ac;
            }else
            {
                int ac=0;
                int.TryParse(n, out ac);
                return ac;
            }
        }


        public void nextletra()
        {
            pos++;
        }



    }
}