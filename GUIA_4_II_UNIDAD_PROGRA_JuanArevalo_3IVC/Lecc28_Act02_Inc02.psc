Algoritmo Lecc28_Act02_Inc02
	Definir tipo, boletos, total Como Entero
	Definir seguir Como Cadena
	boletos = 0
	total = 0
	
	Escribir "====================================="
	Escribir "       BOLETOS PARA LA RUEDA"
	Escribir "====================================="
	Escribir "Adulto: Q15"
	Escribir "Niño: Q10"
	Escribir "-------------------------------------"
	
	Repetir
		Escribir "Ingrese 1 para adulto o 2 para niño:"
		Leer tipo
		
		Si tipo = 1 Entonces
			total = total + 15
			boletos = boletos + 1
			Escribir "Boleto de adulto vendido."
		SiNo
			Si tipo = 2 Entonces
				total = total + 10
				boletos = boletos + 1
				Escribir "Boleto de niño vendido."
			SiNo
				Escribir "Tipo de boleto no válido."
			FinSi
		FinSi
		
		Escribir "Boletos vendidos: ", boletos
		Escribir "Total acumulado: Q", total
		Escribir "¿Desea vender otro boleto? (si/no): "
		Leer seguir
		Escribir "-------------------------------------"
	Hasta Que seguir = "no"
	
	Escribir "====================================="
	Escribir "          RESUMEN FINAL"
	Escribir "====================================="
	Escribir "Boletos vendidos: ", boletos
	Escribir "Total cobrado: Q", total
FinAlgoritmo
