using System;
using System.Collections.Generic;

public class Laboratorio
{
    private string nombre;
    private string ubicacion;
    private List<Computadora> computadoras;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre del laboratorio no puede estar vacío.");
            nombre = value.Trim();
        }
    }

    public string Ubicacion
    {
        get { return ubicacion; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La ubicación del laboratorio no puede estar vacía.");
            ubicacion = value.Trim();
        }
    }

    public List<Computadora> Computadoras
    {
        get { return new List<Computadora>(computadoras); }
    }

    public Laboratorio(string nombre, string ubicacion)
    {
        Nombre = nombre;
        Ubicacion = ubicacion;
        computadoras = new List<Computadora>();
    }

    public void AgregarComputadora(Computadora computadora)
    {
        if (computadora == null)
            throw new ArgumentNullException(nameof(computadora));

        computadoras.Add(computadora);
    }

    public int CantidadComputadoras
    {
        get { return computadoras.Count; }
    }
}