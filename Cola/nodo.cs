using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCOLA
{
    class nodo
    {
        int dato;
        nodo sig;
        public int Dato { 
            get {
                return dato;    
            } 
            set {
                dato = value;
            } 
        }
        public nodo Sig
        {
            get { 
                return sig; 
            } 
            set {
                sig = value;
            }
        }
        public nodo(int _dato)
        {
            dato = _dato;
        }
    }
}
