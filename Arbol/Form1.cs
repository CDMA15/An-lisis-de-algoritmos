using System.Windows.Forms;

namespace ProyectoArbol
{
    public partial class Form1 : Form
    {
        //Inicializacion de las variables
        Arbol arbol;
        Nodo nodo;
        int contador, Cant;
        //Constructor del formulario
        public Form1()
        {
            //Para poder acceder a nuestra clase nodo o a nuestra clase arbol
            arbol = new Arbol();
            nodo = new Nodo();
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBoxNumero.Text);
            arbol.crearArbol(numero);
            textBoxNumero.Clear();
            textBoxNumero.Focus();
        }

        private void buttonMostrarPreOrden_Click(object sender, EventArgs e)
        {
            listBoxArbol.Items.Clear();
            Nodo auxiliar;
            //primer paso del pre-orden -> agarrar el valor de la raiz
            auxiliar = arbol.devolverRaiz();
            //Sgte paso es hacer el recorrido del pre-orden
            preOrden(auxiliar);
        }

        //Funcion para realizar el pre-orden -> Con recursividad
        private void preOrden(Nodo numeroPreOrden)
        {
            if (numeroPreOrden != null)
            {
                listBoxArbol.Items.Add(numeroPreOrden.Numero);
                preOrden(numeroPreOrden.Izquierda);
                preOrden(numeroPreOrden.Derecha);
            }
        }
        //Mostrar Nodo
        private void buttonMostrarNodos_Click(object sender, EventArgs e)
        {
            Nodo aux;
            aux = arbol.devolverRaiz();
            contador = 0;
            int numeroDeNodos = contar(aux);
            listBoxNodo.Items.Add(numeroDeNodos);
        }
        private int contar(Nodo aux)
        {
            if (aux != null)
            {
                contador++;
                contar(aux.Izquierda);
                contar(aux.Derecha);
            }
            return contador;
        }
        //Mostrar cantidad de hojas
        private void buttonMostrarHojas_Click(object sender, EventArgs e)
        {
            int y = CantidadNodosHoja();
            listBoxHoja.Items.Add("total " + y);
        }
        public int CantidadNodosHoja()
        {
            Cant = 0;
            CantidadNodosHoja(arbol.devolverRaiz());
            return Cant;
        }
        private void CantidadNodosHoja(Nodo reco)
        {
            if (reco != null)
            {
                if (reco.Izquierda == null && reco.Derecha == null)
                {
                    Cant++;
                    listBoxHoja.Items.Add("Nodo hoja: " + reco.Numero);
                }
                CantidadNodosHoja(reco.Izquierda);
                CantidadNodosHoja(reco.Derecha);
            }
        }
    }
}