using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Pila
    {
        nodo_pila tope, nuevo;
        public Pila()
        {
            tope = null;
            nuevo = null;
        }
        public void crear_nodo(int n)
        {
            nuevo = new nodo_pila();
            nuevo.set_dato(n);
            nuevo.set_sig(null);
        }
        public string apilar(int n)
        {
            crear_nodo(n);
            nuevo.set_sig(tope);
            tope = nuevo;
            return ("EL NUMERO FUE APILADO");
        }
        public nodo_pila desapilar()
        {
            nodo_pila aux;
            aux = tope;
            tope = tope.get_sig();
            aux.set_sig(null);
            return aux;
        }
        public nodo_pila devolver_tope_o_cima()
        {
            return tope;
        }
    }
}
