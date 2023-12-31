# EN - FastFoodResto
Project created for a university class. Has several requirements as follows: 
- Generic Methods
- Inheritance
- Interfaces
- String Formatting
- txt file writing
### ATTENTION: This project needs .net 3.1 runtime to work. 

## Description: 
This is a simple console project in wich it simulates a fast food store. It has all the functionalities of a CRUD as well as generating orders and "printing" them on .txt files. 

## How to use it:
.net 3.1 is needed to run. Once installed, you can use it with visual studio code and its integrated terminal as well as Visual Studio. You only need to open the main project, located in the root folder of the project. 

## Technical Aspects: 
- The application has a dummy db. It's a static list containing all the items. It was not a requirement to use SQL databases.
- The application has a set of Unit tests on the model where you can test the correct working of the object creation process.
- All the classes the print information into the txt files, implement the interface `IMostrarDatos.cs`. 



# ES - FastFoodResto
Proyecto creado para la clase de Calculo numerico, cuenta con una serie de requisitos como utilizar metodos genericos, herencia e interfaces. 
Tambien formatear strings y guardarlos en archivos .txt 
### ATENCION: Este proyecto necestia .net runtime 3.1 para funcionar

## Descripcion: 
Este es un proyecto de consola simple, en el cual se simula una tienda de comida rapida. 
Tiene todas las funcionalidades de CRUD de pedidos ademas de contar con funcionalidad para poder generar pedidos. 

## Como utilizarla: 
Se necesita .net 3.1 para correrla. Una vez descargado se puede correr tanto utilizando Visual Studio Code y la consola integrada,  como con Visual Studio 

## aspectos tecnicos: 
- La aplicacion tiene una base de datos dummy que es solamente una lista. No era requisito realizar conexion a base de datos.
- La aplicacion cuenta con tests unitarios para el modelo
- Todas las clases que necesiten informar datos dentro del ticket de compra implementan la interfaz `IMostrarDatos.cs`. De esta forma se logra que con una sola llamada podamos imprimir informacion de diferentes productos.
  
