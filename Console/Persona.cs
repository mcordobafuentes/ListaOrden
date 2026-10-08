using System;
using System.Collections.Generic;

// 1. Interfaz personalizada para validar los datos de la persona
public interface IValidate
{
    bool Validar(string nombre, string telefono);
}

// 2. Clase Persona que implementa IComparable para poder ordenarse sola
public class Persona : IComparable<Persona>
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    public Persona(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }

    // Implementación de IComparable. Define el criterio de ordenamiento por defecto.
    public int CompareTo(Persona? otraPersona)
    {
        if (otraPersona == null) return 1;

        // Ordenamos alfabéticamente por el Nombre
        return this.Nombre.CompareTo(otraPersona.Nombre);
    }

    public override string ToString()
    {
        return $"{Nombre} - Tel: {Telefono}";
    }
}