using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    class Arbol
    {
        //Inicializacion de las variables
        Nodo raiz;
        Nodo nuevo;

        //Contructor de la clase -> Arbol
        public Arbol()
        {
            raiz = null;
            nuevo = null;
        }

        //Funcion para crear nuestro nuevo nodo
        public void crearNodo(int numeroEntrada)
        {
            nuevo = new Nodo();
            nuevo.Numero = numeroEntrada;
            nuevo.Derecha = null;
            nuevo.Izquierda = null;
        }

        //Funcion para hacer la creacion del arbol
        public void crearArbol(int numeroEntrada)
        {
            crearNodo(numeroEntrada);
            //Cuando no hay nada en la raiz
            if (raiz == null)
            {
                raiz = nuevo;
            }
            //Cuando la raiz ya tiene un numero
            else
            {
                Nodo auxiliar;
                auxiliar = raiz;
                while(auxiliar != null)
                {
                    if (numeroEntrada > auxiliar.Numero)
                    {
                        if (auxiliar.Derecha == null)
                        {
                            auxiliar.Derecha = nuevo;
                            auxiliar = null;
                        }
                        else
                        {
                            auxiliar = auxiliar.Derecha;
                        }
                    }
                    else
                    {
                        if (auxiliar.Izquierda == null)
                        {
                            auxiliar.Izquierda = nuevo;
                            auxiliar = null;
                        }
                        else
                        {
                            auxiliar = auxiliar.Izquierda;
                        }
                    }
                }
            }
        }

        //Funcion para devolver la raiz
        public Nodo devolverRaiz()
        {
            return raiz;
        }
    }
}
