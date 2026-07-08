using System;

public class ModeloPc
{
    private string marca;
    private string modelo;
    private string procesador;
    private int ramGb;

    public string Marca
    {
        get { return marca; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La marca no puede estar vacía.");
            marca = value.Trim();
        }
    }

    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El modelo no puede estar vacío.");
            modelo = value.Trim();
        }
    }

    public string Procesador
    {
        get { return procesador; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El procesador no puede estar vacío.");
            procesador = value.Trim();
        }
    }

    public int RamGb
    {
        get { return ramGb; }
        set
        {
            if (value <= 0 || value > 128)
                throw new ArgumentException("La RAM debe estar entre 1 y 128 GB.");
            ramGb = value;
        }
    }

    public ModeloPc(string marca, string modelo, string procesador, int ramGb)
    {
        Marca = marca;
        Modelo = modelo;
        Procesador = procesador;
        RamGb = ramGb;
    }
}