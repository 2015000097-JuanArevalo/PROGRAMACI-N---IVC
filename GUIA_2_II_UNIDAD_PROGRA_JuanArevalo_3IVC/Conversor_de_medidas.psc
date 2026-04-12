Proceso Conversor_de_medidas
	Definir opc1, opc2 Como Caracter
	Definir cantidad, resultado Como Real
	
	Escribir "==== Conversor de medidas de longitud ===="
	Escribir "********************"
	Escribir "* MENÚ DE OPCIONES *"
	Escribir "********************"
	Escribir "a) Metros"
	Escribir "b) Pies"
	Escribir "c) Centímetros"
	Escribir "d) Pulgadas"
	Escribir "********************"
	
	Escribir Sin Saltar "Seleccione la unidad que quiere convertir: "
	Leer opc1
	opc1 <- Minusculas(opc1)
	
	Escribir Sin Saltar "Seleccione la unidad a la que quiere convertir: "
	Leer opc2
	opc2 <- Minusculas(opc2)
	
	Escribir Sin Saltar "Ingrese la cantidad: "
	Leer cantidad
	
	Segun opc1 Hacer
		'a':
			Segun opc2 Hacer
				'a':
					resultado <- cantidad
					Escribir "Resultado: ", resultado, " m"
				'b':
					resultado <- cantidad * 3.28084
					Escribir "Resultado: ", resultado, " pies"
				'c':
					resultado <- cantidad * 100
					Escribir "Resultado: ", resultado, " cm"
				'd':
					resultado <- cantidad * 39.3701
					Escribir "Resultado: ", resultado, " pulg"
				De Otro Modo:
					Escribir "Opción no válida."
			FinSegun
		'b':
			Segun opc2 Hacer
				'a':
					resultado <- cantidad / 3.28084
					Escribir "Resultado: ", resultado, " m"
				'b':
					resultado <- cantidad
					Escribir "Resultado: ", resultado, " pies"
				'c':
					resultado <- cantidad * 30.48
					Escribir "Resultado: ", resultado, " cm"
				'd':
					resultado <- cantidad * 12
					Escribir "Resultado: ", resultado, " pulg"
				De Otro Modo:
					Escribir "Opción no válida."
			FinSegun
		'c':
			Segun opc2 Hacer
				'a':
					resultado <- cantidad / 100
					Escribir "Resultado: ", resultado, " m"
				'b':
					resultado <- cantidad / 30.48
					Escribir "Resultado: ", resultado, " pies"
				'c':
					resultado <- cantidad
					Escribir "Resultado: ", resultado, " cm"
				'd':
					resultado <- cantidad / 2.54
					Escribir "Resultado: ", resultado, " pulg"
				De Otro Modo:
					Escribir "Opción no válida."
			FinSegun
		'd':
			Segun opc2 Hacer
				'a':
					resultado <- cantidad / 39.3701
					Escribir "Resultado: ", resultado, " m"
				'b':
					resultado <- cantidad / 12
					Escribir "Resultado: ", resultado, " pies"
				'c':
					resultado <- cantidad * 2.54
					Escribir "Resultado: ", resultado, " cm"
				'd':
					resultado <- cantidad
					Escribir "Resultado: ", resultado, " pulg"
				De Otro Modo:
					Escribir "Opción no válida."
			FinSegun
		De Otro Modo:
			Escribir "Opción no válida."
	FinSegun
FinProceso
