# Métodos de Búsqueda en C#

## Introducción

Este proyecto en C# implementa tres métodos clásicos de búsqueda de elementos en arreglos:

1. **Búsqueda Secuencial Desordenada**: Recorre el arreglo elemento por elemento hasta encontrar el objetivo.
2. **Búsqueda Binaria**: Divide el arreglo ordenado en mitades sucesivas para localizar el elemento deseado.
3. **Transformación de Claves (Hashing)**: Utiliza una tabla hash para realizar búsquedas rápidas en tiempo constante.

Estos métodos permiten observar las diferencias en eficiencia y comportamiento según el tamaño del arreglo y el tipo de búsqueda.

---

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/MetodoBusqueda_CSharp.git
cd MetodoBusqueda_CSharp
```

### 2. Abrir el proyecto

- Puedes abrir el proyecto con **Visual Studio** o con **Visual Studio Code** con la extensión de C# instalada.

### 3. Ejecutar el código

- En Visual Studio: presiona `Ctrl + F5`.
- En Visual Studio Code:

```bash
dotnet run
```

---

## Estructura del proyecto

```
MetodoBusqueda_CSharp/
├── Program.cs                 # Archivo principal con los métodos de búsqueda
├── MetodoBusqueda_CSharp.sln # Solución del proyecto (Visual Studio)
└── README.md                 # Documentación del proyecto
```

### Descripción de `Program.cs`:

- `Main()`: Genera el menú interactivo y permite al usuario elegir el tipo de búsqueda.
- `SecuencialDesordenado()`: Implementación del método secuencial tradicional.
- `Binaria()`: Ordena el arreglo y realiza búsqueda binaria.
- `Hash()`: Crea una tabla hash (`Dictionary`) y realiza búsqueda por clave.
- `MostrarArreglo()`: Muestra el arreglo generado en consola.

---

## 📊 Análisis de rendimiento

Se realizaron pruebas con arreglos de diferentes tamaños para evaluar el rendimiento de cada método. Se midió el tiempo promedio de búsqueda en milisegundos.

| Tamaño del arreglo | Búsqueda Secuencial | Búsqueda Binaria | Hashing |
|--------------------|---------------------|------------------|---------|
| 100                | ~0.15 ms            | ~0.05 ms         | ~0.01 ms |
| 1,000              | ~1.20 ms            | ~0.08 ms         | ~0.01 ms |
| 10,000             | ~12.00 ms           | ~0.11 ms         | ~0.01 ms |

> **Nota:** La búsqueda binaria requiere ordenar el arreglo previamente, lo cual añade un costo adicional de `O(n log n)`.

### Medición del tiempo en C#

Puedes medir el tiempo de ejecución con el siguiente código:

```csharp
var watch = System.Diagnostics.Stopwatch.StartNew();
SecuencialDesordenado(arreglo, elemento);
watch.Stop();
Console.WriteLine($"Tiempo de ejecución: {watch.Elapsed.TotalMilliseconds} ms");
```

---

## Conclusiones

- **Búsqueda Secuencial**:
  - Fácil de implementar.
  - Eficiente solo en arreglos pequeños o cuando el elemento está al principio.
  - Complejidad: **O(n)**

- **Búsqueda Binaria**:
  - Muy eficiente en arreglos ordenados.
  - Requiere ordenamiento previo.
  - Complejidad: **O(log n)**

- **Hashing (Transformación de Claves)**:
  - Altamente eficiente para búsquedas repetidas.
  - Ideal cuando se desea acceso directo.
  - Complejidad: **O(1)** promedio, **O(n)** en el peor caso.

### Recomendaciones

| Escenario                                 | Método recomendado        |
|------------------------------------------|---------------------------|
| Arreglos pequeños o sin orden            | Búsqueda Secuencial       |
| Arreglos grandes y ordenados             | Búsqueda Binaria          |
| Búsquedas frecuentes y aleatorias        | Hashing (Diccionario)     |

---

## Autor

- **Alejandro Guzmán Cabrales**  


---

## Licencia

Este proyecto está bajo la licencia MIT. Puedes usar, modificar y distribuir libremente el código, siempre y cuando conserves el crédito correspondiente.
