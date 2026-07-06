Algoritmo Lecc31_Act2_Inc1
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir fila, columna Como Entero
Definir matrizIdentidad Como Entero
Dimensionar matrizIdentidad[4, 4]

//Crear la matriz identidad de 4 x 4
Para fila <- 1 Hasta 4 Con Paso 1 Hacer
	Para columna <- 1 Hasta 4 Con Paso 1 Hacer
		Si fila = columna Entonces
			matrizIdentidad[fila, columna] <- 1
		SiNo
			matrizIdentidad[fila, columna] <- 0
		FinSi
	FinPara
FinPara

//Mostrar la matriz en consola
Escribir "Matriz identidad:"
Para fila <- 1 Hasta 4 Con Paso 1 Hacer
	Para columna <- 1 Hasta 4 Con Paso 1 Hacer
		Escribir Sin Saltar matrizIdentidad[fila, columna], "   "
	FinPara
	Escribir ""
FinPara
FinAlgoritmo
