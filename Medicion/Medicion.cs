using System;

public class Medicion
{
    private int cpu;
    private double ram;
    private double temperatura;
    private bool conectada;
    private DateTime fecha;

    public int Cpu
    {
        get { return cpu; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("CPU debe estar entre 0 y 100%.");
            cpu = value;
        }
    }

    public double Ram
    {
        get { return ram; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("RAM debe estar entre 0 y 100%.");
            ram = value;
        }
    }

    public double Temperatura
    {
        get { return temperatura; }
        set
        {
            if (value < 0)
                throw new ArgumentException("La temperatura no puede ser negativa.");
            temperatura = value;
        }
    }

    public bool Conectada
    {
        get { return conectada; }
        set { conectada = value; }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        private set { fecha = value; }
    }

    public Medicion(int cpu, double ram, double temperatura, bool conectada)
    {
        Cpu = cpu;
        Ram = ram;
        Temperatura = temperatura;
        Conectada = conectada;
        Fecha = DateTime.Now;
    }
}