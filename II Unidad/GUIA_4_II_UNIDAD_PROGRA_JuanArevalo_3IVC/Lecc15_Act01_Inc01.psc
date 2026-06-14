Algoritmo Lecc15_Act01_Inc01
	Definir tipo Como Entero
	Definir boletosVendidos, boletosAdulto, boletosNino, totalCobrado Como Entero
	Definir respuesta Como Cadena
	boletosVendidos = 0
	boletosAdulto = 0
	boletosNino = 0
	totalCobrado = 0
	respuesta = "si"
	
	Escribir "====================================="
	Escribir "       FERIA - RUEDA DE LA FORTUNA"
	Escribir "====================================="
	Escribir "Boleto de adulto: Q15"
	Escribir "Boleto de niño: Q10"
	Escribir "El supervisor necesita llevar control"
	Escribir "de boletos vendidos y dinero cobrado."
	Esperar Tecla
	
	Mientras respuesta = "si" Hacer
		Limpiar Pantalla
		Escribir "====================================="
		Escribir "       FERIA - RUEDA DE LA FORTUNA"
		Escribir "====================================="
		Escribir "Boletos vendidos: ", boletosVendidos
		Escribir "Boletos de adulto: ", boletosAdulto
		Escribir "Boletos de niño: ", boletosNino
		Escribir "Total cobrado: Q", totalCobrado
		Escribir "-------------------------------------"
		Escribir "Ingrese 1 para boleto de adulto."
		Escribir "Ingrese 2 para boleto de niño."
		Escribir "Tipo de boleto: "
		Leer tipo
		
		Si tipo = 1 Entonces
			boletosAdulto = boletosAdulto + 1
			boletosVendidos = boletosVendidos + 1
			totalCobrado = totalCobrado + 15
			Escribir "Boleto de adulto vendido correctamente."
		SiNo
			Si tipo = 2 Entonces
				boletosNino = boletosNino + 1
				boletosVendidos = boletosVendidos + 1
				totalCobrado = totalCobrado + 10
				Escribir "Boleto de niño vendido correctamente."
			SiNo
				Escribir "Opción no válida. No se vendió boleto."
			FinSi
		FinSi
		
		Escribir "-------------------------------------"
		Escribir "Boletos vendidos hasta ahora: ", boletosVendidos
		Escribir "Total cobrado hasta ahora: Q", totalCobrado
		Escribir "¿Desea vender otro boleto? (si/no): "
		Leer respuesta
	FinMientras
	
	Limpiar Pantalla
	Escribir "====================================="
	Escribir "          RESUMEN FINAL"
	Escribir "====================================="
	Escribir "Boletos de adulto vendidos: ", boletosAdulto
	Escribir "Boletos de niño vendidos: ", boletosNino
	Escribir "Total de boletos vendidos: ", boletosVendidos
	Escribir "Total de dinero cobrado: Q", totalCobrado
FinAlgoritmo
