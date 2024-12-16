using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer031
{
    class ClsCalcular
    {
        //Declaração do atributo / campo
        decimal _valor = 0;
        //Declaração da propriedade
        public decimal Valor { get => _valor; set => _valor = value; }
        //Método construtor
        public ClsCalcular()
        {
            _valor = 0;
        }
        //Este é um exemplo para OverLoad (sobrecarga de métodos).
        // Métodos com o mesmo nome, porém, com assinatura diferente!!!
        //Método para parcela a vista
        public string CalcularValor()
        {
            decimal valorParcela = (_valor * 85) / 100;
            string texto = "O valor do orçamento com desconto a vista é de " + valorParcela.ToString("C2");
            //"C2" --> exibe o número no formato de dinheiro com duas casas decimais
            return texto;
        }
        //Método para pagamento parcelado. Mesmo nome, porém, com “assinatura diferente” (recebe parâmetro)
        public string CalcularValor(int numParcela)
        {
            decimal valorParcela = _valor / numParcela;
            string texto = "O valor será dividido em " + numParcela + " parcelas de " + valorParcela.ToString("C2");
            //"C2" --> exibe o número no formato de dinheiro com duas casas decimais
            return texto;
        }
    }
}
    
