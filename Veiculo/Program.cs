using System;

namespace Veiculo
{
    public struct Propriedades
    {
        public string AnoFabricacao { get; set; }
    }

    public class Veiculo
    {
        // TUDO O QUE CONTÊM DENTRO DA CLASSE É DENOMINADO MEMBRO DA CLASSE

        // PROPRIEDADE
        public string Nome { get; set; }

        //INICIA A CLASSE COM VALORES DEFAULT
        public Veiculo()
        {

        }

        // INICIA A CLASSE COM AS VALORES PASSADOS VIA PARÂMETRO
        public Veiculo(string nome)
        {
            Nome = nome;
        }


        // MÉTODO DA CLASSE
        public void ExibirNomeEMarca()
        {
            Console.WriteLine(Nome);
        }

        // MÉTODO DA CLASSE
        public void ExibirAnoFabricacao()
        {
            // INSTANCIA DE UMA STRUCT
            var prop = new Propriedades();
            prop.AnoFabricacao = "1990";
            Console.WriteLine(prop.AnoFabricacao);
        }

        // MÉTODO DA CLASSE
        public void ExibirAnoFabricacaoComConversao()
        {
            var prop = new Propriedades();
            prop.AnoFabricacao = "1990";
            Console.WriteLine(prop.AnoFabricacao.ConverterParaInteiro());
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var veiculo = new Automovel();
            veiculo.CapacidadeTanque = 36;
            veiculo.ExibirCapacidadeTanque();

            Console.ReadKey();
        }
    }
}