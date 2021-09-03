using System.Globalization;

namespace Classes {
    class Produto {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }*/

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        /*public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if(nome != null && nome.Length > 1)
                _nome = nome;
        }*/

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qtd) {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd) {
            Quantidade -= qtd;
        }

        public override string ToString() {
            return _nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
