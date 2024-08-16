public class Cliente{
    public string nome{ get; set; }
    public int idade {get; set; }
    public double valorPagoIngresso { get; set; }
    public bool pagouMeia { get; set; }

    public Cliente(string nome, int idade, double valorPagoIngresso, bool pagouMeia){
        this.nome = nome;
        this.idade = idade;
        this.valorPagoIngresso = valorPagoIngresso;
        this.pagouMeia = pagouMeia;
    }
}