using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoDesafioDIO
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data) 
        {
            ListaHistorico = new List<string>();
            this.data = data;
        }
        public int somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            ListaHistorico.Insert(0, "Resultado " + resultado + "- data " + data);
            return resultado;
        }

        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            ListaHistorico.Insert(0, "Resultado " + resultado + "- data " + data);
            return resultado;
        }

        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            ListaHistorico.Insert(0, "Resultado " + resultado + "- data " + data);
            return resultado;
        }

        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            ListaHistorico.Insert(0, "Resultado " + resultado + "- data " + data);
            return resultado;
        }

        public List<string>historico()
        {
            List<string> resultado;
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
