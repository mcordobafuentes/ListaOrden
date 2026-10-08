
1. Comprobar si un archivo existe

Usa File.Exists para verificar la existencia de un archivo antes de abrirlo.
csharp
using System;
using System.IO;

string path = "archivo.txt";

if (File.Exists(path))
{
    Console.WriteLine("El archivo existe.");
}
else
{
    Console.WriteLine("El archivo no existe.");
}


2. Escribir texto en un archivo

Usa File.WriteAllText para crear un archivo y escribir texto en él (sobrescribe el contenido si ya existe).
csharp
using System.IO;

string path = "archivo.txt";
string contenido = "Hola, este es un ejemplo de texto en C#.";

File.WriteAllText(path, contenido);


3. Leer todo el contenido de un archivo

Usa File.ReadAllText para leer el contenido completo de un archivo de texto en una sola cadena.
csharp
using System;
using System.IO;

string path = "archivo.txt";

if (File.Exists(path))
{
    string texto = File.ReadAllText(path);
    Console.WriteLine(texto);
}


4. Añadir texto al final de un archivo

Usa File.AppendAllText para agregar contenido nuevo sin borrar el texto anterior.
csharp
using System.IO;

string path = "archivo.txt";
string nuevoTexto = "\nEsta es una nueva línea añadida.";

File.AppendAllText(path, nuevoTexto);


5. Eliminar un archivo

Usa File.Delete para borrar un archivo del disco.
csharp
using System.IO;

string path = "archivo.txt";

if (File.Exists(path))
{
    File.Delete(path);
}

Puedes ver una demostración práctica sobre cómo leer un archivo de texto paso a paso en el siguiente video:
8:53
C# Exercises - Files #1 - Reading a text file
8,6 K reproducciones · hace 6 años
YouTube · DiscoDurodeRoer
Si quieres, dime:
• ¿Necesitas trabajar con archivos muy grandes usando Streams?
• ¿Buscas ejemplos para manejar directorios o carpetas?
Te puedo dar los códigos exactos para eso.
• 
W3Schools
Archivos C# - W3Schools
Traducido — Ejemplo: Obtén tu propio servidor C#. using System . IO ; // include the System.IO namespace File . SomeFileMethod ( ) ; // use th...
• 
Coddy Tech
Docs ejecutables de C#: Leer y escribir archivos - Coddy Tech
Docs ejecutables de C#: Leer y escribir archivos | Coddy. ... Ver todos los cursos o elige un lenguaje arriba para empezar a apren...
• 
Microsoft Learn
File Clase (System.IO) | Microsoft Learn
Namespace: System.IO Assemblies: mscorlib.dll, netstandard.dll, System.Runtime.dll, System.IO.FileSystem.dll Source: File.cs Class...

No solo 10 ejemplos para estudiantes de File , archivos txt o csv

Aquí tienes 10 ejemplos prácticos de File en C# diseñados especialmente para estudiantes, organizados por su nivel de complejidad y enfocados en archivos .txt y .csv.

Ejemplos Básicos con archivos .txt


1. Crear un archivo y escribir una frase (WriteAllText)

Ideal para aprender a inicializar un archivo. Recuerda que este método sobrescribe el archivo si ya existe.
csharp
using System.IO;

string rutaTxt = "bienvenida.txt";
File.WriteAllText(rutaTxt, "¡Bienvenido al curso de programación en C#!");


2. Leer un archivo completo en una variable (ReadAllText)

Para mostrar en la consola todo lo que contiene un archivo de texto de un solo golpe.
csharp
using System;
using System.IO;

string rutaTxt = "bienvenida.txt";
if (File.Exists(rutaTxt))
{
    string contenido = File.ReadAllText(rutaTxt);
    Console.WriteLine("Contenido del archivo:\n" + contenido);
}


3. Escribir una lista de notas por líneas (WriteAllLines)

Útil cuando tienes un arreglo o lista de datos y quieres que cada elemento se guarde en una línea diferente.
csharp
using System.IO;

string[] tareas = { "1. Estudiar C#", "2. Hacer la tarea de BD", "3. Practicar algoritmos" };
File.WriteAllLines("tareas.txt", tareas);


4. Leer un archivo línea por línea (ReadAllLines)

Este método guarda cada línea del archivo en una posición de un arreglo. Es perfecto para recorrerlo con un ciclo foreach.
csharp
using System;
using System.IO;

string[] lineas = File.ReadAllLines("tareas.txt");
foreach (string linea in lineas)
{
    Console.WriteLine("Pendiente: " + linea);
}


5. Agregar un nuevo registro al final (AppendAllText)

Para simular una bitácora o un historial de eventos sin borrar lo que ya estaba escrito.
csharp
using System.IO;

string registro = "\n[Log 16:20] El usuario inició sesión.";
File.AppendAllText("log.txt", registro);


Ejemplos Intermedios y manejo de .csv


6. Guardar una matriz de datos en un .csv

Un archivo CSV separa las columnas con comas (o puntos y comas). Aquí guardamos una lista de alumnos.
csharp
using System.IO;

// Formato: Nombre,Edad,Calificación
string[] alumnos = {
    "Nombre,Edad,Nota",
    "Ana López,20,9.5",
    "Luis Pérez,22,8.0",
    "María Gómez,19,10.0"
};

File.WriteAllLines("alumnos.csv", alumnos);


7. Leer un .csv y separar sus datos (Split)

El ejercicio clásico de examen: leer un CSV, separar las columnas usando la coma , como delimitador y procesar la información.
csharp
using System;
using System.IO;

string[] filas = File.ReadAllLines("alumnos.csv");

// Empezamos en 1 para saltarnos el encabezado (Nombre, Edad, Nota)
for (int i = 1; i < filas.Length; i++)
{
    string[] columnas = filas[i].Split(',');
    string nombre = columnas[0];
    string nota = columnas[2];
    
    Console.WriteLine($"El alumno {nombre} tiene una nota de {nota}");
}


8. Copiar y respaldar un archivo (Copy)

Muestra cómo duplicar un archivo existente para crear una copia de seguridad (backup).
csharp
using System.IO;

string origen = "alumnos.csv";
string destino = "backup_alumnos.csv";

// El tercer parámetro 'true' permite sobrescribir el archivo de destino si ya existe
File.Copy(origen, destino, true);


9. Mover o renombrar un archivo (Move)

En C#, cambiar de nombre un archivo o moverlo de carpeta se hace con la misma función.
csharp
using System.IO;

// Cambia el nombre de "log.txt" a "historial_antiguo.txt"
if (File.Exists("log.txt"))
{
    File.Move("log.txt", "historial_antiguo.txt");
}


10. Obtener metadatos de un archivo (Fechas y Atributos)

Para proyectos donde necesitas saber cuándo se creó el archivo o cuándo fue la última modificación.
csharp
using System;
using System.IO;

string ruta = "alumnos.csv";

DateTime creacion = File.GetCreationTime(ruta);
DateTime modificacion = File.GetLastWriteTime(ruta);

Console.WriteLine($"Archivo: {ruta}");
Console.WriteLine($"Creado el: {creacion}");
Console.WriteLine($"Última modificación: {modificacion}");
