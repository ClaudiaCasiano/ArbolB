using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB.AB
{
    public class Pagina
    {
        Pagina padre;
        int nodos; //cantidad de nodos disponibles
        int noclaves = 4;
        Nodo[] claves;



        public Pagina()
        {
            this.padre = null;
            this.nodos = 0;
            claves = new Nodo[5];
        }


        public Nodo[] Claves
        {
            get { return claves; }
            set { claves = value; }
        }


        public void insert(Nodo clave)
        {
            Nodo nuevo = clave;
            if (nodos <= noclaves)
            {
                Claves[nodos] = nuevo;
                Claves[nodos].reiniciar();
                this.nodos++;

            }
        }

        public Pagina Padre
        {
            get { return padre; }
            set { padre = value; }
        }


        public bool estaVacia()
        {
            if (this.nodos == 0)
            {
                return true;
            }
            return false;
        }

        public bool Estalleno()
        {
            if (nodos == noclaves)
            {
                return true;
            }
            return false;
        }



    }
}