using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB.AB
{
    public class Arbol
    {
        Nodo[] raiz = new Nodo[5];
        Nodo [] actual= new Nodo[5];
        int pos = 0;

        public void insertar(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo)
        {
            Nodo nuevo = new AB.Nodo(id, activo, usuario, empresa, depto, fecha, hora, tipo);
            actual = raiz;

            if(raiz[0]==null)
            {
                raiz[0] = nuevo;

            }else
            {
                if (actual[4] == null)
                {
                    bool exito = false;
                    while (!exito)
                    {
                        if ((nuevo.Esletra() &&  actual[pos].Esletra()) || nuevo.num() < actual[pos].num())
                        {

                        }
                    }

            }



        }


    }
}