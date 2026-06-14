Proceso Calculadora_trigonometrica
	Definir grados, opc Como Entero
	Definir radianes, resultado Como Real
	
	Escribir "* CALCULADORA FUNCIONES TRIGONOMÉTRICAS BÁSICAS *"
	Escribir "*************************************************"
	Escribir "* Lista de funciones trigonométricas            *"
	Escribir "*  1- Seno                                      *"
	Escribir "*  2- Coseno                                    *"
	Escribir "*  3- Tangente                                  *"
	Escribir "*************************************************"
	
	Escribir Sin Saltar "Digite un ángulo en grados: "
	Leer grados
	Escribir Sin Saltar "Digite la opción: "
	Leer opc
	
	radianes <- grados * PI / 180
	
	Segun opc Hacer
		1:
			resultado <- Sen(radianes)
			Escribir "El seno de ", grados, "° es: ", resultado
		2:
			resultado <- Cos(radianes)
			Escribir "El coseno de ", grados, "° es: ", resultado
		3:
			resultado <- Tan(radianes)
			Escribir "La tangente de ", grados, "° es: ", resultado
		De Otro Modo:
			Escribir "Opción no válida."
	FinSegun
FinProceso
