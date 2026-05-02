Algoritmo Lecc10_Act03_Inc01
	Definir numero, divisor, suma Como Entero
	Definir esPrimo Como Logico
	suma = 0
	
	Escribir "====================================="
	Escribir "       PRIMOS ENTRE 1 Y 22"
	Escribir "====================================="
	
	Para numero = 1 Hasta 22 Con Paso 1 Hacer
		esPrimo = Verdadero
		
		Si numero <= 1 Entonces
			esPrimo = Falso
		FinSi
		
		Para divisor = 2 Hasta numero - 1 Con Paso 1 Hacer
			Si numero MOD divisor = 0 Entonces
				esPrimo = Falso
			FinSi
		FinPara
		
		Si esPrimo = Verdadero Entonces
			Escribir numero
			suma = suma + numero
		FinSi
	FinPara
	
	Escribir "-------------------------------------"
	Escribir "La suma de los números primos entre 1 y 22 es: ", suma
	Escribir "Proceso finalizado."
FinAlgoritmo
