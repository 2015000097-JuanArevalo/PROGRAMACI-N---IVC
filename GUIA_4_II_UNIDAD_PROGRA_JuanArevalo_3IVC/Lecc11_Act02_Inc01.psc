Algoritmo Lecc11_Act02_Inc01
	Definir numero, contador, factorial Como Entero
	factorial = 1
	
	Escribir "====================================="
	Escribir "       FACTORIAL DE UN NÚMERO"
	Escribir "====================================="
	Escribir "El factorial se calcula multiplicando"
	Escribir "desde el número ingresado hasta llegar a 1."
	Escribir "Ingrese un número entero positivo: "
	Leer numero
	
	contador = numero
	
	Si numero < 0 Entonces
		Escribir "-------------------------------------"
		Escribir "No se puede calcular factorial de un número negativo."
	SiNo
		Si numero = 0 Entonces
			factorial = 1
			Escribir "-------------------------------------"
			Escribir "0! = 1"
		SiNo
			Escribir "-------------------------------------"
			Escribir "Proceso del factorial:"
			Repetir
				factorial = factorial * contador
				Escribir "Se multiplica por ", contador, ", resultado actual: ", factorial
				contador = contador - 1
			Hasta Que contador < 1
		FinSi
		
		Escribir "-------------------------------------"
		Escribir "El factorial de ", numero, " es: ", factorial
	FinSi
FinAlgoritmo
