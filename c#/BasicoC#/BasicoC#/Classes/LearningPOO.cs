using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoC_.Classes
{
    class LearningPOO
    {
        public string marca;
        public string modelo;
        public int quantidade;
        private int items;

        public LearningPOO()
        {

        }

        public LearningPOO(string marca, string modelo, int quantidade)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.quantidade = quantidade;
        }

        public void mover()
        {
            Console.WriteLine("esta no poo - MOVENDO");
        }

        public virtual void metodoSobrescrito()//USANDO VIRTUAL PARA QUE AS CLASSES POSSAM SOBRESCREVER METODO
        {
            Console.WriteLine("classe poo");
        }

        private void myItem()
        {

        }

        void itemPrivado()
        {

        }
    }
}
