using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLista
{
    internal class Nodo
    {
		private string dato;
		public string Dato
		{get { return dato; }
			set { dato = value; }
		}

		private Nodo siguiente;
		public Nodo Siguiente
		{
			get { return siguiente; }
			set { siguiente = value; }
		}

		public Nodo()
		{
			dato = "";
			siguiente = null;
		}

		public Nodo(string dato,Nodo siguiente)
		{
			this.dato = dato;
			Siguiente = siguiente;
		}

		public override string ToString()
		{
			return " - " + dato;
		}
	}
}
