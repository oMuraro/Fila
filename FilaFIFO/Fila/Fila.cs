public class Fila
{
    public No inicio;
    public No fim;

    public Fila()
    {
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia()
    {
        if (this.inicio == null && this.fim == null)
        {
            return (true);
        }
        return (false);
    }

    public void enfileirar(int valor)
    {

        No novoNo = new No(valor);

        if (this.estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public Boolean desenfileirar()
    {

        if (this.estaVazia())
        {
            return (false);
        }
        else
        {
            this.inicio = this.inicio.prox;
            return (true);
        }
    }

    public int contador()
    {
        No noAtual = this.inicio;
        int cont = 0;

        if (estaVazia())
        {
            return 0;
        }
        else
        {
            while (noAtual != null)
            {
                cont++;
                noAtual = noAtual.prox;
            }
            return cont;
        }
    }

    public void removerNegativos()
    {
        No noAtual = this.inicio;
        No noAnterior = null;

        while (noAtual != null)
        {
            if (this.inicio.valor < 0)
            {
                this.inicio = this.inicio.prox;
            }
            if (noAtual.valor < 0)
            {
                noAnterior.prox = noAtual.prox;
                noAtual = noAnterior;
            }
            noAnterior = noAtual;
            noAtual = noAtual.prox;
        }
    }

    public Fila juntarLista(Fila fila2){
        Fila fila3 = new Fila();
        No noAtual = this.inicio;

        while(noAtual != null){
            fila3.enfileirar(noAtual.valor);
            noAtual = noAtual.prox;
        }
        
        noAtual = fila2.inicio;
        while(noAtual != null){
            fila3.enfileirar(noAtual.valor);
            noAtual = noAtual.prox;
        }
        return fila3;
    }

    public void percurso()
    {

        No noAtual = this.inicio;

        while (noAtual != null)
        {
            Console.Write(noAtual.valor + "-> ");
            noAtual = noAtual.prox;
        }
        Console.WriteLine("\n");
    }
}


// ============================================================================


// Cliente Fila

// public class Fila{
//     public No inicio;
//     public No fim;

//     public Fila(){
//         this.inicio = null;
//         this.fim = null;
//     }

//     public Boolean estaVazia(){
//         if(this.inicio == null && this.fim == null){
//             return(true);
//         }
//         return(false);
//     }

//     public void enfileirar(Cliente cliente){

//         No novoNo = new No(cliente);

//         if(this.estaVazia()){
//             this.inicio = novoNo;
//             this.fim = novoNo;
//         }
//         else{
//             this.fim.prox = novoNo;
//             this.fim = novoNo;
//         }
//     }

//     public Boolean desenfileirar(){

//         if(this.estaVazia()){
//             return(false);
//         }
//         else{
//             this.inicio = this.inicio.prox;
//             return(true);
//         }
//     }

//     public bool consulta(Cliente cliente){
//         No noAtual = this.inicio;

//         while(noAtual != null){
//             if(noAtual.cliente == cliente){
//                 return true;
//             }
//             noAtual = noAtual.prox;
//         }
//         return false;
//     }

//     public void percurso(){

//         No noAtual = this.inicio;

//         while(noAtual != null){
//             Console.Write(noAtual.cliente.nome + "-> ");
//             noAtual = noAtual.prox;
//         }
//         Console.WriteLine("\n");
//     }
// }

// Fila Reversa

// public class Fila
// {
//     public No inicio;
//     public No fim;

//     public Fila()
//     {
//         this.inicio = null;
//         this.fim = null;
//     }

//     public Boolean estaVazia()
//     {
//         if (this.inicio == null && this.fim == null)
//         {
//             return (true);
//         }
//         return (false);
//     }

//     public void enfileirar(int valor)
//     {

//         No novoNo = new No(valor);

//         if (this.estaVazia())
//         {
//             this.inicio = novoNo;
//             this.fim = novoNo;
//         }
//         else
//         {
//             novoNo.prox = this.inicio;
//             this.inicio = novoNo;
//         }
//     }

//     public Boolean desenfileirar()
//     {
//         No noAtual = this.inicio;
//         No noAnterior = null;

//         if (this.estaVazia())
//         {
//             return (false);
//         }
//         else
//         {
//             while (noAtual != null)
//             {
//                 if(noAtual.prox == null){
//                     noAnterior.prox = null;
//                     this.fim = noAnterior;
//                 }
//                 noAnterior = noAtual;
//                 noAtual = noAtual.prox;
//             }
//             return (true);
//         }
//     }

// public int contador(Fila fila){
//     No noAtual = this.inicio;
//     int cont = 0;

//     if(estaVazia()){
//         return 0;
//     } else {
//     while(noAtual != null){
//         cont++;
//         noAtual = noAtual.prox;
//     }
//     return cont;
//     }
// }
//     public void percurso()
//     {

//         No noAtual = this.inicio;

//         while (noAtual != null)
//         {
//             Console.Write(noAtual.valor + "-> ");
//             noAtual = noAtual.prox;
//         }
//         Console.WriteLine("\n");
//     }
// }