# REST-API_Granja

La API REST para la gestión de animales en una granja está desarrollada usando .NET 8. Esta API proporciona operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para gestionar animales y tipos de animales. También incluye documentación integrada mediante Swagger para explorar y probar los endpoints de la API de manera interactiva.

## Características

- **Gestión de Animales**: Realiza operaciones CRUD en los registros de animales.
- **Gestión de Tipos de Animales**: Administra los diferentes tipos de animales.
- **Documentación Swagger**: Accede a la documentación completa de la API y realiza pruebas interactivas a través de Swagger UI.

## Configuración e Instalación

1. **Clonar el Repositorio**
   ```bash
   git clone https://github.com/jcomte23/REST-API_Granja.git
2. **Navegar al Directorio del Proyecto**
   ```bash
   cd REST-API_Granja
3. **Crear y Configurar el Archivo '.env' en base al archivo '.env.example'**
   ```bash
    DB_HOST = host
    DB_PORT = port
    DB_DATABASE = database
    DB_USERNAME = username
    DB_PASSWORD = password
4. **Restaurar Dependencias**
   ```bash
   dotnet restore
5. **Aplicar Migraciones**
   ```bash
   dotnet ef database update
6. **Ejecutar la Aplicación**
   ```bash
   dotnet run
## Contribuciones
Siéntete libre de enviar problemas, solicitudes de extracción o sugerencias. Para detalles sobre las contribuciones, consulta las directrices del proyecto.

## Licencia
Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.

## Contacto
Para cualquier pregunta o consulta, por favor contacta a jcomte23@outlook.com.

