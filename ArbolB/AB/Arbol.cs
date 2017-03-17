using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB.AB
{
    public class Arbol
    {
        Nodo[] raiz = new Nodo[5];
        Nodo[] actual = new Nodo[5];
        int pos = 0;

        public void insertar(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo)
        {
            Nodo nuevo = new AB.Nodo(id, activo, usuario, empresa, depto, fecha, hora, tipo);
            actual = raiz;

            if (raiz[0] == null)
            {
                raiz[0] = nuevo;
                Console.WriteLine("se creo el primer nodo con "+ nuevo.Id);

            }
            else
            {
                if (actual[4] == null) //si no esta lleno :33
                {
                    bool exito = false;
                    while (!exito)
                    {
                        if (actual[pos] == null)
                        {
                            if (actual[pos - 1].tieneHijoDerecho())
                            {
                                insertarDerecha(actual[pos - 1].HijoDerecho, nuevo);
                            }
                        }

                        if (nuevo.num() < actual[pos].num())
                        {
                            if (actual[pos].tieneHijoIzquierdo())
                            {
                                InsertarIzquierda(actual[pos].HijoIzquierdo, nuevo);
                                exito = true;
                            }
                            else
                            {
                                pos++;
                            }
                        }
                        else if (nuevo.num() > actual[pos].num())
                        {

                        }
                        else if (nuevo.num() == actual[pos].num())
                        {
                            nuevo.nextletra();
                            actual[pos].nextletra();
                        }
                    }

                }

            }


        }

        private void insertarDerecha(Nodo[] hijoDerecho, Nodo nuevo)
        {
            throw new NotImplementedException();
        }

        private void InsertarIzquierda(Nodo[] actual, Nodo nuevo)
        {
            throw new NotImplementedException();
        }
    }