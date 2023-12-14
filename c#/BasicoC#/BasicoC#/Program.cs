// See https://aka.ms/new-console-template for more information
using BasicoC_;
using BasicoC_.Classes;
using System;
using System.Globalization;

namespace Basico // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tiposDeDados();
            //extensionMethods();
            //ifs(false,null);
            //loops();
            //atribuicoes();
            //prints();
        }

        public static void extensionMethods()
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt);
        }

        public static void convercoes()
        {
            string numeroTexto = "30";
            int numeroC = int.Parse(numeroTexto);
            int numero = 30;

            Console.WriteLine(numeroTexto + numero);
            Console.WriteLine(numeroC + numero);

            short meuShort = 30;
            int meuInt = meuShort;
            long meuLong = meuInt;

            long mesLong = meuLong;
            int mesInt = System.Convert.ToInt32(mesLong);
            short mesShort = System.Convert.ToInt16(mesInt);

            Console.ReadKey();
        }

        public static void poo()
        {
            Carro carro = new Carro();
            carro.modelo = "mew";
            carro.quantidade = 1;
            carro.marca = "nissa";
        }

        public static void pooDois(Carro carros)
        {
            carros.mover();
            Console.WriteLine(Carro.quantidadeProduzida); //METODOS STATIC PRECISAM SER CHAMADOS PELA CLASSE

        }

        public static void metodosStrings()
        {
            string meuTexto = "meu amigo, estou feliz por voce, estou muito feliz";
            string palavra = "feliz";
            Console.WriteLine(meuTexto.Length);
            Console.WriteLine(meuTexto.IndexOf(palavra));
            Console.WriteLine(meuTexto.LastIndexOf(palavra));

            meuTexto = meuTexto.Replace("estou", "I am");

            Console.WriteLine(meuTexto.StartsWith("meu"));
            Console.WriteLine(meuTexto.EndsWith("!"));
            Console.WriteLine(meuTexto.Contains("Costa"));

            Console.WriteLine(string.Format("bem vindo ao meu item de ",palavra));

            Console.WriteLine(meuTexto.Substring(3));
            Console.WriteLine(meuTexto.Substring(10,5));

            Console.WriteLine(meuTexto.ToUpper());
            Console.WriteLine(meuTexto.ToLower());

            Console.WriteLine(meuTexto.TrimStart());
            Console.WriteLine(meuTexto.TrimEnd());
            Console.WriteLine(meuTexto.Trim());

            Console.WriteLine(meuTexto.Split(','));
            Console.WriteLine(meuTexto.Split(',','e'));
            Console.WriteLine(meuTexto.Split(',', StringSplitOptions.None));

            Console.ReadKey();
        }

        public static void escopos()
        {
            string nome;
            int i;
            while (true)
            {
                if (true)
                {
                    int a;
                }
                //a++;  //a variavel a nao existe nesse escopo
            }
            i++;
        }

        public static void excecoes()
        {
            try
            {

            }catch (FormatException ex)
            {

            }catch (Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("Finalizando procedimento");
            }
        }

        public static void tiposDeDados()
        {
            byte myByte;
            System.Byte myByte2;

            myByte = 9;
            sbyte myByte3 = -100;

            short myShort;
            int myInt;
            long myLong;

            System.Int16 myshort2;

            //CADA PROPRIEDADE TEM SEUS METODOS, PARA VELOS PODE OLHAR NA DOCUMENTAÇÃO OU VER PELO VS DIGITANDO A PROPRIEDADE E COLOCANDO PONTO
            short.Abs(1);

            ushort myUShort;
            uint myUInt;
            ulong myULong;

            string myString;

            string[] vetString;
            int[] vetInt;

            float myFloat;
            double myDouble;
            decimal myDecimal;

            //declarar em linha mais de uma var
            double var1,var2,var3;

            myString = Console.ReadLine();

            int n = 10;

            if (myString != null)
            {
                vetString = myString.Split(',');
                if (vetString != null && vetString.Length > 0)
                {
                    Console.WriteLine(vetString[0]);
                }
            }

            char ch = char.Parse(Console.ReadLine());

            string[] str = Console.ReadLine().Split(" ");

            int[,] a;
            string[][] matriz;
            string[,] marcas = new string[3, 4];
            string[] nomes = {"aaaa","bbbb","cccc" };

            bool item = false;
            item = false && true;
            item = false || true;
            item = false || !true;
            System.Boolean myBool = false;

            System.Object myObject;
            object meuObjeto;
            myObject = 3;

            const int detalhe = 0;

            marcas[0, 0] = "10";

            a = new int[n, n];

            List<int> list = new List<int>();
            list.Add(0);

            Dictionary<string,int> dicionario = new Dictionary<string,int>();
            dicionario.Add("id", 0);
            Console.WriteLine(dicionario["id"]);

            int vari = Console.Read();
            char letra = (char) vari;

            Console.ReadKey();
        }

        static void ifs(bool var,string st)
        {
            if (var)
                Console.WriteLine(st);
            else if (st == null)
                Console.WriteLine("nulls");
            else
                Console.WriteLine(var);

            if (var == true)
            {
                Console.WriteLine(var);
            }
            else if (var == false && st is null)
            {
                Console.WriteLine("else if");
            }
            else if (var == true && st.Equals("hello"))
            {
                Console.WriteLine("else if");
            }
            else
            {
                Console.WriteLine("nenhum");
            }
        }

        /// <summary>
        /// CRIANDO DOCUMENTS USANDO 3 BARRAS
        /// </summary>
        /// <param name="x"></param>
        /// <param name="st"></param>
        static void switches(int x, string st)
        {
            /**/
            switch (x)
            {
                case 1:
                    Console.WriteLine(st + "1");
                    break;
                case 2:
                    Console.WriteLine(st + "2");
                    break;
                case 3:
                    Console.WriteLine(st + "3");
                    break;
                default: 
                    Console.WriteLine(st + "4");
                    break;
            }
        }

        static void loops()
        {
            //TODO comentario para fazer tarefa
            bool continuar = true;

            int n = 30;
            string[] vetStr = new string[n];
            for (int i = 0;i< n; i++)
            {
                vetStr[i] = Console.ReadLine();
            }

            foreach (string x in vetStr)
            {
                Console.WriteLine(x);
            }

            do {

                int escolha = int.Parse(Console.ReadLine());
                if (escolha > 0)
                {
                    continuar = true;
                    continue;
                }
                else
                {
                    continuar = false;
                    break;
                }
            } while (continuar);

            int valor = int.Parse(Console.ReadLine());
            int valoresParaChegar = int.Parse(Console.ReadLine());

            while (valor < valoresParaChegar)
            {
                Console.WriteLine(valor);
                valor++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            double raiz = Math.Sqrt(valoresParaChegar);
            raiz = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }

        private static void atribuicoes()
        {
            int a = 10;
            a += 10;
            a -= 10;
            a *= 10;
            a %= 10;
            a /= 10;
            float b = a / 10;
            a++;
            a--;
            ++a;
            --a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = (10/2) + 2;

            Math.Sqrt(a);
            Math.Pow(a, 2);
            Math.Abs(a);
        }

        private static void prints()
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.88;
            string nome = "antony";
            Console.WriteLine("Hello World!");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString());
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

            Console.Write("hELLO sem pular linha");
        }
    }
}