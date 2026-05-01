Algoritmo Lecc15_Act01_Inc01
	Definir respuesta Como Cadena
	Definir boletosVendidos, dinero, disponibles Como Entero
	boletosVendidos = 0
	dinero = 0
	disponibles = 15
	
	Escribir "====================================="
	Escribir "       BOLETOS PARA LA RUEDA"
	Escribir "====================================="
	Escribir "Cada boleto cuesta Q10."
	Escribir "Hay 15 espacios disponibles."
	Esperar Tecla
	
	Mientras disponibles > 0 Hacer
		Limpiar Pantalla
		Escribir "====================================="
		Escribir "       BOLETOS PARA LA RUEDA"
		Escribir "====================================="
		Escribir "Boletos vendidos: ", boletosVendidos
		Escribir "Espacios disponibles: ", disponibles
		Escribir "Dinero acumulado: Q", dinero
		Escribir "¿Desea vender un boleto? (si/no): "
		Leer respuesta
		
		Si respuesta = "si" Entonces
			boletosVendidos = boletosVendidos + 1
			dinero = dinero + 10
			disponibles = disponibles - 1
			Escribir "Boleto vendido correctamente."
		SiNo
			disponibles = 0
		FinSi
		Esperar Tecla
	FinMientras
	
	Escribir "====================================="
	Escribir "          RESUMEN DE VENTA"
	Escribir "====================================="
	Escribir "Boletos vendidos: ", boletosVendidos
	Escribir "Total cobrado: Q", dinero
FinAlgoritmo
