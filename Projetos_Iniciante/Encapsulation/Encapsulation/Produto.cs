using System;
using System.Globalization;


namespace Encapsulation {
    class Produto {

        // Ordem sugerida
        /*
        Atributos privados
        Propriedades autoimplementadas
        Construtores
        Propriedades customizadas
        Outros metodos
        */

        // metodos encapsulamentos de membros e propreties com metodos de função invocada

        //private string _nome;
        //private double _preco;
        //private int _quantidade;

        // Utilizando Auto Propeties, forma simplificada de declarar sem lógicas particulares de get e set
        //public string _nome; atributos privativo 

        public string _nome; // há lógica customizada, portanto usar essa forma sem auto propeties pra manipular através das implementações
        public double Preco { get; set; }
        public int Quantidade { get; private set; }

        //public double Quantidade { get; set; }
        //public int Quantidade { get; set; } // prop

        //public int MyProperty { get; private set; } // sneept => propg para private

        // Construtores 

        public Produto() {
        }

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Propriedades customizadas

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        //public string GetNome(string nome) { 
        //    return _nome;
        //}

        //public string SetNome(string nome) {
        //    if (value != null && value.Length > 1) {
        //        _nome = value;
        //    }
        //}

        //public double Preco {
        //    get { return _preco; }
        //}

        //public double GetPreco() {
        //    return _preco;
        //}

        //public int Quantidade {
        //    get { return _quantidade; }
        //}

        //public int GetQuantidade() {
        //    return _quantidade;
        //}

        //Outros metodos | Incluindo ToString tambem

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _nome
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
