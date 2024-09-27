using System.Reflection;

public class Retangulo{
    public double altura;
    public double largura;

    public Retangulo(){
        altura = 0;
        largura = 0;
    }
    public Retangulo(double valor){
        this.altura = valor;
        largura = valor;
    }
    public Retangulo(double altura, double largura){
        this.altura = altura;
        this.largura = largura;
    }
    public double CalcularArea(){
        return altura * largura;
    }
    public double CalcularPerimetro(){
        return (altura * 2) + (largura * 2);
    }
    public void Redimensionar(){

    }
    public void Redimensionar(double fator){
        this.altura *= fator;
        this.largura *= fator;
    }
    public void Redimensionar(double altura, double largura){
        this.altura = altura;
        this.largura = largura;
    }

}