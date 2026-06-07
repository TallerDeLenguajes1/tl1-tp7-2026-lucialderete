public enum Cargos
{
    Auxiliar, //0
    Administrativo, //1
    Ingeniero, //2
    Especialista, //3
    Investigador //4
    
}

public class Empleado
{
    private string nombre;
    public string Nombre
    {
        get {return nombre;}
        set {nombre = value;}
    }

    private string apellido;
    public string Apellido
    {
        get{return apellido;}
        set{apellido = value;}
    }

    private DateTime fechaNac;
    public DateTime FechaNac
    {
        get{return fechaNac;}
        set{fechaNac = value;}
    }

    private char estadoCivil;
    public char EstadoCivil
    {
        get{return estadoCivil;}
        set{estadoCivil = value;}
    }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso
    {
        get{ return fechaIngreso;}
        set {fechaIngreso = value;}
    }

    private double sueldoBasico;
    public double SueldoBasico
    {
        get{return sueldoBasico;}
        set{sueldoBasico = value;}
    }

    private Cargos cargo;
    public Cargos Cargo
    {
        get{return cargo;}
        set{cargo = value;}
    }

    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo){
        this.nombre = nombre;
        this.apellido=apellido;
        this.fechaNac= fechaNac;
        this.estadoCivil=estadoCivil;
        this.fechaIngreso=fechaIngreso;
        this.sueldoBasico=sueldoBasico;
        this.cargo=cargo;
    }
    //punto 2ai
    public int CalcularAntiguedad()
    {
        int antiguedad = DateTime.Today.Year - fechaIngreso.Year;
        return antiguedad;
    }

    //punto 2aii
    public int CalcularEdad()
    {
        int edad = DateTime.Today.Year - fechaNac.Year;
        return edad;
    }

    //punto 2 a iii
    public int AniosJubilacion()
    {
        int edadJubilatoria =65;
        int edad = CalcularEdad();
        int aniosParaJubilarse = edadJubilatoria - edad;
        return aniosParaJubilarse;
    }

    //punto 2b i
    public double CalcularSalario()
    {
        int antiguedad = CalcularAntiguedad();
        double adicional;
        double porcentaje;
        double salario;
        if (antiguedad <= 20)
        {
            porcentaje=antiguedad/100.0;
        }
        else
        {
            porcentaje = 0.25;
        }

        adicional = sueldoBasico * porcentaje;

        //2b ii
        if(cargo== Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional = adicional*(1+0.5);
        }

        //2b iii
        if(estadoCivil== 'C')
        {
            adicional+=150000;
        }
        salario = sueldoBasico + adicional;
        return salario;
    }
}


