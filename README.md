
### Requisitos

- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/5.0) 
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Configuracion de la base de datos:
- Crear Database: Ejecutar el script CoelsaContacts.sql.  Ruta : \CoelsaContacts\DB
- Crear la tabla Contacts: Una vez creada la base, ejecutar el script Contacts.sql que se ubica en la carpeta DB. Ruta : \CoelsaContacts\DB

- Agregar el connectionstring en el archivo appsettings.json. Ruta: CoelsaContacts\CoelsaContacts.Api

- Indicar el nombre de la instancia 

```
"{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source= NOMBREDELAINSTANCIA ;Initial Catalog=CoelsaContacts;Integrated Security=True;Pooling=False"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}"
```

### Run

- El proyecto integra Swagger por lo tanto al ejecutarlo se podra testear desde el exporador la API al seleccionar IIS Express en Visual Studio.
