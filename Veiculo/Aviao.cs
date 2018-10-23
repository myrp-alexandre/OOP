using System;

namespace Veiculo
{
    public class Aviao : VeiculoBase
    {
        public int NumeroAsa { get; set; }
        public int QuantidadePoltronas { get; set; }

        public override void Acelerar()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Acelerando o Avião");
        }

        public override void Frear()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Freando o Avião");
        }
    }

    public class AviaoInterface : VeiculoInterface
    {
        public int NumeroAsa { get; set; }
        public int QuantidadePoltronas { get; set; }

        public void Acelerar()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Acelerando o Avião");
        }

        public void Frear()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Freando o Avião");
        }
    }
}
