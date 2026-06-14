Algoritmo Lecc15_Act03_Inc01
	Definir i, multiplo, suma, pares Como Entero
	suma = 0
	pares = 0
	
	Escribir "====================================="
	Escribir "   SUMA DE MÚLTIPLOS DE 7 Y PARES"
	Escribir "====================================="
	
	Para i = 1 Hasta 20 Con Paso 1 Hacer
		multiplo = 7 * i
		suma = suma + multiplo
		
		Si multiplo MOD 2 = 0 Entonces
			pares = pares + 1
		FinSi
		
		Escribir "Múltiplo ", i, ": ", multiplo
	FinPara
	
	Escribir "-------------------------------------"
	Escribir "Sumatoria de los 20 múltiplos de 7: ", suma
	Escribir "Cantidad de esos números que son pares: ", pares
FinAlgoritmo
