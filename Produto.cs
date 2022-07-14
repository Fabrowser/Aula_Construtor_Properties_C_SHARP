using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClasseProduto
{
    class Produto
    {
        //Atributos

        private string _nome;
        private double _preco;
        public int Quantidade { get; private set; } // Auto Properties

        public Produto()// Construtor
        {

        }

        public Produto(string nome, double preco, int quantidade) // Construtor
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;

        }

        public string Nome // Properties
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

                ;
            }
        }

        public double Preco // Properties
        {
            get { return _preco; }

        }

        // Métodos publicos
        public double ValorTotalEmEstoque()
        {
            return Quantidade * _preco;
        }

        public void AdicionaProduto(int q)
        {
            Quantidade = Quantidade + q;
        }

        public void RemoverProdutos(int q)
        {

            Quantidade = Quantidade - q;
        }

        public override string ToString()
        {
            return ($"Dados atualizados:\nNome: {Nome} \nPreço: {_preco} \nQuantidade:{Quantidade} \n" +
                $"Total: {ValorTotalEmEstoque().ToString("F2")}\n");
        }


    }
}
