using System;
namespace Proyecto{
    class Program{
        static void Main(string[] args){
            Caca caca = new Caca();
            Index2 index2 = new Index2();
            Index index = new Index(1, "Titulo de prueba");
            Console.WriteLine(index2.Metodo2(3));
            caca.Metodo();
            Console.WriteLine(index.getElementos() + " y " + index.getTitulo());
        }
    }
}//hola mierda