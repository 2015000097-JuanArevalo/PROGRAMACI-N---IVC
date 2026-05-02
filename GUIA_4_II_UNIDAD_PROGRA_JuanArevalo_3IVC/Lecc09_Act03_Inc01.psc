Algoritmo Lecc09_Act03_Inc01
	Definir numero, actual Como Entero
	actual = 21
	
	Escribir "====================================="
	Escribir "       IMPARES DESDE 20 HASTA N"
	Escribir "====================================="
	Escribir "Ingrese un número mayor que 20: "
	Leer numero
	
	Escribir "-------------------------------------"
	Escribir "Números impares encontrados:"
	
	Mientras actual <= numero Hacer
		Escribir actual
		actual = actual + 2
	FinMientras
	
	Escribir "-------------------------------------"
	Escribir "Proceso finalizado."
FinAlgoritmo
