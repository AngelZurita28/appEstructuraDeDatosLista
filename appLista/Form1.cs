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
                string nuevoDato = n.Dato;
                string datoExistente = head.Dato;
                if (String.Compare(nuevoDato, datoExistente) == -1)
                {
                    n.Siguiente = head;
                    head = n;
                }
                else
                {
                    n.Siguiente = head;
                    head = n;
                    head.Dato = datoExistente;
                    head.Siguiente.Dato = nuevoDato;
                }
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(txtDato.Text);
        }
        private void Eliminar(string d)
        {
            if (head.Dato == d)
            {
                head = head.Siguiente;
                recorrer();
                return;
            }

            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato == d)
                {
                    h.Siguiente = h.Siguiente.Siguiente;
                    recorrer();
                    break;
                }
                h = h.Siguiente;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            recorrer();
        }
    }
}