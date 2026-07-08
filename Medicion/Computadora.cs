using System;
using System.Collections.Generic;

public class Computadora
{
    private string nombre;
    private string sistemaOperativo;
    private Laboratorio laboratorio;
    private ModeloPc modeloPc;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre de la computadora no puede estar vacío.");
            nombre = value.Trim();
        }
    }

    public string SistemaOperativo
    {
        get { return sistemaOperativo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El sistema operativo no puede estar vacío.");
            sistemaOperativo = value.Trim();
        }
    }

    public Laboratorio Laboratorio
    {
        get { return laboratorio; }
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            laboratorio = value;
        }
    }

    public ModeloPc ModeloPc
    {
        get { return modeloPc; }
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            modeloPc = value;
        }
    }

    public List<Medicion> Mediciones { get; private set; }

    public Computadora(string nombre, string sistemaOperativo, Laboratorio laboratorio, ModeloPc modeloPc)
    {
        Nombre = nombre;
        SistemaOperativo = sistemaOperativo;
        Laboratorio = laboratorio;
        ModeloPc = modeloPc;

        Mediciones = new List<Medicion>();

        laboratorio.AgregarComputadora(this);
    }

    public void AgregarMedicion(Medicion medicion)
    {
        if (medicion == null)
            throw new ArgumentNullException(nameof(medicion));

        Mediciones.Add(medicion);
    }
}