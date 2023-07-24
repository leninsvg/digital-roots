# digital-roots

### BackEnd
#### Requisitos base de datos
En mi caso estoy utilizando docker para la base de datos adjunto el comando para generar la imagen 
`docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Nada1234*' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-CU8-ubuntu`
Una vez que se tenga la base de datos las migraciones se ejecutan de manera automatica.
En este proyecto considere lo siguiente:
 - Arquitectura por capas
 - Middleware para el manejo de errores
 - Migraciones
 - Errores customizados
 - Swagger para un testing a travez del navegador.
 - Toda la progracion esta realizada a travez de inyeccion de dependencias. 

### FrontEnd
Para el proyecto del front end solo tiene data de una semana para las pruebas, Toda la funcionalidad esta hecha a travez de rutas.

