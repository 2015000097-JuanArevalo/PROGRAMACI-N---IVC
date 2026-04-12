Proceso Venta_de_impresores
	Definir cantidad, opcionPago Como Entero
	Definir precioSinIva, precioConIva, totalSinDescuento, descuento, totalPagar Como Real
	Definir formaPago Como Cadena
	
	Escribir "==== Venta de impresores T&S, S.A de C.A ===="
	
	precioSinIva <- 650
	precioConIva <- precioSinIva * 1.12
	descuento <- 0
	totalPagar <- 0
	formaPago <- ""
	
	Escribir Sin Saltar "Ingrese la cantidad de impresoras a comprar: "
	Leer cantidad
	
	Si cantidad <= 0 Entonces
		Escribir "La cantidad debe ser mayor que 0."
	SiNo
		Escribir "********************"
		Escribir "* MENÚ DE OPCIONES *"
		Escribir "********************"
		Escribir "Formas de pago:"
		Escribir "1- Efectivo"
		Escribir "2- Tarjeta de crédito"
		Escribir "3- Vale de regalo"
		Escribir "********************"
		
		Escribir Sin Saltar "Digite la opción: "
		Leer opcionPago
		
		totalSinDescuento <- cantidad * precioConIva
		
		Segun opcionPago Hacer
			1:
				formaPago <- "Efectivo"
				descuento <- totalSinDescuento * 0.10
				totalPagar <- totalSinDescuento - descuento
				Escribir "Cantidad de impresoras: ", cantidad
				Escribir "Precio unitario con IVA: Q. ", precioConIva
				Escribir "Total sin descuento: Q. ", totalSinDescuento
				Escribir "Forma de pago: ", formaPago
				Escribir "Descuento realizado: Q. ", descuento
				Escribir "Total a pagar: Q. ", totalPagar
			2:
				formaPago <- "Tarjeta de crédito"
				descuento <- totalSinDescuento * 0.05
				totalPagar <- totalSinDescuento - descuento
				Escribir "Cantidad de impresoras: ", cantidad
				Escribir "Precio unitario con IVA: Q. ", precioConIva
				Escribir "Total sin descuento: Q. ", totalSinDescuento
				Escribir "Forma de pago: ", formaPago
				Escribir "Descuento realizado: Q. ", descuento
				Escribir "Total a pagar: Q. ", totalPagar
			3:
				formaPago <- "Vale de regalo"
				descuento <- totalSinDescuento * 0.15
				totalPagar <- totalSinDescuento - descuento
				Escribir "Cantidad de impresoras: ", cantidad
				Escribir "Precio unitario con IVA: Q. ", precioConIva
				Escribir "Total sin descuento: Q. ", totalSinDescuento
				Escribir "Forma de pago: ", formaPago
				Escribir "Descuento realizado: Q. ", descuento
				Escribir "Total a pagar: Q. ", totalPagar
			De Otro Modo:
				Escribir "Opción no válida."
		FinSegun
	FinSi
FinProceso
