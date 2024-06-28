﻿namespace Model.Entities.Compras {
    public class ListaDeCompras {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public bool PossuiNoEstoque { get; set; }
         
        public ListaDeCompras() {
        }

        public ListaDeCompras(int id,string produto,int quantidade,decimal precoUnitario,bool possuiNoEstoque) {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            PossuiNoEstoque = possuiNoEstoque;
        }

        public decimal ValorFinal(int quantidade,decimal precoUnitario) {
            return quantidade * precoUnitario;
        }
    }
}
