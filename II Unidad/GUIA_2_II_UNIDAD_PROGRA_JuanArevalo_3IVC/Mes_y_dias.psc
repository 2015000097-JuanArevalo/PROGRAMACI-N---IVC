Proceso Mes_y_dias
	Definir opc Como Entero
	
	Escribir "==== Mes y Días ===="
	Escribir "********************"
	Escribir "* MENÚ DE OPCIONES *"
	Escribir "********************"
	Escribir "Enero - 1"
	Escribir "Febrero - 2"
	Escribir "Marzo - 3"
	Escribir "Abril - 4"
	Escribir "Mayo - 5"
	Escribir "Junio - 6"
	Escribir "Julio - 7"
	Escribir "Agosto - 8"
	Escribir "Septiembre - 9"
	Escribir "Octubre - 10"
	Escribir "Noviembre - 11"
	Escribir "Diciembre - 12"
	
	Escribir Sin Saltar "Digite la opción: "
	Leer opc
	
	Segun opc Hacer
		1:
			Escribir "Enero: 31 días"
		2:
			Escribir "Febrero: 28/29 días"
		3:
			Escribir "Marzo: 31 días"
		4:
			Escribir "Abril: 30 días"
		5:
			Escribir "Mayo: 31 días"
		6:
			Escribir "Junio: 30 días"
		7:
			Escribir "Julio: 31 días"
		8:
			Escribir "Agosto: 31 días"
		9:
			Escribir "Septiembre: 30 días"
		10:
			Escribir "Octubre: 31 días"
		11:
			Escribir "Noviembre: 30 días"
		12:
			Escribir "Diciembre: 31 días"
		De Otro Modo:
			Escribir "OPCIÓN INVÁLIDA INGRESADA"
	FinSegun
FinProceso
