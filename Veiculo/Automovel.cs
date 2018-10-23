using System;

namespace Veiculo
{
    public class Automovel : VeiculoBase
    {
        public int NumeroSteps { get; set; }

        public override void Acelerar()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Acelerando o carro");
        }

        public override void Frear()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Parando o carro");
        }
    }

    public class AutomovelInterface : VeiculoInterface
    {
        public int NumeroSteps { get; set; }

        public void Acelerar()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Acelerando o carro");
        }

        public void Frear()
        {
            // CADA ENTIDADE TEM SUAS PARTICULARIDADES PARA EXECUTAR A AÇÃO
            Console.Write("Parando o carro");
        }
    }
}
