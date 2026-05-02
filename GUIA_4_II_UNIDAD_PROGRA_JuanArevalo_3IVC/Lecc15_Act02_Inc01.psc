Algoritmo Lecc15_Act02_Inc01
	Definir numero, divisor, sumaPrimos, cantidadPrimos Como Entero
	Definir esPrimo Como Logico
	sumaPrimos = 0
	cantidadPrimos = 0
	
	Escribir "====================================="
	Escribir "       PRIMOS ENTRE 1 Y 100"
	Escribir "====================================="
	Escribir "Se mostrarán los números primos y al final"
	Escribir "se mostrará la suma de todos ellos."
	Esperar Tecla
	
	Escribir "-------------------------------------"
	Escribir "Números primos encontrados:"
	
	Para numero = 1 Hasta 100 Con Paso 1 Hacer
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
			sumaPrimos = sumaPrimos + numero
			cantidadPrimos = cantidadPrimos + 1
		FinSi
	FinPara
	
	Escribir "-------------------------------------"
	Escribir "Cantidad de primos encontrados: ", cantidadPrimos
	Escribir "Suma de los primos: ", sumaPrimos
FinAlgoritmo
