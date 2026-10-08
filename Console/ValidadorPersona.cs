// 3. Clase encargada de validar que los datos cumplan ciertas reglas
public class ValidadorPersona : IValidate
{
    public bool Validar(string nombre, string telefono)
    {
        // Regla 1: El nombre no puede estar vacío
        if (string.IsNullOrWhiteSpace(nombre)) return false;

        // Regla 2: El teléfono debe tener al menos 8 caracteres (ejemplo básico)
        if (string.IsNullOrWhiteSpace(telefono) || telefono.Length < 8) return false;

        return true;
    }
}
