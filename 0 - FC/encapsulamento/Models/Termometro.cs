namespace encapsulamento;

public class Termometro
{
    private double TemperaturaCelsius { get; set; }

    public void AjustarTemperatura(double grausCelsius){
        TemperaturaCelsius = grausCelsius;
    }

    public double LerTemperatura(){
        return TemperaturaCelsius;
    }
}