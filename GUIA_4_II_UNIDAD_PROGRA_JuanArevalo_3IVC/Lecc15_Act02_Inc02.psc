Algoritmo Lecc15_Act02_Inc02
	Definir precio, subtotal, iva, total Como Real
	Definir productos Como Entero
	subtotal = 0
	productos = 0
	
	Escribir "====================================="
	Escribir "        CAJERO DE SUPERMERCADO"
	Escribir "====================================="
	Escribir "Ingrese los precios de los productos."
	Escribir "Escriba 0 cuando ya no haya más productos."
	
	Repetir
		Escribir "Ingrese precio del producto: Q"
		Leer precio
		
		Si precio > 0 Entonces
			subtotal = subtotal + precio
			productos = productos + 1
			Escribir "Producto agregado. Subtotal actual: Q", subtotal
		FinSi
	Hasta Que precio = 0
	
	iva = subtotal * 0.12
	total = subtotal + iva
	
	Escribir "====================================="
	Escribir "           TOTAL DE COMPRA"
	Escribir "====================================="
	Escribir "Productos ingresados: ", productos
	Escribir "Venta sin impuesto: Q", subtotal
	Escribir "IVA 12%: Q", iva
	Escribir "Total a pagar: Q", total
FinAlgoritmo
