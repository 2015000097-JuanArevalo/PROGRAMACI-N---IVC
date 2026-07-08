Algoritmo Ejemplo_CRUD
	Definir opc Como Entero
	Definir estudiantes Como Caracter
	
	Dimensionar estudiantes[10, 3]
	
	Repetir
		Limpiar Pantalla
		Escribir "==========MENÚ PRINCIPAL=========="
		Escribir "1- Registrar"
		Escribir "2- Mostrar"
		Escribir "3- Actualizar"
		Escribir "4- Eiminar"
		Escribir "5- Salir"
		
		Escribir Sin Saltar "Digite una opción: "
		Leer opc
		
		Segun opc Hacer
			1:
				Limpiar Pantalla
				Escribir "==========Registrar Estudiantes=========="
				RegistrarEstudiantes(estudiantes)
				Escribir "Presiona una tecla para regresar..."
				Esperar Tecla
			2:
				Limpiar Pantalla
				Escribir "==========Mostrar Estudiantes=========="
				MostrarEstudiantes(estudiantes)
				Escribir "Presiona una tecla para regresar..."
				Esperar Tecla
			3:
				Limpiar Pantalla
				Escribir "==========Actualizar Estudiantes=========="
				Escribir "Presiona una tecla para regresar..."
				Esperar Tecla
			4:
				Limpiar Pantalla
				Escribir "==========Eliminar Estudiantes=========="
				EliminarEstudiante(estudiantes)
				Escribir "Presiona una tecla para regresar..."
				Esperar Tecla
			5:
				Limpiar Pantalla
				Escribir "¡Saliendo del sistema!"
				Escribir "Presiona una tecla para salir..."
				Esperar Tecla
			De Otro Modo:
				Escribir "Digite una opción válida"
				Escribir "Presiona una tecla para regresar..."
				Esperar Tecla
		FinSegun
	Hasta Que opc = 5
FinAlgoritmo

//SubProceso de registrar un estudiantes
SubProceso RegistrarEstudiantes(estudiantes)
	Definir i Como Entero
	
	Para i=1 Hasta 3 Con Paso 1 Hacer
		Si estudiantes[i, 1] = "" Entonces
			Escribir Sin Saltar "Código: "
			Leer estudiantes[i, 1]
			Escribir Sin Saltar "Nombre: "
			Leer estudiantes[i, 2]
			Escribir Sin Saltar "Edad: "
			Leer estudiantes[i, 3]
			Escribir "¡Datos almacenados con éxito!"
		Fin Si
	Fin Para
	
	Escribir "Matriz llena"
FinSubProceso

//Mostrar los datos
SubProceso MostrarEstudiantes(estudiantes)
	Definir i Como Entero
	
	Escribir "CÓDIGO      NOMBRE      EDAD"
	Escribir "----------------------------"
	
	Para i <- 1 Hasta 10 Con Paso 1 Hacer
		Si estudiantes[i, 1] <> "" Entonces
			Escribir estudiantes[i, 1], "      ", estudiantes[i, 2], "      ", estudiantes[i, 3]
		Fin Si
	Fin Para
FinSubProceso

SubProceso EliminarEstudiante(estudiantes)
	Definir codigo Como Caracter
	Escribir "Digite el código del estudiante: "
	Leer codigo
	
	Para i=1 Hasta 10 Con Paso 1 Hacer
		Si estudiantes[i, 1] = codigo Entonces
			estudiantes[i, 1] = ""
			estudiantes[i, 2] = ""
			estudiantes[i, 3] = ""
			Escribir "Registro eliminado"
		SiNo
			Escribir "Estudiante eliminado"
		FinSi
	FinPara
FinSubProceso
