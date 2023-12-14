using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoC_.Classes
{
    class Carro:LearningPOO //FAZENDO A HERANÇA PELOS :
    {
        public int veiculos = 4;
        public static int quantidadeProduzida;

        public void mover()
        {
            Console.WriteLine("esta no carro - MOVENDO");
            base.mover(); //USANDO BASE PARA ACESSAR A CLASSE HERDADA
        }

        public override void metodoSobrescrito()//USANDO VIRTUAL PARA QUE AS CLASSES POSSAM SOBRESCREVER METODO
        {
            Console.WriteLine("classe carro");
        }
    }
}
