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
        Nodo[] hijoIzquierdo;
        Nodo[] hijoDerecho;
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
            this.hijoDerecho = null;
            this.hijoIzquierdo = null;
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


        public Nodo [] HijoDerecho
        {
            get{ return hijoDerecho; }
            set { hijoDerecho = value}

        }

        public Nodo[] HijoIzquierdo
        {
            get { return hijoIzquierdo; }
            set { hijoIzquierdo = value; }
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


       public bool tieneHijoIzquierdo()
        {
            if (this.hijoIzquierdo == null)
            {
                return false;
            }else
            {
                return true;
            }
        }


        public bool tieneHijoDerecho()
        {
            if (this.hijoDerecho == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void nextletra()
        {
            pos++;
        }



    }
}