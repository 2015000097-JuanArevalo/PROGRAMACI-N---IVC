Algoritmo Lecc11_Act02_Inc03
	Definir numero1, numero2, menor, mayor, actual Como Entero
	
	Escribir "====================================="
	Escribir "    MÚLTIPLOS DE 4 ENTRE DOS NÚMEROS"
	Escribir "====================================="
	Escribir "Ingrese el primer número: "
	Leer numero1
	Escribir "Ingrese el segundo número: "
	Leer numero2
	
	Si numero1 < numero2 Entonces
		menor = numero1
		mayor = numero2
	SiNo
		menor = numero2
		mayor = numero1
	FinSi
	
	actual = menor
	Escribir "-------------------------------------"
	Escribir "Múltiplos de 4 encontrados:"
	
	Repetir
		Si actual MOD 4 = 0 Entonces
			Escribir actual
		FinSi
		actual = actual + 1
	Hasta Que actual > mayor
	
	Escribir "-------------------------------------"
	Escribir "Proceso finalizado."
FinAlgoritmo
