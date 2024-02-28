namespace Pila
{
    public partial class Form1 : Form
    {
        Pila miPila;
        Pila auxpila;
        public Form1()
        {
            miPila = new Pila();
            auxpila = new Pila();
            InitializeComponent();
        }

        private void Bto_apilar_Click(object sender, EventArgs e)
        {
            int d;
            if (nombre.Text == "")
            {
                MessageBox.Show("ingrese un dato");
            }
            else
            {
                d = int.Parse(nombre.Text);
                miPila.apilar(d);
                nombre.Clear();
                nombre.Focus();
            }
        }

        private void Mostrar_Pila_Click(object sender, EventArgs e)
        {
            if (miPila.devolver_tope_o_cima() == null)
            {
                MessageBox.Show("vacio");
            }
            else
            {
                listBoxPila.Items.Clear();
                copiarpila();
            }
        }
        private void copiarpila()
        {
            nodo_pila aux;
            while (miPila.devolver_tope_o_cima() != null)
            {
                aux = miPila.desapilar();
                listBoxPila.Items.Add(aux.get_dato());
                //MessageBox.Show(aux.get_dato().ToString());
                auxpila.apilar(aux.get_dato());
            }
            while (auxpila.devolver_tope_o_cima() != null)
            {
                aux = auxpila.desapilar();
                //MessageBox.Show(aux.get_dato().ToString() + "pila aux");
                miPila.apilar(aux.get_dato());
            }
        }

        private void bto_desapilar_Click(object sender, EventArgs e)
        {
            nodo_pila aux = miPila.desapilar();
            if (miPila.devolver_tope_o_cima() == null)
            {
                MessageBox.Show("existen errores");
            }
            else
            {
                MessageBox.Show("Se esta desapilando el numero: " + aux.get_dato().ToString());
                listBoxPila.Items.Clear();
                Mostrar_Pila_Click(sender, e);
            }
        }

        private void listBoxPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}