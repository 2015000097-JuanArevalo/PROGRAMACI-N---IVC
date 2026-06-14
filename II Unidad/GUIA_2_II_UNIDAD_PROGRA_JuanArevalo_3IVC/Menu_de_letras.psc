Proceso Menu_de_letras
	Definir opc Como Caracter
	
	Escribir "==== Menu Opciones ===="
	Escribir "A"
	Escribir "B"
	Escribir "C"
	Escribir "D"
	Escribir "F"
	Escribir Sin Saltar "Ingresa una opción: "
	Leer opc
	
	Segun opc Hacer
		'A':
			Escribir "Excelente"
		'B':
			Escribir "Bueno"
		'C':
			Escribir "Regular"
		'D':
			Escribir "Deficiente"
		'F':
			Escribir "Reprobado"
		De Otro Modo:
			Escribir "Ingrese una opción válida."
	FinSegun
FinProceso
