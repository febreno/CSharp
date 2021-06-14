using System;//diretiva using facilita o acesso dentro dos tipos names pace

namespace start //declaracao de namespace(abaixo o escopo do namespace)
{
    class Program//declaracao de classe
    {
        static void Main(string[] args)//um metodo estatico que nao retorna nada com nome main
        {
            int x = 10;
            decimal d = 2.3m;//used for calc money
            double db = 1.33;//calculos cientificos e medicoes
            float f = 3.14f;//enginie de games

            int calc = x * 2;// + - / * 
            s = s + ("Mundo");//concaternation
            int[] array = new int[] (2, 5, 8);//separete by elemts (0, 1, 2)
            int result = 0;//the first value
            result = result + a[0];//first
            result = result + a[1];//secont
            result = result + a[2];//third
            result += a[2];//simplific form right up, above

            foreach(int number in a)//using a loop(simplific line above)
            {
                result += number;//
            }
            Program p = new Program();//new object
            p.name = "cleiton";//propriets
            string hello = p.Hello();

            Console.writeLine(result);//hello
            Console.ReadyKey();
        }
    }
    class Program
    {
        public string name;//can acess by other class

        pubic string Hello()
        {
            return"Ola" + name;
        }
    }
}