//Crear una app que simule un sistema de un cajero automático
//1- Tres intentos, al tercer intento bloquear la tarjeta
//2- Consultat saldo
//3- Retirar dinero
//4- Depósito de dinero
//5- Salir
Algoritmo cajero_automatico
	Definir saldo, deposito, retiro Como Real
	Definir opc, intentos, pin, pinCorrecto como Entero 
	
	saldo = 10000
	pinCorrecto = 1234
	intentos = 0
	
	//Validar el acceso por medio del pin
	Mientras intentos < 3 Hacer
		Escribir Sin Saltar "Ingrese su PIN: "
		Leer pin
		
		Si pin == pinCorrecto Entonces
			Limpiar Pantalla
			Escribir "¡Acceso concedido!"
			
			Repetir
				Limpiar Pantalla
				Escribir "========================"
				Escribir "     MENÚ PRINCIPAL"
				Escribir "1- Consultar saldo"
				Escribir "2- Depositar dinero"
				Escribir "3- Retirar dinero"
				Escribir "4- Salir"
				Escribir "========================"
				
				Escribir Sin Saltar "Seleccione una opción []"
				Leer opc
				
				Segun opc Hacer
					1:
						Limpiar Pantalla
						Escribir "Su saldo es de: Q.", saldo
						Escribir "Presione una tecla para volver al menú."
						Esperar Tecla
					2:
						Limpiar Pantalla
						Escribir "Su saldo es de: Q.", saldo
						Escribir Sin Saltar "Escriba cuánto dinero quiere depositar: "
						Leer deposito
						Si deposito >= 0
							saldo = saldo + deposito
							Escribir "¡Depósito exitoso!"
							Escribir "Su saldo es de: Q.", saldo
						SiNo
							Escribir "¡Esta opción no es para retirar dinero!"
						FinSi
						Escribir "Presione una tecla para volver al menú."
						Esperar Tecla
					3:
						Limpiar Pantalla
						Escribir "Su saldo es de: Q.", saldo
						Escribir Sin Saltar "Escriba cuanto dinero quiere retirar: "
						Leer retiro
						Si retiro <= saldo Entonces
							saldo = saldo - retiro
							Escribir "¡Retiro exitoso!"
							Escribir "Su saldo actual es de: Q.", saldo
						SiNo
							Escribir "No puede retirar esa cantidad, saldo insuficiente."
							Escribir "Su saldo es de: Q.", saldo
						FinSi
						Escribir "Presione una tecla para volver al menú."
						Esperar Tecla
					4:
						Limpiar Pantalla
						Escribir "¡Gracias por usar el cajero!"
						intentos = 4
					De Otro Modo:
						Escribir "¡Opción inválida, intente de nuevo!"
				Fin Segun
			Hasta Que opc == 4
		SiNo
			intentos = intentos + 1
			Escribir "PIN incorrecto, intento ", intentos, " de 3"
		FinSi
	Fin Mientras
	
	//Bloqueo de la tarjeta
	Si intentos == 3 Entonces
		Escribir "Tarjeta bloaqueada."
		Escribir "Demasiados intentos fallidos."
	FinSi
	Escribir "Presionar una tecla para salir del del sistema."
	Esperar Tecla 
FinAlgoritmo
