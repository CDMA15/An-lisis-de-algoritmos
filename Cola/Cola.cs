using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCOLA
{
    class Cola
    {
        nodo frente, final, nuevo;
        public Cola() {
            frente = null;
            final = null;
            nuevo = null;
        }
        public void encolar(int dato)
        {
            nuevo = new nodo(dato);
            if (frente == null){
                frente = nuevo;
            }
            else
            {
                final.Sig = nuevo;
            }
            final = nuevo;
        }
        public nodo desencolar()
        {
            nodo aux = frente;
            frente = frente.Sig;
            aux.Sig = null;
            return aux;
        }
        public nodo func_frente()
        {
            return frente;
        }
        public nodo func_final()
        {
            return final;
        }
    }
}
