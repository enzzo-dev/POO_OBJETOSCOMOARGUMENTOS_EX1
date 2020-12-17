using System;
using System.Collections.Generic;
using POO_OBJETOSCOMOARGUMENTOS_EX1.classes;

namespace POO_OBJETOSCOMOARGUMENTOS_EX1.classes
{
    public class Produto
    {
        public int Codigo{get;set;}

        public string Nome{get;set;}

        public float Valor{get;set;}
        //Métodos
        public Produto(){
            //Método construtor
        }

        public Produto(int _codigo , string _nome , float _valor){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Valor = _valor;
        }

    }
}