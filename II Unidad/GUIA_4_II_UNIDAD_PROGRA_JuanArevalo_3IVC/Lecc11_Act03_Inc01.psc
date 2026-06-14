Algoritmo Lecc11_Act03_Inc01
	Definir numero1, numero2, menor, mayor, actual, suma Como Entero
	suma = 0
	
	Escribir "====================================="
	Escribir "      SUMA ENTRE DOS NÚMEROS"
	Escribir "====================================="
	Escribir "Ingrese el primer número: "
	Leer numero1
	Escribir "Ingrese el segundo número: "
	Leer numero2
	
	Si numero1 < numero2 Entonces
		menor = numero1
		mayor = numero2
	SiNo
		menor = numero2
		mayor = numero1
	FinSi
	
	actual = menor
	Repetir
		suma = suma + actual
		actual = actual + 1
	Hasta Que actual > mayor
	
	Escribir "-------------------------------------"
	Escribir "Número menor: ", menor
	Escribir "Número mayor: ", mayor
	Escribir "La suma total es: ", suma
FinAlgoritmo
