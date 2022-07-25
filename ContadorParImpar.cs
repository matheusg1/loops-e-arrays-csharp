using System;

public class ContadorParImpar{
    private int valorRecebido;
    private int quantidadePares;
    private int quantidadeImpares;

    public void contarParImpar(){
        Console.WriteLine("Olá, esse programa recebe um caractere e conta os pares e ímpares");

        setQuantidadeImpares(getQuantidadeImpares() -1);
        
        while(getValorRecebido() != -1){
            Console.WriteLine("Digite um valor // '-1' para sair");
            setValorRecebido(Console.ReadLine());
            
            if (getValorRecebido() % 2 == 0)
                setQuantidadePares(getQuantidadePares() + 1);
            else
                setQuantidadeImpares(getQuantidadeImpares() + 1);
        }

        //RESULTADO

        Console.WriteLine($"Pares: {getQuantidadePares()}\nÍmpares: {getQuantidadeImpares()}");
        Console.WriteLine("\nFIM");

    }


    //SETTERS & GETTERS
    public int getValorRecebido(){
        return this.valorRecebido;
    }

    public void setValorRecebido(string quantidade){
        this.valorRecebido = Convert.ToInt32(quantidade);
    }

    public int getQuantidadePares(){
        return this.quantidadePares;
    }

    public void setQuantidadePares(int quantidade){
        this.quantidadePares = quantidade;
    }

    public int getQuantidadeImpares(){
        return this.quantidadeImpares;
    }

    public void setQuantidadeImpares(int quantidade){
        this.quantidadeImpares = quantidade;
    }
}