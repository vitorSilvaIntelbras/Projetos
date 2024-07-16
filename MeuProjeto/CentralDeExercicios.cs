using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuProjeto{

    public class CentralDeExercicios{
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios){
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar(){
            int i = 1;

            foreach(var exercicio in Exercicios ){
                Console.WriteLine("{0}) {1}", i, exercicio.Key);
                i++;
            }

            Console.WriteLine("Digite o número da atividade (ou vazio para o último)");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Exercicios.Count;
            num = numValido ? num - 1 : Exercicios.Count - 1;
            //porque num - 1, e Exercicios.Count - 1;

            string nomeDoExercicio = Exercicios.ElementAt(num).Key;

            Console.WriteLine(num);

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

            Action executar = Exercicios.ElementAt(num).Value;
            try{
                executar();
            }catch(Exception e){
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}