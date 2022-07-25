using System;

public class Program{
    private static int valorRecebido;

    public static void Main(){
        do{
            Console.WriteLine("Bem vindo, escolha o programa que deseja:\n[1]Contadores de vogais/consoantes \n[2]Calculadora\n[3]Contador Par/Ímpar\n[4]Fatorial");
            setValorRecebido(Console.ReadLine());
        }
        while(getValorRecebido() > 5);

        switch(getValorRecebido()){
            case 1:
                var contaVogalConsoante = new ContadorVogaisConsoantes();
                contaVogalConsoante.abrirMenu();
                break;
            case 2:
                var calc = new Calculadora();
                calc.abrirMenu();
                break;
            case 3:
                var contaParImpar = new ContadorParImpar();
                contaParImpar.contarParImpar();
                break;
            case 4:
                var fatorial = new Fatorial();
                fatorial.fatorial();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

    //SETTERS & GETTERS

    public static int getValorRecebido(){
        return valorRecebido;
    }
    public static void setValorRecebido(string valor){
        valorRecebido = Convert.ToInt32(valor);
    }
}