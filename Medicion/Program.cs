using System;

class Program
{
    static void Main()
    {
        try
        {
            Laboratorio lab = new Laboratorio("Lab 101", "Piso 2");

            ModeloPc modelo = new ModeloPc(
                "Dell",
                "Optiplex 7090",
                "Intel i7-11700",
                16);

            Computadora pc1 = new Computadora(
                "PC-001",
                "Windows 11",
                lab,
                modelo);

            Medicion medicion = new Medicion(
                45,
                67.5,
                45.2,
                true);

            pc1.AgregarMedicion(medicion);

            Console.WriteLine("Laboratorio: " + lab.Nombre);
            Console.WriteLine("Ubicación: " + lab.Ubicacion);
            Console.WriteLine("Cantidad de computadoras: " + lab.CantidadComputadoras);

            Console.WriteLine();

            Console.WriteLine("Computadora: " + pc1.Nombre);
            Console.WriteLine("Sistema Operativo: " + pc1.SistemaOperativo);
            Console.WriteLine("Modelo: " + pc1.ModeloPc.Marca + " " + pc1.ModeloPc.Modelo);

            Console.WriteLine();

            Console.WriteLine("Medición");
            Console.WriteLine("CPU: " + medicion.Cpu + "%");
            Console.WriteLine("RAM: " + medicion.Ram + "%");
            Console.WriteLine("Temperatura: " + medicion.Temperatura + " °C");
            Console.WriteLine("Conectada: " + medicion.Conectada);

            Medicion medicionInvalida = new Medicion(150, 120.5, -5, false);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}