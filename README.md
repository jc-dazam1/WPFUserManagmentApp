# UserManagmentApp

## AXA PARTNERS

Descripción

Se realiza solución WPF usando lenguaje C#, .Net Framework, Entity Framework y motor de BD Postgress en la que se cuenta con las siguientes interfaces principales:
- Creacion de usuarios
- Listar Usuarios
- Editar Usuarios
- Listar áreas
- Asignar Usuario Areas

## Interfaces:

1. Interfaces Usuarios

- Creación de Usuarios donde se capture los datos básicos del nuevo usuario y una vez guardado, listar los últimos 10 registros creados

- Edición datos de contacto del usuario seleccionado.

2. Interfaces 

- Interfaz de usuario donde se listen las áreas de la Empresa (Nomina, Facturación, Servicio al Cliente, IT, etc) 
- Asignación de un usuario a una única área.


##Tener en cuenta:
- Despues de instalacion de Nuggets necesarios para el proyecto, se debe ejecutar comandos:
        - dotnet ef migrations add initial
        - dotnet ef database update --verbose

![Screenshot of a comment on a GitHub issue showing an image, added in the Markdown, of an Octocat smiling and raising a tentacle.](https://i.ibb.co/bgpKGrM/Usuarios-Areas.png)


