Algoritmo Lecc24_Act03_Inc02
	Definir numero, i, suma Como Entero
	suma = 0
	
	Escribir "====================================="
	Escribir "      SUMA REGRESIVA HASTA 1"
	Escribir "====================================="
	Escribir "Ingrese un número entero: "
	Leer numero
	
	Escribir "-------------------------------------"
	Para i = numero Hasta 1 Con Paso -1 Hacer
		suma = suma + i
		Escribir i
	FinPara
	
	Escribir "-------------------------------------"
	Escribir "La suma es: ", suma
FinAlgoritmo
