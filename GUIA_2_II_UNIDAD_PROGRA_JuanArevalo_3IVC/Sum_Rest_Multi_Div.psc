Proceso Sum_Rest_Multi_Div
	Definir num1, num2, resultado Como Real
	Definir opcion Como Entero
	
	Escribir "==== CALCULADORA BÁSICA ===="
	Escribir Sin Saltar "Ingrese el primer número: "
	Leer num1
	Escribir Sin Saltar "Ingrese el segundo número: "
	Leer num2
	
	Escribir "1 - Sumar"
	Escribir "2 - Restar"
	Escribir "3 - Multiplicar"
	Escribir "4 - Dividir"
	Escribir Sin Saltar "Seleccione una opción: "
	Leer opcion
	
	Segun opcion Hacer
		1:
			resultado <- num1 + num2
			Escribir "La suma es: ", resultado
		2:
			resultado <- num1 - num2
			Escribir "La resta es: ", resultado
		3:
			resultado <- num1 * num2
			Escribir "La multiplicación es: ", resultado
		4:
			Si num2 <> 0 Entonces
				resultado <- num1 / num2
				Escribir "La división es: ", resultado
			SiNo
				Escribir "No se puede dividir entre 0."
			FinSi
		De Otro Modo:
			Escribir "ERROR AL OPERAR LOS NÚMEROS"
	FinSegun
FinProceso
