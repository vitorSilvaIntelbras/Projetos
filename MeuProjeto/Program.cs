using System;
using System.Linq.Expressions;
using System.Text;
using MeuProjeto.Atividades;



namespace MeuProjeto{

    class Program{
        static void Main(string[] args){
           
           var central = new CentralDeExercicios(new Dictionary<string, Action>(){


            {"Calculadora Simples", Calculadora.Executar},





           });
            
            central.SelecionarEExecutar();
        }
    }
}
