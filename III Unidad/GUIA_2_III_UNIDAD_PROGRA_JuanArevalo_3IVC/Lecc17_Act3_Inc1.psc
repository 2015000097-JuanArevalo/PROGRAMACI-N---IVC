Algoritmo Lecc17_Act3_Inc1
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir fila, columna, num, suma Como Entero
Definir tabla Como Entero
Dimensionar tabla[4, 3]

//Ingresar datos y calcular la suma de cada fila
Para fila <- 1 Hasta 4 Con Paso 1 Hacer
	suma <- 0
	Para columna <- 1 Hasta 3 Con Paso 1 Hacer
		Escribir "Ingrese un número para la fila ", fila, ", columna ", columna, ": "
		Leer num
		tabla[fila, columna] <- num
		suma <- suma + num
	FinPara
	Escribir "La suma de la fila ", fila, " es: ", suma
FinPara
FinAlgoritmo
