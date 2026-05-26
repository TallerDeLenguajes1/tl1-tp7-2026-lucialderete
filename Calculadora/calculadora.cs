namespace EspacioCalculadora;

public class calculadora{

    private double dato;
    public void sumar(double termino){
        dato += termino;
    }
    public void restar(double termino){
        dato -= termino;
    }
    public void multiplicar(double termino){
        dato *= termino;
    }
    public void dividir(double termino){
        if(termino != 0){
            dato /= termino;
        }else{
            Console.WriteLine("Error. no se puede dividir en cero");
        }
    }
    public void limpiar(){
        dato=0;
    }

    public double resultado{
        get => dato;
    }
}