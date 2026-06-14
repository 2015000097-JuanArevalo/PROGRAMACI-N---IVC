Proceso Entradas_estadio
	Definir opc1, cantidad Como Entero
	Definir precio Como Real
	
	Escribir "==== Entradas Estadio Doroteo Guamuch Flores ===="
	Escribir "********************"
	Escribir "* MENÚ DE OPCIONES *"
	Escribir "********************"
	Escribir "1- Palco: Q300.00"
	Escribir "2- Tribuna: Q100.00 - Q125.00"
	Escribir "3- Preferencia: Q50.00 - Q75.00"
	Escribir "4- Generales: Q30.00 - Q50.00"
	Escribir "********************"
	
	Escribir Sin Saltar "Ingrese una opción: "
	Leer opc1
	Escribir Sin Saltar "Ingrese la cantidad de entradas: "
	Leer cantidad
	
	Segun opc1 Hacer
		1:
			precio <- 300
			Escribir "Sector elegido: Palco"
			Escribir "Cantidad de entradas: ", cantidad
			Escribir "Precio: Q. ", precio
			Escribir "Total a pagar: Q. ", cantidad * precio
		2:
			Escribir Sin Saltar "Ingrese el precio de la entrada en Tribuna (Q. 100.00 a Q. 125.00): "
			Leer precio
			Si precio >= 100 Y precio <= 125 Entonces
				Escribir "Sector elegido: Tribuna"
				Escribir "Cantidad de entradas: ", cantidad
				Escribir "Precio: Q. ", precio
				Escribir "Total a pagar: Q. ", cantidad * precio
			SiNo
				Escribir "Precio no válido para Tribuna."
			FinSi
		3:
			Escribir Sin Saltar "Ingrese el precio de la entrada en Preferencia (Q. 50.00 a Q. 75.00): "
			Leer precio
			Si precio >= 50 Y precio <= 75 Entonces
				Escribir "Sector elegido: Preferencia"
				Escribir "Cantidad de entradas: ", cantidad
				Escribir "Precio: Q. ", precio
				Escribir "Total a pagar: Q. ", cantidad * precio
			SiNo
				Escribir "Precio no válido para Preferencia."
			FinSi
		4:
			Escribir Sin Saltar "Ingrese el precio de la entrada en Generales (Q. 30.00 a Q. 50.00): "
			Leer precio
			Si precio >= 30 Y precio <= 50 Entonces
				Escribir "Sector elegido: Generales"
				Escribir "Cantidad de entradas: ", cantidad
				Escribir "Precio: Q. ", precio
				Escribir "Total a pagar: Q. ", cantidad * precio
			SiNo
				Escribir "Precio no válido para Generales."
			FinSi
		De Otro Modo:
			Escribir "Opción no válida."
	FinSegun
FinProceso
