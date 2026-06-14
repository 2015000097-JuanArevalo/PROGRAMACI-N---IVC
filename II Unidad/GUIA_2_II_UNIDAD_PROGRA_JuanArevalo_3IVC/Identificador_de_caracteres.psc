Proceso Identificador_de_caracteres
	Definir c Como Caracter
	
	Escribir "==== Identificador de Caracteres ===="
	Escribir Sin Saltar "Ingrese un carácter: "
	Leer c
	c <- Minusculas(c)
	
	Segun c Hacer
		'a':
			Escribir "Es una vocal."
		'e':
			Escribir "Es una vocal."
		'i':
			Escribir "Es una vocal."
		'o':
			Escribir "Es una vocal."
		'u':
			Escribir "Es una vocal."
		'0':
			Escribir "Es un dígito."
		'1':
			Escribir "Es un dígito."
		'2':
			Escribir "Es un dígito."
		'3':
			Escribir "Es un dígito."
		'4':
			Escribir "Es un dígito."
		'5':
			Escribir "Es un dígito."
		'6':
			Escribir "Es un dígito."
		'7':
			Escribir "Es un dígito."
		'8':
			Escribir "Es un dígito."
		'9':
			Escribir "Es un dígito."
		De Otro Modo:
			Escribir "No es vocal ni dígito."
	FinSegun
FinProceso
