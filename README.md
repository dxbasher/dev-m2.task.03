# dev-m2.task.03
Tarea 03 del Módulo 02 - Desarrollo con Base de datos

## ¿Qué hicimos?

1) Hacer Fork del repositirio dev-m2.task.03 y clonarlo en su ambiente local. Para la configuración del proyecto se necesitó hacer lo siguiente: 
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet tool install -g dotnet-ef 

dotnet restore

dotnet ef dbcontext scaffold [ConnectionString] Microsoft.EntityFrameworkCore.SqlServer -o Models 

```
**Nota: El proyecto ya está configurado, si lo clonas solo hay que hacer `dotnet restore` y cambiar la cadena de conexion ** 

## TAREA 03

1) Crear una clase para manejar los archivos a leer ejemplo `FileTool.cs` 
2) Crear los métodos para leer los archivos de Entidades, Municipios y Localidades (extencion .csv)
3) Recorrer los valores de cada archivo e insertarlos en su tabla correspondiente.
    