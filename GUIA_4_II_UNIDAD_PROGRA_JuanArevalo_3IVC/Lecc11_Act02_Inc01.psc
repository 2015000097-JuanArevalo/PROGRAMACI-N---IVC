Algoritmo Lecc11_Act02_Inc01
	Definir limite, numero, producto, suma Como Entero
	numero = 4
	suma = 0
	
	Escribir "====================================="
	Escribir "        SUMATORIA DE PRODUCTOS"
	Escribir "====================================="
	Escribir "Ingrese el último número de la serie: "
	Leer limite
	
	Repetir
		producto = numero * (numero - 1) * (numero - 2) * (numero - 3)
		suma = suma + producto
		Escribir numero, " x ", numero - 1, " x ", numero - 2, " x ", numero - 3, " = ", producto
		numero = numero + 4
	Hasta Que numero > limite
	
	Escribir "-------------------------------------"
	Escribir "La sumatoria es: ", suma
FinAlgoritmo
