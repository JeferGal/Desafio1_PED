using Desafío1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1.Tree
{
    class Nodo
    {
        public Paciente Paciente { get; set; }
        public List<Nodo> Punteros { get; } = new List<Nodo>(); // Lista de punteros
        public int Altura { get; private set; }

        public Nodo(Paciente paciente)
        {
            Paciente = paciente;
            Altura = 1;
        }

        public int FactorBalance
        {
            get
            {
                int alturaIzquierdo = Punteros.Count > 0 && Punteros[0] != null ? Punteros[0].Altura : 0;
                int alturaDerecho = Punteros.Count > 1 && Punteros[1] != null ? Punteros[1].Altura : 0;
                return alturaIzquierdo - alturaDerecho;
            }
        }

        public void ActualizarAltura()
        {
            int alturaIzquierdo = Punteros.Count > 0 && Punteros[0] != null ? Punteros[0].Altura : 0;
            int alturaDerecho = Punteros.Count > 1 && Punteros[1] != null ? Punteros[1].Altura : 0;
            Altura = 1 + Math.Max(alturaIzquierdo, alturaDerecho);
        }

        public void EstablecerPaciente(Paciente paciente)
        {
            // Asignar el paciente al nodo
            this.Paciente = paciente;
        }
    }
}