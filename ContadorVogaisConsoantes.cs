using System;

public class ContadorVogaisConsoantes {
    private char caractereRecebido;
    private int quantidadeVogais;
    private int quantidadeConsoantes;
    private char[] quaisVogais = new char[5];
    private char[] quaisConsoantes = new char[5];
    private int escolhaPrograma;
    private string fraseRecebida;

    public void abrirMenu(){
        do{
            Console.WriteLine("Escolha um dos programas\n[1]Contador de vogais\n[2]Contador de consoantes\n[3]Contador de vogais numa frase\n[4]Contador de consoantes numa frase\n[5]Contador de vogais que mostra quais foram\n[6]Contador de consoantes que mostra quais foram");
            setEscolhaPrograma(Console.ReadLine());
        }
        while(getEscolhaPrograma() > 6);

        switch (getEscolhaPrograma()){
            case 1:
                this.contarVogais();
                break;
            case 2:
                this.contarConsoantes();
                break;
            case 3:
                this.contarVogaisFrase();
                break;
            case 4:
                this.contarConsoantesFrase();
                break;
            case 5:
                this.contarEMostrarVogais();
                break;
            case 6:
                this.contarEMostrarConsoantes();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

    public void contarVogais(){

        Console.WriteLine("Olá, esse programa lê N caracteres e retorna a quantidade de vogais digitadas");
        setQuantidadeVogais(0);

        do{
            Console.WriteLine("Digite um caractere  // '0' para sair");
            setCaractereRecebido(Console.ReadLine());

            switch(Char.ToLower(getCaractereRecebido())){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    setQuantidadeVogais(getQuantidadeVogais() + 1);
                    break;

            }
        }
        while(getCaractereRecebido() != '0');

        //RESULTADO
        Console.WriteLine($"O número de vogais digitadas foi {getQuantidadeVogais()}");
    }

    public void contarConsoantes(){

        Console.WriteLine("Olá, esse programa lê N caracteres e retorna a quantidade de consoantes digitadas");
        setQuantidadeConsoantes(0);

        do{
            Console.WriteLine("Digite um caractere  // '0' para sair");
            setCaractereRecebido(Console.ReadLine());

            switch(Char.ToLower(getCaractereRecebido())){
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    setQuantidadeConsoantes(getQuantidadeConsoantes() + 1);
                    break;

            }
        }
        while(getCaractereRecebido() != '0');

        //RESULTADO
        Console.WriteLine($"O número de vogais digitadas foi {getQuantidadeConsoantes()}");
    }

    public void contarEMostrarVogais(){

        Console.WriteLine("Olá, esse programa lê 5 caracteres, retorna a quantidade de vogais digitadas e mostra quais foram");

        for(int i = 0; i < getQuaisVogais().Length; i++){
            Console.WriteLine("Digite um caractere");
            setCaractereRecebido(Console.ReadLine());
            
            switch(Char.ToLower(getCaractereRecebido())){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    setQuantidadeVogais(getQuantidadeVogais() + 1);
                    setQuaisVogais(getCaractereRecebido(), i);
                break;
            }
        }

        //RESULTADO
        switch(getQuantidadeVogais()){
            case 0:
                Console.Write("Nenhuma vogal foi digitada");
                break;
            case 1:
                Console.Write($"{getQuantidadeVogais()} vogal foi digitada: ");
                break;
            case 2:
            case 3:
            case 4:
            case 5:
                Console.Write($"{getQuantidadeVogais()} vogais foram digitadas: ");
                foreach (var vogal in getQuaisVogais()){
                    if (vogal != 0){
                    Console.Write($"{vogal} ");
                    }
                }
                break;
            default:
                Console.WriteLine("Erro");
                break;
        }
        Console.WriteLine("\nFIM");
    }

    public void contarEMostrarConsoantes(){

        Console.WriteLine("Olá, esse programa lê 5 caracteres, retorna a quantidade de consoantes digitadas e mostra quais foram");

        for(int i = 0; i < getQuaisConsoantes().Length; i++){
            Console.WriteLine("Digite um caractere");
            setCaractereRecebido(Console.ReadLine());
            
            switch(Char.ToLower(getCaractereRecebido())){
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    setQuantidadeConsoantes(getQuantidadeConsoantes() + 1);
                    setQuaisConsoantes(getCaractereRecebido(), i);
                break;
            }
        }

        //RESULTADO
        switch(getQuantidadeConsoantes()){
            case 0:
                Console.Write("Nenhuma consoante foi digitada");
                break;
            case 1:
                Console.Write($"{getQuantidadeConsoantes()} consoante foi digitada: ");
                break;
            case 2:
            case 3:
            case 4:
            case 5:
                Console.Write($"{getQuantidadeConsoantes()} consoantes foram digitadas: ");
                foreach (var consoante in getQuaisConsoantes()){
                    if (consoante != 0){
                    Console.Write($"{consoante} ");
                    }
                }
                break;
            default:
                Console.WriteLine("Erro");
                break;
        }
        Console.WriteLine("\nFIM");
    }

    public void contarVogaisFrase(){
        Console.WriteLine("Digite uma frase ");
        setFraseRecebida(Console.ReadLine());

        setFraseRecebida(getFraseRecebida().Trim());
        setFraseRecebida(getFraseRecebida().Replace(" ", String.Empty));
        
        for(int i = 0; i < getFraseRecebida().Length; i++){
            switch(Char.ToLower(getFraseRecebida()[i])){
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    setQuantidadeVogais(getQuantidadeVogais() + 1);
                    break;
                default:
                    break;
            }
        }

        //RESULTADO

        Console.WriteLine($"Quantidade de vogais: {getQuantidadeVogais()}");
        Console.WriteLine("FIM");
    }

    public void contarConsoantesFrase(){
        Console.WriteLine("Digite uma frase ");
        setFraseRecebida(Console.ReadLine());

        setFraseRecebida(getFraseRecebida().Trim());
        setFraseRecebida(getFraseRecebida().Replace(" ", String.Empty));
        
        for(int i = 0; i < getFraseRecebida().Length; i++){
            switch(Char.ToLower(getFraseRecebida()[i])){
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    setQuantidadeConsoantes(getQuantidadeConsoantes() + 1);
                    break;
                default:
                    break;
            }
        }

        //RESULTADO

        Console.WriteLine($"Quantidade de consoantes: {getQuantidadeConsoantes()}");
        Console.WriteLine("FIM");
    }

    //GETTERS & SETTERS

    public string getFraseRecebida(){
        return this.fraseRecebida;
    }

    public void setFraseRecebida(string palavra){
       this.fraseRecebida = palavra;
    }

    public char getCaractereRecebido(){
        return this.caractereRecebido;
    }

    public void setCaractereRecebido(string caractere){
        //this.caractereRecebido = caractere;
        this.caractereRecebido = caractere[0];
        
    }

    public int getQuantidadeVogais(){
        return this.quantidadeVogais;
    }

    public void setQuantidadeVogais(int quantidade){
        this.quantidadeVogais = quantidade;
    }

    public char[] getQuaisVogais(){
        return this.quaisVogais;
    }

    public void setQuaisVogais(char vogal, int i){
        this.quaisVogais[i] = vogal;
    }

    public char[] getQuaisConsoantes(){
        return this.quaisConsoantes;
    }

    public void setQuaisConsoantes(char consoante, int i){
        this.quaisConsoantes[i] = consoante;
    }

    public int getQuantidadeConsoantes(){
        return this.quantidadeConsoantes;
    }

    public void setQuantidadeConsoantes(int quantidade){
        this.quantidadeConsoantes = quantidade;
    }

    public int getEscolhaPrograma(){
        return this.escolhaPrograma;
    }

    public void setEscolhaPrograma(string opcao){
        this.escolhaPrograma = Convert.ToInt32(opcao);
    }
}
