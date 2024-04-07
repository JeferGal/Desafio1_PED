using Desafío1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1.Tree
{
    class ArbolPacientes
    {
        private Nodo raiz;

        public ArbolPacientes()
        {
            raiz = null;
        }

        public void Insertar(Paciente paciente)
        {
            raiz = InsertarRecursivo(raiz, paciente);
        }

        private Nodo InsertarRecursivo(Nodo nodo, Paciente paciente)
        {
            if (nodo == null)
            {
                return new Nodo(paciente);
            }

            int comparacion = paciente.CompareTo(nodo.Paciente);
            if (comparacion < 0)
            {
                if (nodo.Punteros.Count == 0)
                {
                    nodo.Punteros.Add(null);
                    nodo.Punteros.Add(null);
                }
                nodo.Punteros[0] = InsertarRecursivo(nodo.Punteros[0], paciente);
            }
            else if (comparacion > 0)
            {
                if (nodo.Punteros.Count == 0)
                {
                    nodo.Punteros.Add(null);
                    nodo.Punteros.Add(null);
                }
                nodo.Punteros[1] = InsertarRecursivo(nodo.Punteros[1], paciente);
            }
            else
            {
                Console.WriteLine("El paciente ya existe en el árbol.");
            }

            // Actualizar la altura del nodo actual
            nodo.ActualizarAltura();

            // Realizar las rotaciones necesarias para balancear el árbol
            return Balancear(nodo);
        }

        private Nodo Balancear(Nodo nodo)
        {
            int factorBalance = nodo.FactorBalance;

            // Implementar rotaciones según el factor de balance

            return nodo;
        }

        public void MostrarPacientes()
        {
            MostrarRecursivo(raiz);
        }

        private void MostrarRecursivo(Nodo nodo)
        {
            if (nodo != null)
            {
                if (nodo.Punteros.Count > 0 && nodo.Punteros[0] != null)
                {
                    MostrarRecursivo(nodo.Punteros[0]);
                }

                Console.WriteLine(nodo.Paciente);

                if (nodo.Punteros.Count > 1 && nodo.Punteros[1] != null)
                {
                    MostrarRecursivo(nodo.Punteros[1]);
                }
            }
        }

        public Paciente BuscarPorNumeroExpediente(string numeroExpediente)
        {
            return BuscarPorNumeroExpedienteRecursivo(raiz, numeroExpediente);
        }

        private Paciente BuscarPorNumeroExpedienteRecursivo(Nodo nodo, string numeroExpediente)
        {
            if (nodo == null)
            {
                return null;
            }

            int comparacion = numeroExpediente.CompareTo(nodo.Paciente.NumeroExpediente);

            if (comparacion == 0)
            {
                return nodo.Paciente;
            }
            else if (comparacion < 0)
            {
                return BuscarPorNumeroExpedienteRecursivo(nodo.Punteros[0], numeroExpediente);
            }
            else
            {
                return BuscarPorNumeroExpedienteRecursivo(nodo.Punteros[1], numeroExpediente);
            }
        }

        public void EliminarPorNumeroExpediente(string numeroExpediente)
        {
            raiz = EliminarPorNumeroExpedienteRecursivo(raiz, numeroExpediente);
        }

        private Nodo EliminarPorNumeroExpedienteRecursivo(Nodo nodo, string numeroExpediente)
        {
            if (nodo == null)
            {
                return null;
            }

            int comparacion = numeroExpediente.CompareTo(nodo.Paciente.NumeroExpediente);

            if (comparacion < 0)
            {
                nodo.Punteros[0] = EliminarPorNumeroExpedienteRecursivo(nodo.Punteros[0], numeroExpediente);
            }
            else if (comparacion > 0)
            {
                nodo.Punteros[1] = EliminarPorNumeroExpedienteRecursivo(nodo.Punteros[1], numeroExpediente);
            }
            else
            {
                // Casos de eliminación
                if (nodo.Punteros[0] == null || nodo.Punteros[1] == null)
                {
                    Nodo temp = nodo.Punteros[0] != null ? nodo.Punteros[0] : nodo.Punteros[1];
                    if (temp == null)
                    {
                        return null;
                    }
                    else
                    {
                        return temp;
                    }
                }
                else
                {
                    Nodo sucesor = EncontrarSucesor(nodo.Punteros[1]);
                    nodo.Paciente = sucesor.Paciente;
                    nodo.Punteros[1] = EliminarPorNumeroExpedienteRecursivo(nodo.Punteros[1], sucesor.Paciente.NumeroExpediente);
                }
            }

            nodo.ActualizarAltura();
            return Balancear(nodo);
        }

        private Nodo EncontrarSucesor(Nodo nodo)
        {
            Nodo actual = nodo;
            while (actual.Punteros[0] != null)
            {
                actual = actual.Punteros[0];
            }
            return actual;
        }
    }
}
