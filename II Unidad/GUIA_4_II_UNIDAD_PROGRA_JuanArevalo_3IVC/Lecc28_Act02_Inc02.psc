Algoritmo Lecc28_Act02_Inc02
	Definir tipo, boletos, boletosNino, boletosAdulto, total Como Entero
	Definir seguir Como Cadena
	boletos = 0
	boletosNino = 0
	boletosAdulto = 0
	total = 0
	
	Escribir "====================================="
	Escribir "       BOLETOS PARA LA RUEDA"
	Escribir "====================================="
	Escribir "Niño: Q10"
	Escribir "Adulto: Q15"
	Escribir "En cada venta ingrese 1 si es niño"
	Escribir "o ingrese 2 si es adulto."
	Esperar Tecla
	
	Repetir
		Limpiar Pantalla
		Escribir "====================================="
		Escribir "       BOLETOS PARA LA RUEDA"
		Escribir "====================================="
		Escribir "Boletos vendidos: ", boletos
		Escribir "Boletos de niño: ", boletosNino
		Escribir "Boletos de adulto: ", boletosAdulto
		Escribir "Total acumulado: Q", total
		Escribir "-------------------------------------"
		Escribir "Ingrese 1 para niño."
		Escribir "Ingrese 2 para adulto."
		Escribir "Tipo de boleto: "
		Leer tipo
		
		Si tipo = 1 Entonces
			total = total + 10
			boletos = boletos + 1
			boletosNino = boletosNino + 1
			Escribir "Boleto de niño vendido."
		SiNo
			Si tipo = 2 Entonces
				total = total + 15
				boletos = boletos + 1
				boletosAdulto = boletosAdulto + 1
				Escribir "Boleto de adulto vendido."
			SiNo
				Escribir "Tipo de boleto no válido."
			FinSi
		FinSi
		
		Escribir "-------------------------------------"
		Escribir "Boletos vendidos hasta ahora: ", boletos
		Escribir "Total acumulado hasta ahora: Q", total
		Escribir "¿Desea vender otro boleto? (si/no): "
		Leer seguir
	Hasta Que seguir = "no"
	
	Limpiar Pantalla
	Escribir "====================================="
	Escribir "          RESUMEN FINAL"
	Escribir "====================================="
	Escribir "Boletos de niño vendidos: ", boletosNino
	Escribir "Boletos de adulto vendidos: ", boletosAdulto
	Escribir "Boletos vendidos: ", boletos
	Escribir "Total cobrado: Q", total
FinAlgoritmo
