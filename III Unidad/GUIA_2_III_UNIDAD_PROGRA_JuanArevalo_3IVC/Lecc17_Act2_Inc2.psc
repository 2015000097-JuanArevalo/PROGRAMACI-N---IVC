Algoritmo Lecc17_Act2_Inc2
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir numeroFila, numeroColumna Como Entero
Definir matrizColumnas Como Entero
Dimensionar matrizColumnas[4, 4]

//Crear una matriz donde cada fila contiene 1, 2, 3 y 4
Para numeroFila <- 1 Hasta 4 Con Paso 1 Hacer
	Para numeroColumna <- 1 Hasta 4 Con Paso 1 Hacer
		matrizColumnas[numeroFila, numeroColumna] <- numeroColumna
	FinPara
FinPara

//Mostrar la matriz
Escribir "Matriz de columnas:"
Para numeroFila <- 1 Hasta 4 Con Paso 1 Hacer
	Para numeroColumna <- 1 Hasta 4 Con Paso 1 Hacer
		Escribir Sin Saltar matrizColumnas[numeroFila, numeroColumna], "   "
	FinPara
	Escribir ""
FinPara
FinAlgoritmo
