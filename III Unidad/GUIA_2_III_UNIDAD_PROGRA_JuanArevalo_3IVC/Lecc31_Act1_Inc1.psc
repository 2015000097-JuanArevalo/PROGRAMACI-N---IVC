Algoritmo Lecc31_Act1_Inc1
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir fila, columna, i, j Como Entero
Definir matriz Como Entero
fila <- 3
columna <- 5
Dimensionar matriz[fila, columna]

//Ingresar los datos de la matriz
Para i <- 1 Hasta fila Con Paso 1 Hacer
	Para j <- 1 Hasta columna Con Paso 1 Hacer
		Escribir "Ingrese el número que quiere guardar en la fila ", i, ", columna ", j, " = "
		Leer matriz[i, j]
	FinPara
FinPara

//Mostrar los datos de la matriz
Escribir ""
Para i <- 1 Hasta fila Con Paso 1 Hacer
	Para j <- 1 Hasta columna Con Paso 1 Hacer
		Escribir "Fila: ", i, ", Columna: ", j, " = ", matriz[i, j]
	FinPara
FinPara
FinAlgoritmo
