namespace appLista
{
    public partial class Form1 : Form
    {
        Nodo? head = new Nodo();
        
        public Form1()
        {
            InitializeComponent();
            head = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo();
            n.Dato = txtDato.Text;
            if (head == null)
            {
                head = n;
            }
            else
            {
                n.Siguiente = head;
                head = n;
            }
            recorrer();
        }

        private void recorrer()
        {
            Nodo? r = new Nodo();
            r = head;
            string listadatos = "";
            while (r != null)
            {
                listadatos += r.ToString();
                r = r.Siguiente;
            }
            MessageBox.Show(listadatos);
        }
    }
}