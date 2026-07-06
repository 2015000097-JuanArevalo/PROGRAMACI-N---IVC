Algoritmo Lecc17_Act2_Inc1
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir numeroFila, numeroColumna Como Entero
Definir matrizIdentidad Como Entero
Dimensionar matrizIdentidad[4, 4]

//Crear la matriz identidad de 4 x 4
Para numeroFila <- 1 Hasta 4 Con Paso 1 Hacer
	Para numeroColumna <- 1 Hasta 4 Con Paso 1 Hacer
		Si numeroFila = numeroColumna Entonces
			matrizIdentidad[numeroFila, numeroColumna] <- 1
		SiNo
			matrizIdentidad[numeroFila, numeroColumna] <- 0
		FinSi
	FinPara
FinPara

//Mostrar la matriz
Escribir "Matriz identidad:"
Para numeroFila <- 1 Hasta 4 Con Paso 1 Hacer
	Para numeroColumna <- 1 Hasta 4 Con Paso 1 Hacer
		Escribir Sin Saltar matrizIdentidad[numeroFila, numeroColumna], "   "
	FinPara
	Escribir ""
FinPara
FinAlgoritmo
