Algoritmo Lecc15_Act03_Inc02
	Definir numero, divisor, cantidadPrimos, cantidadPares, sumaPares Como Entero
	Definir esPrimo Como Logico
	numero = 300
	cantidadPrimos = 0
	cantidadPares = 0
	sumaPares = 0
	
	Escribir "====================================="
	Escribir "  CUENTA REGRESIVA, PRIMOS Y PARES"
	Escribir "====================================="
	
	Mientras numero >= 1 Hacer
		Si numero MOD 2 = 0 Entonces
			cantidadPares = cantidadPares + 1
			sumaPares = sumaPares + numero
		FinSi
		
		esPrimo = Verdadero
		Si numero <= 1 Entonces
			esPrimo = Falso
		FinSi
		
		divisor = 2
		Mientras divisor < numero Hacer
			Si numero MOD divisor = 0 Entonces
				esPrimo = Falso
			FinSi
			divisor = divisor + 1
		FinMientras
		
		Si esPrimo = Verdadero Entonces
			cantidadPrimos = cantidadPrimos + 1
		FinSi
		
		numero = numero - 1
	FinMientras
	
	Escribir "Cantidad de números primos entre 300 y 1: ", cantidadPrimos
	Escribir "Cantidad de números pares entre 300 y 1: ", cantidadPares
	Escribir "Suma de los pares: ", sumaPares
FinAlgoritmo
