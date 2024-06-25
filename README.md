# Proyecto Hotel  FechaNacimiento - Pruebas Unitarias

Este proyecto es una parte del sistema de gestión de clientes que implementa un value object `FechaNacimiento` para manejar la fecha de nacimiento de una persona. En este documento se explica el funcionamiento de las pruebas unitarias, que son fundamentales para garantizar la fiabilidad y consistencia de este componente.

## Pruebas Unitarias

Las pruebas unitarias son una parte esencial del desarrollo de software, ya que permiten verificar que los componentes individuales del sistema funcionen correctamente. En este proyecto, las pruebas unitarias se centran en la clase `FechaNacimiento`, asegurando que sus propiedades y comportamientos sean los esperados.

### Estructura de la Clase FechaNacimiento

La clase `FechaNacimiento` representa la fecha de nacimiento de una persona y contiene las siguientes funcionalidades:

- **EsMayorDeEdad()**: Verifica si la persona es mayor de edad (18 años o más).
- **Valor()**: Devuelve la fecha de nacimiento almacenada en el objeto.

### Pruebas Unitarias Implementadas

Se han implementado varias pruebas unitarias para asegurar la correcta funcionalidad de `FechaNacimiento`:

#### 1. Verificación de Mayoría de Edad

**Propósito**: Verificar que el método `EsMayorDeEdad` retorne `true` para personas de 18 años o más y `false` para personas menores de 18 años.

**Descripción**:
- Se crean instancias de `FechaNacimiento` con fechas que representan individuos de diferentes edades.
- Se invoca el método `EsMayorDeEdad` para cada instancia y se verifica el resultado.
- La prueba asegura que el método identifica correctamente a las personas mayores y menores de edad.

#### 2. Valor de la Fecha de Nacimiento

**Propósito**: Verificar que el método `Valor` retorne la fecha de nacimiento almacenada correctamente.

**Descripción**:
- Se crean instancias de `FechaNacimiento` con fechas específicas.
- Se invoca el método `Valor` y se compara con la fecha proporcionada al crear la instancia.
- La prueba asegura que no haya modificaciones o errores en el almacenamiento de la fecha.

### Cómo Ejecutar las Pruebas

Para ejecutar las pruebas unitarias, sigue estos pasos:

#### Clona el Repositorio

Clona el repositorio y abre el proyecto en tu IDE preferido.

#### Instala las Dependencias

Asegúrate de tener todas las dependencias necesarias instaladas en tu entorno de desarrollo.

#### Ejecuta las Pruebas

Navega a la carpeta de pruebas en tu proyecto y ejecuta los tests utilizando el comando de tu framework de pruebas. Por ejemplo, si estás usando XUnit, puedes usar el comando:
```bash
dotnet test
