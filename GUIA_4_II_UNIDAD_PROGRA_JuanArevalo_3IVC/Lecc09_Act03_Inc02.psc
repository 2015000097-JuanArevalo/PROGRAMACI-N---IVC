Algoritmo Lecc09_Act03_Inc02
	Definir numero, divisor Como Entero
	Definir esPrimo Como Logico
	divisor = 2
	esPrimo = Verdadero
	
	Escribir "====================================="
	Escribir "          NÚMERO PRIMO"
	Escribir "====================================="
	Escribir "Ingrese un número entero: "
	Leer numero
	
	Si numero <= 1 Entonces
		esPrimo = Falso
	SiNo
		Mientras divisor < numero Hacer
			Si numero MOD divisor = 0 Entonces
				esPrimo = Falso
			FinSi
			divisor = divisor + 1
		FinMientras
	FinSi
	
	Escribir "-------------------------------------"
	Si esPrimo = Verdadero Entonces
		Escribir "El número ", numero, " sí es primo."
	SiNo
		Escribir "El número ", numero, " no es primo."
	FinSi
FinAlgoritmo
