using System;
using TelefonePoo.TemplateMethod;

namespace TelefonePoo
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefoneBuilder builder = new();
            builder
                //.NumeroMovel();
                .NumeroFixo()
                //.NumeroAleatorio()
                .ComFormatacao();
                //.DefineEstadoParaDdd("SP");
                //.ComDddAleatorio();

            Console.WriteLine(builder.Constroi());


            Console.ReadKey();
        }
    }
}
