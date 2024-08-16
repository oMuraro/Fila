using System;

namespace Aula{

    class Program{
        static void Main(string[] args){

            Fila fila = new Fila();
            Console.WriteLine(fila.estaVazia());
            
            fila.enfileirar(10);
            fila.enfileirar(-20000);
            fila.enfileirar(30);
            fila.enfileirar(60);
            fila.enfileirar(-1);
            fila.enfileirar(-2);
            fila.enfileirar(3);

            // fila.percurso();
            // fila.removerNegativos();
            // fila.percurso();

            // fila.desenfileirar();
            // Console.WriteLine(fila.contador());

            Fila fila2 = new Fila();
            fila2.enfileirar(20);
            fila2.enfileirar(10000);
            fila2.enfileirar(50);

            Fila fila3 = fila.juntarLista(fila2);
            fila3.percurso();
            // fila2.desenfileirar();
            
            // if(fila.contador() == fila2.contador()){
            //     Console.WriteLine("Possuem a mesma quantidade");
            // } else if(fila.contador() > fila2.contador()){
            //     Console.WriteLine("Fila 1 possui mais elementos que a fila 2");
            // } else {
            //     Console.WriteLine("A fila 2 possui mais elementos que a fila 1");
            // }

            //Cliente

            // Fila fila = new Fila();
            // Cliente arthur = new Cliente("Arthur", 18, 22, false);
            // Cliente pedro = new Cliente("Pedro", 18, 11, true);
            // Cliente clara = new Cliente("Clara", 17, 10, false);

            // Console.WriteLine(fila.estaVazia());

            // fila.enfileirar(arthur);
            // fila.enfileirar(pedro);
            // fila.enfileirar(clara);
            // Console.WriteLine(fila.consulta(new Cliente("Barbatos", 30, 20, true)));
            // fila.percurso();

            //Fila Reversa

            // Fila fila = new Fila();
            // Console.WriteLine(fila.estaVazia());
            
            // fila.enfileirar(34);
            // fila.enfileirar(15342);
            // fila.enfileirar(29);

            // fila.percurso();

            // fila.desenfileirar();
            // fila.percurso();

            
        }
    }
}