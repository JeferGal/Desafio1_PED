using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desafío1.Enum.EnumGenero;
using static Desafío1.Enum.EnumPresion;
using static Desafío1.Enum.EnumTipoSangre;

namespace Desafío1.Models
{
    class Paciente : IComparable<Paciente>
    {
        public string NumeroExpediente { get; }
        public string Nombre { get; }
        public Genero Genero { get; }
        public TipoSangre TipoSangre { get; }
        public PresionArterial PresionArterial { get; }

        public Paciente(string numeroExpediente, string nombre, Genero genero, TipoSangre tipoSangre, PresionArterial presionArterial)
        {
            NumeroExpediente = numeroExpediente;
            Nombre = nombre;
            Genero = genero;
            TipoSangre = tipoSangre;
            PresionArterial = presionArterial;
        }

        public override string ToString()
        {
            return $"{NumeroExpediente}, {Nombre}, {Genero}, {TipoSangre}, {PresionArterial}";
        }

        public int CompareTo(Paciente other)
        {
            return NumeroExpediente.CompareTo(other.NumeroExpediente);
        }
    }
}