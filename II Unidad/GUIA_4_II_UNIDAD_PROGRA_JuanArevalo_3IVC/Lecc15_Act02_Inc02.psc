Algoritmo Lecc15_Act02_Inc02
	Definir contador, denominacion, cantidad100, totalDinero Como Entero
	contador = 1
	cantidad100 = 0
	totalDinero = 0
	
	Escribir "====================================="
	Escribir "        FAJO DE MIL BILLETES"
	Escribir "====================================="
	Escribir "El cajero revisará 1000 billetes."
	Escribir "Las denominaciones válidas son Q20, Q50 y Q100."
	Escribir "Se contará cuántos billetes son de Q100"
	Escribir "y cuánto dinero hay en total."
	Esperar Tecla
	
	Repetir
		Limpiar Pantalla
		Escribir "====================================="
		Escribir "        FAJO DE MIL BILLETES"
		Escribir "====================================="
		Escribir "Billete revisado: ", contador, " de 1000"
		Escribir "Billetes de Q100 encontrados: ", cantidad100
		Escribir "Total acumulado: Q", totalDinero
		Escribir "-------------------------------------"
		Escribir "Ingrese denominación del billete (20, 50 o 100): "
		Leer denominacion
		
		Si denominacion = 20 O denominacion = 50 O denominacion = 100 Entonces
			totalDinero = totalDinero + denominacion
			
			Si denominacion = 100 Entonces
				cantidad100 = cantidad100 + 1
			FinSi
			
			Escribir "Billete registrado correctamente."
			contador = contador + 1
		SiNo
			Escribir "Denominación no válida. Debe ser 20, 50 o 100."
			Escribir "Este billete no se contará, intente otra vez."
		FinSi
		
		Esperar Tecla
	Hasta Que contador > 1000
	
	Limpiar Pantalla
	Escribir "====================================="
	Escribir "          RESUMEN FINAL"
	Escribir "====================================="
	Escribir "Billetes revisados: 1000"
	Escribir "Billetes de Q100: ", cantidad100
	Escribir "Total de dinero en el fajo: Q", totalDinero
FinAlgoritmo
