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
        Pagina hijoIzquierdo;
        Pagina hijoDerecho;
        public int pos = 0;


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


        public Pagina HijoDerecho
        {
            get { return hijoDerecho; }
            set { hijoDerecho = value; }

        }

        public Pagina HijoIzquierdo
        {
            get { return hijoIzquierdo; }
            set { hijoIzquierdo = value; }
        }


        public int num()
        {

            string n = Id[pos].ToString();
            try
            {
                int ac = Encoding.ASCII.GetBytes(n)[0];
                return ac;
            }
            catch (Exception)
            {

                int ac;
                int.TryParse(n, out ac);
                return ac;
            }


        }


        public bool tieneHijoIzquierdo()
        {
            if (this.hijoIzquierdo == null)
            {
                return false;
            }
            else
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

        public void reiniciar()
        {
            pos = 0;
        }



    }
}