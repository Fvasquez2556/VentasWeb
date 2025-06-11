# VentasWeb

Aplicación web ASP.NET Core con Razor Pages para gestionar y visualizar productos vendidos por categoría durante el año 2019.

## 🧩 Funcionalidades

- Filtro de productos por categoría con historial de ventas en 2019.
- Poblado automático de la base de datos al ejecutar por primera vez.
- Vista clara de productos disponibles según categoría.
- Estructura modular con separación entre modelos, datos y lógica de presentación.

## 🚀 Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Fvasquez2556/VentasWeb
   ```

2. Abre `VentasWeb.sln` con Visual Studio 2022 o superior.

antes de ejecutar el ptoyecto, verificar si las dependencias correspondientes estan instaladas, de no ser así o no estar seguro, leer el manual de usuario. 

3. Ejecuta el proyecto con `Ctrl + F5` (sin depuración).

4. La aplicación se abrirá en el navegador, normalmente en [http://localhost:5000](http://localhost:5000).

5. Para ver la funcionalidad principal, navega a:  
   [http://localhost:5000/ProductosPorCategoria2019](http://localhost:5000/ProductosPorCategoria2019)

## 📦 Tecnologías utilizadas

- ASP.NET Core 8.0
- Razor Pages
- Entity Framework Core
- SQL Server Express
- Visual Studio 2022

## 🧠 Estructura del proyecto

- `/Pages/`: Contiene las Razor Pages (UI).
- `/Models/`: Define las entidades `Producto`, `Categoria`, `Venta`.
- `/Data/`: Contiene `AppDbContext` y `DbInitializer` para configuración de base.
- `Program.cs`: Configura y lanza la aplicación.

## 🛠 Dependencias

- .NET 8 SDK: [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server Express o LocalDB
- Visual Studio con ASP.NET y desarrollo web

## 👨‍💻 Desarrollado por

Félix – 2025
