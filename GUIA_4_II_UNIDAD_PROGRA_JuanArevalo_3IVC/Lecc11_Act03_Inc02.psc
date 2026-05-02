Algoritmo Lecc11_Act03_Inc02
	Definir numero, suma Como Entero
	suma = 0
	
	Escribir "====================================="
	Escribir "       SUMA HASTA INGRESAR 9"
	Escribir "====================================="
	Escribir "Ingrese números para sumarlos uno por uno."
	Escribir "Cuando ingrese 9, el programa termina."
	Esperar Tecla
	
	Repetir
		Limpiar Pantalla
		Escribir "====================================="
		Escribir "       SUMA HASTA INGRESAR 9"
		Escribir "====================================="
		Escribir "Suma actual: ", suma
		Escribir "Ingrese un número: "
		Leer numero
		
		Si numero <> 9 Entonces
			suma = suma + numero
			Escribir "Número agregado a la suma."
			Escribir "Nueva suma: ", suma
		SiNo
			Escribir "Se ingresó 9, el ciclo termina."
		FinSi
		
		Esperar Tecla
	Hasta Que numero = 9
	
	Escribir "-------------------------------------"
	Escribir "La suma final es: ", suma
FinAlgoritmo
