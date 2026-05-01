Algoritmo Lecc15_Act02_Inc01
	Definir numero, divisor, contadorPrimos Como Entero
	Definir esPrimo Como Logico
	contadorPrimos = 0
	
	Escribir "====================================="
	Escribir "       PRIMOS ENTRE 1 Y 10"
	Escribir "====================================="
	Escribir "Números primos encontrados:"
	
	Para numero = 1 Hasta 10 Con Paso 1 Hacer
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
			contadorPrimos = contadorPrimos + 1
		FinSi
	FinPara
	
	Escribir "-------------------------------------"
	Escribir "Cantidad de primos: ", contadorPrimos
FinAlgoritmo
