    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProyectoArbol
    {
        class Nodo
        {
            //Inicializacion de las variables
            int numero;
            Nodo derecha;
            Nodo izquierda;

            //Importante: Tiene que retornar el mismo tipo que nuestra variable
            //Funcion para el Numero
            public int Numero{
                get { return numero; }
                set { numero = value; }
            }

            //Funcion para el nodo derecha
            public Nodo Derecha{
                get { return derecha; }
                set { derecha = value; }
            }

            //Funcion para el nodo izquierda
            public Nodo Izquierda{
                get { return izquierda; }
                set { izquierda = value; }
            }
        }
    }
