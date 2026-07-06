Algoritmo Lecc17_Act3_Inc2
	//Encabezado
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
Definir fila, columna, x, yy, mayor Como Entero
Definir tabla Como Entero
Dimensionar tabla[4, 4]

//Ingresar los 16 datos en la matriz
Para fila <- 1 Hasta 4 Con Paso 1 Hacer
	Para columna <- 1 Hasta 4 Con Paso 1 Hacer
		Escribir "Ingrese un número para la fila ", fila, ", columna ", columna, ": "
		Leer tabla[fila, columna]
	FinPara
FinPara

//Tomar el primer dato como referencia
mayor <- tabla[1, 1]
x <- 1
yy <- 1

//Buscar el número mayor y guardar su posición
Para fila <- 1 Hasta 4 Con Paso 1 Hacer
	Para columna <- 1 Hasta 4 Con Paso 1 Hacer
		Si tabla[fila, columna] > mayor Entonces
			mayor <- tabla[fila, columna]
			x <- fila
			yy <- columna
		FinSi
	FinPara
FinPara

//Mostrar el resultado final
Escribir "El número mayor es: ", mayor
Escribir "Está en la fila: ", x
Escribir "Y en la columna: ", yy
FinAlgoritmo
