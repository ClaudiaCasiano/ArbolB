using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB.AB
{
    /*
     Que se hace ya?

    1. se incerta el primero
    2. se incerta a la derecha normalmente con arbol no lleno
    3. 
         
         
         */




    public class Arbol
    {
        Nodo[] raiz = new Nodo[5];
        Nodo[] actual = new Nodo[5];
        int pos = 0;

        public void insertar(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo)
        {
            pos = 0;
            Nodo nuevo = new AB.Nodo(id, activo, usuario, empresa, depto, fecha, hora, tipo);
            actual = raiz;

            if (raiz[0] == null)
            {
                raiz[0] = nuevo;
                Console.WriteLine("se creo el primer nodo con " + nuevo.Id);

            }
            else
            {
                if (actual[4] == null) //si no esta lleno :33
                {
                    bool exito = false; //bool que indica si seguri con el ciclo
                    while (!exito)//mientras no haya exito
                    {
                        if (actual[pos] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
                        {
                            if (actual[pos - 1].tieneHijoDerecho()) //Si la posicion actual -1 tiene un hijo derecho
                            {
                                pos = 0;                //la posicion es cero
                                InsertarEnHijo(actual[pos - 1].HijoDerecho, nuevo); //se mandara el hijo derecho a una insercion derecha
                                exito = true;
                            }
                            else
                            {
                                insertarDerechaNormal(actual, nuevo, pos);//este va a insertar el nodo normal y verifica si la pagina esta llena
                            }
                        }

                        else if (nuevo.num() < actual[pos].num())//si es menor
                        {
                            if (actual[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
                            {
                                InsertarEnHijo(actual[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
                                exito = true;
                            }
                            else
                            {
                                insertarIzquierdoNormal(actual,nuevo, pos);// se inserta normal y verifica si se llena la pagina
                            }
                        }
                        else if (nuevo.num() > actual[pos].num()) //si es mayor solo se mueve una posicion
                        {
                            pos++;
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

        private void insertarIzquierdoNormal(Nodo[] actual, Nodo nuevo, int posi)
        {
            Nodo aux1 = actual[posi];
            Nodo aux = actual[posi];
            actual[posi] = nuevo;

            for (int i = pos +1  ; i < 5; i++)
            {
                if(aux1!= null){
                    aux1 = actual[i];
                    actual[i] = aux;
                    aux = aux1;

                }
                else
                {
                    break;
                }
            }

            if (actual[4]!= null)//significa que esta lleno
            {
                moverNodos(actual);
            }



        }

        private void insertarDerechaNormal(Nodo[] actual, Nodo nuevo, int posi) // solo inserta a la derecha, por lo tanto actual[pos] siempre sera un valor nulo
        {
            actual[posi] = nuevo;
            if (posi == 4)
            {  //si se llena la pagina
                moverNodos(actual);
            }

        }



        private void InsertarEnHijo(Nodo[] matriz, Nodo nuevo)
        {
            pos = 0;
            actual = matriz;
            bool exito = false; //bool que indica si seguri con el ciclo
            while (!exito)//mientras no haya exito
            {
                if (actual[pos] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
                {
                    if (actual[pos - 1].tieneHijoDerecho()) //Si la posicion actual -1 tiene un hijo derecho
                    {
                        pos = 0;                //la posicion es cero
                        InsertarEnHijo(actual[pos - 1].HijoDerecho, nuevo); //se mandara el hijo derecho a una insercion derecha
                        exito = true;
                    }
                    else
                    {
                        insertarDerechaNormal(actual, nuevo, pos);//este va a insertar el nodo normal y verifica si la pagina esta llena
                    }
                }

                else if (nuevo.num() < actual[pos].num())//si es menor
                {
                    if (actual[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
                    {
                        InsertarEnHijo(actual[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
                        exito = true;
                    }
                    else
                    {
                        insertarIzquierdoNormal(actual, nuevo, pos);// se inserta normal y verifica si se llena la pagina
                    }
                }
                else if (nuevo.num() > actual[pos].num()) //si es mayor solo se mueve una posicion
                {
                    pos++;
                }
                else if (nuevo.num() == actual[pos].num())
                {
                    nuevo.nextletra(); 
                    actual[pos].nextletra();
                }
            }

        }


        private void moverNodos(Nodo[] matriz)
        {
            actual = matriz;
            Nodo aux = actual[2];
            Nodo[] nuevoIzq = new Nodo[5];
            Nodo[] nuevoDer = new Nodo[5];
            nuevoIzq[0] = actual[0];
            nuevoIzq[1] = actual[1];
            nuevoDer[0] = actual[3];
            nuevoDer[1] = actual[4];

            aux.HijoDerecho = nuevoDer;
            aux.HijoIzquierdo = nuevoIzq;

            if (actual[0].tienePadre)
            {
                
            }


        }


    }
}
