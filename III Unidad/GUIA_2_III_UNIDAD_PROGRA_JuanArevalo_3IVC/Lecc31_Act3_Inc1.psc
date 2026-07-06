Algoritmo Lecc31_Act3_Inc1
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir fila, columna, edad Como Entero
Definir edades Como Entero
Definir estado Como Caracter
Dimensionar edades[3, 3]
Dimensionar estado[3, 3]

//Ingresar la edad de cada estudiante
Para fila <- 1 Hasta 3 Con Paso 1 Hacer
	Para columna <- 1 Hasta 3 Con Paso 1 Hacer
		Escribir "Ingrese la edad del estudiante en la fila ", fila, ", columna ", columna, ": "
		Leer edad
		edades[fila, columna] <- edad

		Si edad >= 18 Entonces
			estado[fila, columna] <- "mayor"
		SiNo
			estado[fila, columna] <- "menor"
		FinSi
	FinPara
FinPara

//Mostrar la matriz con edad y clasificación
Escribir "Matriz de edades:"
Para fila <- 1 Hasta 3 Con Paso 1 Hacer
	Para columna <- 1 Hasta 3 Con Paso 1 Hacer
		Escribir Sin Saltar edades[fila, columna], " - ", estado[fila, columna], "   |   "
	FinPara
	Escribir ""
FinPara
FinAlgoritmo
