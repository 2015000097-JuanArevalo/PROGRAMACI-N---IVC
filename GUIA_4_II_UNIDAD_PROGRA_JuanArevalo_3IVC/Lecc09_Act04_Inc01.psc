Algoritmo Lecc09_Act04_Inc01
	Definir numero, contador Como Entero
	contador = 1
	
	Escribir "====================================="
	Escribir "          TABLA DE MULTIPLICAR"
	Escribir "====================================="
	Escribir "Ingrese el número de la tabla: "
	Leer numero
	
	Escribir "-------------------------------------"
	Mientras contador <= 10 Hacer
		Escribir numero, " x ", contador, " = ", numero * contador
		contador = contador + 1
	FinMientras
	
	Escribir "-------------------------------------"
	Escribir "Tabla terminada."
FinAlgoritmo
