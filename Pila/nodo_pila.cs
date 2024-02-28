using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class nodo_pila
    {
        int dato;
        nodo_pila sig;
        public nodo_pila()
        {
            dato = 0;
            sig = null;
        }
        public void set_dato(int D)
        {
            dato = D;
        }
        public void set_sig(nodo_pila punt)
        {
            sig = punt;
        }
        public int get_dato()
        {
            return dato;
        }
        public nodo_pila get_sig()
        {
            return sig;
        }
    }
}