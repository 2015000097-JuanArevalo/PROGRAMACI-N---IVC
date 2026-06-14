Proceso Menu_de_comida
	Definir opc Como Entero
	
	Escribir "==== Menú de Restaurante ===="
	Escribir "********************"
	Escribir "* MENÚ DE OPCIONES *"
	Escribir "********************"
	Escribir "Hamburguesa - 1"
	Escribir "Pizza - 2"
	Escribir "Pollo frito - 3"
	Escribir "Ensalada - 4"
	
	Escribir Sin Saltar "Digite la opción: "
	Leer opc
	
	Segun opc Hacer
		1:
			Escribir "Hamburguesa"
		2:
			Escribir "Pizza"
		3:
			Escribir "Pollo frito"
		4:
			Escribir "Ensalada"
		De Otro Modo:
			Escribir "OPCIÓN INVÁLIDA INGRESADA"
	FinSegun
FinProceso
