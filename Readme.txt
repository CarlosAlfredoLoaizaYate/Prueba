Se creo la interfaz para consumir el api con Angular 8 (front-end)"Angular"
Se creo Base de datos con ORM Entity Framework Core usando Code First
Se uso un motor de base de datos relacional (sql server)
Se uso vs 2019 para el (back-end) "SolucionBiblioteca"
Se uso vs code para el (front-end)"Angular"
Se creo un api en .net core 2.2 (back-end) "SolucionBiblioteca"
se crearon los crud correspondientes para poder alimentar la base de datos
-------------------------------------------------------------------------------------
1. Cambiar dentro del back-end en el archivo "appsettings.json" etiqueta "DevConnection" por la información del servidor de base de datos correspondiente.
2. ejecutar en la ventana de "Package Manager Console" los comandos de migración y actualizacion de base de datos "Add-Migration" mas el nombre y "Update-Database"
3. Ejecutar back-end 
4. Ejecutar front-end
5. Verificar dentro del back-end que en el archivo "Startup.cs" metodo "Configure" este el localhost con el respectivo puerto 
   que genero al ejecutar el front-end
6. Varificar dentro de "Angular\src\app\shared" todos los servicios para que estos esten apuntando al localhost con puerto generado desde el back-end



	

