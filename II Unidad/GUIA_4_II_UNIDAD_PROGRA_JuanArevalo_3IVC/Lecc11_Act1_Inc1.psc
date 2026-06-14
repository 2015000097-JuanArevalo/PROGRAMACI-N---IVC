Algoritmo Lecc11_Act1_Inc1
	Definir cajonesOcupados, capacidadTotal, opc Como Entero
	capacidadTotal = 10
	cajonesOcupados = 0
	
	Repetir
		Escribir "-----SISTEMA DE ACCESO-----"
		Escribir "Cajones ocupados: ", cajonesOcupados, " / ", capacidadTotal
		Escribir "Cajones disponibles: ", capacidadTotal - cajonesOcupados
		Escribir "Presione [1] para ingresar un auto o [0] para salir del sistema"
		leer opc
		
		Si opc = 1 Entonces
			cajonesOcupados = cajonesOcupados + 1
			Escribir "Ticket impreso. ¡BIENVENIDO!"
		SiNo
			Si opc <> 0 Entonces
				Escribir "Opción no válida"
			FinSi
		FinSi
		Escribir "---------------------------"
	Hasta Que cajonesOcupados >= capacidadTotal o opc = 0
	
	Si cajonesOcupados >= capacidadTotal Entonces
		Escribir "AVISO: estacionamiento lleno"
		Escribir "No se permiten más ingresos"
	FinSi
	
	Escribir "Cerrando el sistema de monitoreo"
FinAlgoritmo
