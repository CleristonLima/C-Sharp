using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11.Metodos
{
    public class Impostos
    {
        // Metodo estatico (static) - que não recebe informação e que ficam gravados na memoria

      /*  public static decimal CalcularISS(string estado, decimal valorServico, bool empresaIndividual)
        {
            decimal porcentagem;
            if (empresaIndividual)
            {
                porcentagem = 0.01m;
            }
            else
            {

                if (estado == "SP")
                {
                    porcentagem = 0.06m;
                }
                else
                {
                    porcentagem = 0.05m;

                }
            }

            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;
        }*/

        // Metodo Construtor - que recebe uma informação como parametro

        private decimal _porcentagemIndividual;

        // Sobre Carga para metodo Construtor
        public Impostos()
        {
            _porcentagemIndividual = 0.01m;
        }

        public Impostos(decimal porcetagemIndividual)
        {
            _porcentagemIndividual = porcetagemIndividual;

        }

        // Sobre Carga
        public decimal CalcularISS(string estado, decimal valorServico, bool empresaIndividual)
        {
            decimal porcentagem;
            if (empresaIndividual)
            {
                porcentagem = _porcentagemIndividual;
            }
            else
            {

                if (estado == "SP")
                {
                    porcentagem = 0.06m;
                }
                else
                {
                    porcentagem = 0.05m;

                }
            }

            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;
        }

        // Modificador de acesso (public)
        // Retorno é um valor (decimal)
        // Nome do metodo é (Calcular ISS)
        // Parametros (estado, valorServico)

        public decimal CalcularISS(string estado, decimal valorServico)
        {
            decimal porcentagem;
            if (estado == "SP")
            {
                porcentagem = 0.06m;
            }
            else
            {
                porcentagem = 0.05m;

            }

            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;
        }
    }
}
