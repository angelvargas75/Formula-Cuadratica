# Resolución de Ecuaciones Cuadráticas en .NET 8

![.NET Version](https://img.shields.io/badge/.NET-8-blue)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Una aplicación de consola que resuelve ecuaciones cuadráticas utilizando la fórmula general, con soporte para raíces reales y complejas.


## 📌 Tabla de Contenidos
- [Descripción](#-descripción)
- [Características](#-características)
- [Requisitos](#-requisitos)
- [Instalación](#-instalación)
- [Uso](#-uso)
- [Ejemplos](#-ejemplos)
- [Estructura del Código](#-estructura-del-código)
- [Contribuciones](#-contribuciones)
- [Licencia](#-licencia)


## Descripción
Este programa resuelve ecuaciones cuadráticas de la forma ax² + bx + c = 0 utilizando la fórmula cuadrática. El programa calcula y muestra las raíces de la ecuación, incluyendo casos con raíces reales diferentes, raíces reales iguales (dobles) y raíces complejas.


## Características
- Interfaz de consola simple e intuitiva

- Validación de entrada para evitar errores

- Cálculo preciso del discriminante

- Manejo de raíces complejas con representación simplificada

- Simplificación de radicales para resultados más limpios

- Manejo de errores para entradas inválidas


## Requisitos 
- .NET 8 SDK


## Instalación y ejecución
1. Clona el repositorio:
   ```bash
   git clone https://github.com/angelvargas75/Formula-Cuadratica.git

2. Navega al directorio del proyecto:
   ```bash
   cd Formula Cuadratica

3. Ejecuta la aplicación:
   ```bash
   dotnet run


## Uso
1. Ejecuta el programa desde la terminal/consola.

2. Ingresa los coeficientes a, b y c cuando se te solicite.

    - a no puede ser cero (esto convertiría la ecuación en lineal).

3. El programa mostrará:

    - El valor del discriminante

    - Las raíces de la ecuación (reales o complejas)


## Ejemplos de Entrada/Salida
Caso 1: Raíces reales diferentes (Δ > 0)
```
=== ECUACIÓN DE SEGUNDO GRADO ===
Forma: ax² + bx + c = 0

Valor de a: 1
Valor de b: -5
Valor de c: 6

Discriminante: 1
Raíces reales diferentes:
x1 = 3
x2 = 2
```

Caso 2: Raíz real doble (Δ = 0)
```
=== ECUACIÓN DE SEGUNDO GRADO ===
Forma: ax² + bx + c = 0

Valor de a: 1
Valor de b: -4
Valor de c: 4

Discriminante: 0
Raíz real doble:
x = 2
```

Caso 3: Raíces complejas (Δ < 0)
```
=== ECUACIÓN DE SEGUNDO GRADO ===
Forma: ax² + bx + c = 0

Valor de a: 1
Valor de b: 2
Valor de c: 5

Discriminante: -16
Raíces complejas:
x1 = -1 + 2i
x2 = -1 - 2i
```


## Estructura del Código
El proyecto contiene un único archivo Program.cs con las siguientes funciones principales:

1. Main(): Punto de entrada del programa, maneja la interacción con el usuario.

2. ResolverEcuacion(double a, double b, double c): Calcula y muestra las raíces de la ecuación cuadrática.

3. SimplificarRaiz(int valor): Simplifica radicales para una mejor presentación de raíces complejas.


## Contribuciones 
¡Las contribuciones son bienvenidas! Si deseas mejorar este proyecto:

1. Haz un fork del repositorio

2. Crea una rama con tu feature (git checkout -b feature/nueva-funcionalidad)

3. Haz commit de tus cambios (git commit -am 'Añade nueva funcionalidad')

4. Haz push a la rama (git push origin feature/nueva-funcionalidad)

5. Abre un Pull Request


## Licencia 
Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.
