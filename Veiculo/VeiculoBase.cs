using System;

namespace Veiculo
{
    public abstract class VeiculoBase
    {
        public int CapacidadeTanque { get; set; }

        public abstract void Acelerar();
        public abstract void Frear();

        public void ExibirCapacidadeTanque()
        {
            Console.WriteLine("Capacidade: {0} litros", CapacidadeTanque);
        }
    }
}