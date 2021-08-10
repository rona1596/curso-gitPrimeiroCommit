using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PrimeiroProjeto
{
    public class Produto
    {
        // Atributos privados
        private string _nome;

        // Propriedades autoimplementadas
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        //Construtores
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedades customizadas
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Outros métodos da Classe
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        //override - indica que veio de outra classe
        public override string ToString()
        {
            //Transforma produto em string
            return Nome 
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
