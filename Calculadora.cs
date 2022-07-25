using System;

public class Calculadora{
    private int operacaoEscolhida;
    private string nomeOperacao;
    private int quantidadeValores;
    private double resultado;

    public void abrirMenu(){
        Console.WriteLine("Olá, esta é uma calculadora com operação única");

        Console.WriteLine($"Qual operação deseja fazer?\n[1]Adição\n[2]Subtração\n[3]Multiplicação\n[4]Divisão");
        setOperacaoEscolhida(Console.ReadLine());

        Console.WriteLine($"Digite a quantidade de valores que você deseja {getNomeOperacao()}");
        setQuantidadeValores(Console.ReadLine());

        double[] valorRecebido = new double[getQuantidadeValores()];

        for (int i = 0; i < getQuantidadeValores(); i++){
            Console.WriteLine($"Digite o {i + 1}º valor");
            string inputValorRecebido = Console.ReadLine();
            valorRecebido[i] = Convert.ToDouble(inputValorRecebido);
        }

        switch(getOperacaoEscolhida()){
            case 1:
                Console.Write("Resultado: ");
                setResultado(soma(valorRecebido));
                Console.WriteLine(getResultado());
                break;
            case 2:
                Console.Write("Resultado: ");
                setResultado(subtrai(valorRecebido));
                Console.WriteLine(getResultado());
                break;
            case 3:
                Console.Write("Resultado: ");
                setResultado(multiplica(valorRecebido));
                Console.WriteLine(getResultado());
                break;
            case 4:
                Console.Write("Resultado: ");
                setResultado(divide(valorRecebido));
                Console.WriteLine(getResultado());
                break;
            default:
                Console.WriteLine("Erro");
                break;
        }
        Console.WriteLine("\nFIM");
    }
    public double soma(double[] valor){
        setResultado(0);

        for (int i = 0; i < valor.Length; i++){
            setResultado(getResultado() + valor[i]);
        }

        return getResultado();
    }

    public double subtrai(double[] valor){
        setResultado(0);

        for (int i = 0; i < valor.Length; i++){
            if(i == 0)
                setResultado(valor[i]);
            else
                setResultado(getResultado() - valor[i]);
        }

        return getResultado();
    }

    public double multiplica(double[] valor){
        setResultado(1);

        for (int i = 0; i < valor.Length; i++){
            setResultado(getResultado() * valor[i]);
        }

        return getResultado();
    }

    public double divide(double[] valor){
        setResultado(1);

        for (int i = 0; i < valor.Length; i++){
            if(i == 0)
                setResultado(valor[i] / getResultado());
            else
                setResultado(getResultado() / valor[i]);
        }
        return getResultado();
    }

    //SETTERS & GETTERS

    public int getOperacaoEscolhida(){
        return this.operacaoEscolhida;
    }

    public void setOperacaoEscolhida(string opcao){
        this.operacaoEscolhida = Convert.ToInt32(opcao);
        switch(this.operacaoEscolhida){
            case 1:
                this.nomeOperacao = "somar";
                break;
            case 2:
                this.nomeOperacao = "subtrair";
                break;
            case 3: 
                this.nomeOperacao = "multiplicar";
                break;
            case 4:
                this.nomeOperacao = "dividir";
                break;
            default:
                Console.WriteLine("Erro");
                break;
        }
    }

    public string getNomeOperacao(){
        return this.nomeOperacao;
    }

    public int getQuantidadeValores(){
        return this.quantidadeValores;
    }

    public void setQuantidadeValores(string quantidade){
        this.quantidadeValores = Convert.ToInt32(quantidade);
    }

    public double getResultado(){
        return this.resultado;
    }

    public void setResultado(double opcao){
        this.resultado = opcao;
    }
}