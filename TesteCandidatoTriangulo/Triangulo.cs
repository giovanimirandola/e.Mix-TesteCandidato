﻿namespace TesteCandidatoTriangulo
{
    public class Triangulo
    {
        int indice = 0;

        /// <summary>
        ///    6
        ///   3 5
        ///  9 7 1
        /// 4 6 8 4
        /// Um elemento somente pode ser somado com um dos dois elementos da próxima linha. Como o elemento 5 na Linha 2 pode ser somado com 7 e 1, mas não com o 9.
        /// Neste triangulo o total máximo é 6 + 5 + 7 + 8 = 26
        /// 
        /// Seu código deverá receber uma matriz (multidimensional) como entrada. O triângulo acima seria: [[6],[3,5],[9,7,1],[4,6,8,4]]
        /// </summary>
        /// <param name="dadosTriangulo"></param>
        /// <returns>Retorna o resultado do calculo conforme regra acima</returns>
        public int ResultadoTriangulo(string dadosTriangulo)
        {
            var dados = Newtonsoft.Json.JsonConvert.DeserializeObject<string[][]>(dadosTriangulo);

            var soma = 0;

            for (int i = 0; i < dados.Length; i++)
            {
                soma += RetornaMaiorValor(dados[i]);
            }

            return soma;
        }

        private int RetornaMaiorValor(string[] dados)
        {
            var valor = 0;
            for (int i = indice; i < dados.Length; i++)
            {
                var v = int.Parse(dados[i]);
                if (v > valor)
                {
                    indice = i;
                    valor = v;
                }
            }

            return valor;
        }
    }
}