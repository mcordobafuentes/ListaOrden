class Program
{
    static void Main(string[] args)
    {
        List<Persona> listaPersonas = new List<Persona>(){
            new Persona("Ana", "12345678"),
            new Persona("Luis", "87654321"),
            new Persona("Carlos", "23456789"),
            new Persona("Beatriz", "34567890")
        };

        AgregarPersonaSegura(listaPersonas, new ValidadorPersona(), "Diana", "45678901");


        // 3. Ordenar la lista automáticamente gracias a CompareTo
        listaPersonas.Sort();

        RegistrarActividad("Listar ordenado");
        Console.WriteLine("\n--- Lista Ordenada Alfabéticamente (.Sort) ---");
        MostrarLista(listaPersonas);

        // 4. Invertir el orden (Z a la A)
        listaPersonas.Reverse();

        RegistrarActividad("Listar invertida");
        Console.WriteLine("\n--- Lista Invertida (.Reverse) ---");
        MostrarLista(listaPersonas);

        // Formato: Nombre,Edad,Calificación
        string[] alumnos = {
            "Nombre,Edad,Nota",
            "Ana López,20,9.5",
            "Luis Pérez,22,8.0",
            "María Gómez,19,10.0"
        };

        File.WriteAllLines("alumnos.csv", alumnos);
    }

    // Método auxiliar para simular la inserción segura
    static void MostrarLista(List<Persona> lista)
    {
        foreach (var persona in lista)
        {
            Console.WriteLine($"- {persona}");
        }
    }
    static void AgregarPersonaSegura(List<Persona> lista, ValidadorPersona validador, string nombre, string telefono)
    {
        if (validador.Validar(nombre, telefono))
        {
            lista.Add(new Persona(nombre, telefono));
        }
        else
        {
            Console.WriteLine($"[Error] Registro rechazado: Nombre='{nombre}', Teléfono='{telefono}'");
        }
    }

    static void RegistrarActividad(string actividad)
    {
        const string usuario = "usuario_demo";
        string entrada = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | Usuario: {usuario} | Actividad: {actividad}{Environment.NewLine}";
        File.AppendAllText("actividad.txt", entrada);
    }

}