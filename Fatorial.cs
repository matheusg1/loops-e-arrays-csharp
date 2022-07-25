using System;

public class Fatorial{
    private int valorRecebido;
    private int resultado;

    public void fatorial(){
        Console.WriteLine("Olá, esse programa faz cálculo de fatorial");
        Console.WriteLine("Digite o número");

        setValorRecebido(Console.ReadLine());

        setResultado(1);

        for(int i = getValorRecebido(); i > 0 ; i--){
            setResultado(getResultado() * i);
            if(i > 1)
                Console.Write($"{i} x ");
            else
                Console.Write($"{i} = ");
        }

        //RESULTADO
        Console.WriteLine(getResultado());
        Console.WriteLine($"FIM");
    }

    public int getValorRecebido(){
        return this.valorRecebido;
    }

    public void setValorRecebido(string valor){
        this.valorRecebido = Convert.ToInt32(valor);
    }

    public int getResultado(){
        return this.resultado;
    }

    public void setResultado(int valor){
        this.resultado = valor;
    }

}