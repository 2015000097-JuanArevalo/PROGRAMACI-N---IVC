Algoritmo Lecc11_Act03_Inc02
	Definir numero, suma Como Entero
	suma = 0
	
	Escribir "====================================="
	Escribir "       SUMA HASTA INGRESAR 0"
	Escribir "====================================="
	Escribir "Ingrese números para sumarlos."
	Escribir "Cuando ingrese 0, el programa termina."
	
	Repetir
		Escribir "Ingrese un número: "
		Leer numero
		suma = suma + numero
		Escribir "Suma actual: ", suma
	Hasta Que numero = 0
	
	Escribir "-------------------------------------"
	Escribir "La suma final es: ", suma
FinAlgoritmo
