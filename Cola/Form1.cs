namespace ProyectoCOLA
{
    public partial class Form1 : Form
    {
        Cola col;
        public Form1()
        {
            col= new Cola();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textBox1.Text);
            col.encolar(valor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se desencolo la variable");
            listBox1.Items.RemoveAt(0); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(col.func_frente()==null){
                MessageBox.Show("Primero inserte un elemento");
            }
            else
            {
                listBox1.Items.Clear();
                mostrarCola();
            }
        }
        public void mostrarCola()
        {
            nodo aux;
            aux= col.func_frente();
            while (aux != null)
            {
                listBox1.Items.Add("Dato: "+aux.Dato);
                aux = aux.Sig;
            }
        }
    }
}