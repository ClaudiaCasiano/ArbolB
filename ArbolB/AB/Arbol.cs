using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB.AB
{
    ///*
    // Que se hace ya?
    //1. se incerta el primero
    //2. se incerta a la derecha normalmente con arbol no lleno
    //3. 
    //  */




    //public class Arbol
    //{
    //    Pagina raiz = new Pagina();
    //    Pagina actual = new Pagina();
    //    int pos = 0;

    //    public void insertar(string id, string activo, string usuario, string empresa, string depto, string fecha, string hora, string tipo)
    //    {
    //        pos = 0;
    //        Nodo nuevo = new Nodo(id, activo, usuario, empresa, depto, fecha, hora, tipo);
    //        actual = raiz;



    //        if (raiz.estaVacia())
    //        {
    //            raiz.insert(nuevo);
    //            Console.WriteLine("se creo el primer nodo con " + nuevo.Id);

    //        }
    //        else
    //        {
    //            actual.Claves[pos].reiniciar();
    //            Console.WriteLine("La raiz No esta vacia");

    //            if (!actual.Estalleno()) //si no esta lleno :33
    //            {
    //                bool exito = false; //bool que indica si seguri con el ciclo
    //                while (!exito)//mientras no haya exito
    //                {
    //                    if (actual.Claves[pos] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
    //                    {
    //                        if (actual.Claves[pos - 1].tieneHijoDerecho()) //Si la posicion actual -1 tiene un hijo derecho
    //                        {
    //                            pos = 0;                //la posicion es cero
    //                            InsertarEnHijo(actual.Claves[pos - 1].HijoDerecho, nuevo); //se mandara el hijo derecho a una insercion derecha
    //                            exito = true;
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            insertarDerechaNormal(actual, nuevo, pos);//este va a insertar el nodo normal y verifica si la pagina esta llena
    //                            exito = true;
    //                            break;
    //                        }
    //                    }
    //                    else if (nuevo.num() < actual.Claves[pos].num())//si es menor
    //                    {
    //                        Console.WriteLine("el primero es menor " + nuevo.num() + " y " + actual.Claves[pos].num());
    //                        if (actual.Claves[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
    //                        {
    //                            InsertarEnHijo(actual.Claves[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
    //                            exito = true;
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            insertarIzquierdoNormal(actual, nuevo, pos);// se inserta normal y verifica si se llena la pagina
    //                            exito = true;
    //                            break;
    //                        }
    //                    }
    //                    else if (nuevo.num() > actual.Claves[pos].num()) //si es mayor solo se mueve una posicion
    //                    {
    //                        Console.WriteLine("el primero es mayor " + nuevo.num() + " y " + actual.Claves[pos].num());
    //                        pos++;
    //                        if (actual.Claves[pos] != null)
    //                        {
    //                            actual.Claves[pos].reiniciar();
    //                        }

    //                    }
    //                    else if (nuevo.num() == actual.Claves[pos].num())
    //                    {
    //                        Console.WriteLine("SUPUESTAMENTE " + nuevo.num() + " y " + actual.Claves[pos].num() + "son iguales");
    //                        nuevo.nextletra();
    //                        actual.Claves[pos].nextletra();
    //                    }
    //                }

    //            }

    //        }


    //    }

    //    private void insertarIzquierdoNormal(Pagina actual, Nodo nuevo, int posi)
    //    {
    //        Nodo aux1 = actual.Claves[posi];
    //        Nodo aux = actual.Claves[posi];
    //        actual.Claves[posi] = nuevo;

    //        for (int i = pos + 1; i < 5; i++)
    //        {
    //            if (aux1 != null)
    //            {
    //                aux1 = actual.Claves[i];
    //                actual.Claves[i] = aux;
    //                aux = aux1;

    //            }
    //            else
    //            {
    //                break;
    //            }
    //        }
    //        Console.WriteLine("se incerto " + actual.Claves[posi].Id + " a la izquierda de " + actual.Claves[posi + 1].Id);

    //        if (actual.Estalleno())//significa que esta lleno
    //        {
    //            moverNodos(actual);
    //        }



    //    }

    //    private void insertarDerechaNormal(Pagina actual, Nodo nuevo, int posi) // solo inserta a la derecha, por lo tanto actual.Claves[pos] siempre sera un valor nulo
    //    {
    //        actual.Claves[posi] = nuevo;
    //        Console.WriteLine("se inserto el " + actual.Claves[posi].Id + " a la derecha de " + actual.Claves[posi - 1].Id);
    //        if (posi == 4)
    //        {  //si se llena la pagina
    //            moverNodos(actual);
    //        }

    //    }



    //    private void InsertarEnHijo(Pagina pagina, Nodo nuevo)
    //    {
    //        pos = 0;
    //        actual = pagina;
    //        bool exito = false; //bool que indica si seguri con el ciclo
    //        while (!exito)//mientras no haya exito
    //        {
    //            if (actual.Claves[pos] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
    //            {
    //                if (actual.Claves[pos - 1].tieneHijoDerecho()) //Si la posicion actual -1 tiene un hijo derecho
    //                {
    //                    pos = 0;                //la posicion es cero
    //                    InsertarEnHijo(actual.Claves[pos - 1].HijoDerecho, nuevo); //se mandara el hijo derecho a una insercion derecha
    //                    exito = true;
    //                }
    //                else
    //                {
    //                    insertarDerechaNormal(actual, nuevo, pos);//este va a insertar el nodo normal y verifica si la pagina esta llena
    //                    exito = true;
    //                }
    //            }

    //            else if (nuevo.num() < actual.Claves[pos].num())//si es menor
    //            {
    //                if (actual.Claves[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
    //                {
    //                    InsertarEnHijo(actual.Claves[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
    //                    exito = true;
    //                }
    //                else
    //                {
    //                    insertarIzquierdoNormal(actual, nuevo, pos);// se inserta normal y verifica si se llena la pagina
    //                    exito = true;
    //                }
    //            }
    //            else if (nuevo.num() > actual.Claves[pos].num()) //si es mayor solo se mueve una posicion
    //            {
    //                pos++;
    //            }
    //            else if (nuevo.num() == actual.Claves[pos].num())
    //            {
    //                nuevo.nextletra();
    //                actual.Claves[pos].nextletra();
    //            }
    //        }

    //    }


    //    private void moverNodos(Pagina pagina)
    //    {
    //        actual = pagina;
    //        Nodo aux = actual.Claves[2];
    //        Pagina nuevoIzq = new Pagina();
    //        Pagina nuevoDer = new Pagina();
    //        nuevoIzq.Claves[0] = actual.Claves[0];
    //        nuevoIzq.Claves[1] = actual.Claves[1];
    //        nuevoDer.Claves[0] = actual.Claves[3];
    //        nuevoDer.Claves[1] = actual.Claves[4];

    //        //aux.HijoDerecho = nuevoDer;
    //        aux.HijoIzquierdo = nuevoIzq;

    //        if (actual.Padre == null)
    //        {
    //            Pagina nuevaraiz = new Pagina();
    //            aux.HijoDerecho = nuevoDer;
    //            nuevaraiz.Claves[0] = aux;
    //        }

    //        else
    //        {
    //            Pagina padre = actual.Padre;
    //            bool exito = false;
    //            int posb = 0;
    //            while (!exito)//mientras no haya exito

    //            {
    //                if (padre.Claves[posb] == null)//si la posicion actual es nada, por ejemplo en insertar un 30 y los datos son [10|20| | | ]
    //                {
    //                    padre.Claves[posb - 1].HijoDerecho = null;
    //                    aux.HijoDerecho = nuevoDer;
    //                    insertarDerechaNormal(padre, aux, posb);//este va a insertar el nodo normal y verifica si la pagina esta llena

    //                }

    //                else if (aux.num() < actual.Claves[pos].num())//si es menor
    //                {
    //                    //if (actual.Claves[pos].tieneHijoIzquierdo())//revisa si hay un hijo antes del numero encontrado
    //                    //{
    //                    //    InsertarEnHijo(actual.Claves[pos].HijoIzquierdo, nuevo);//se manda a insertar abajo
    //                    //    exito = true;
    //                    //}
    //                    //else
    //                    //{
    //                    //    insertarIzquierdoNormal(actual, nuevo, pos);// se inserta normal y verifica si se llena la pagina
    //                    //}
    //                }
    //                //else if (nuevo.num() > actual.Claves[pos].num()) //si es mayor solo se mueve una posicion
    //                //{
    //                //    pos++;
    //                //}
    //                //else if (nuevo.num() == actual.Claves[pos].num())
    //                //{
    //                //    nuevo.nextletra();
    //                //    actual.Claves[pos].nextletra();
    //                //}
    //            }

    //        }


    //    }


    }
