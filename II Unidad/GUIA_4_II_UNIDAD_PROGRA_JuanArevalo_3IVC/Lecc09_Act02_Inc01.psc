Algoritmo Lecc09_Act02_Inc01
	Definir monedas, ganadas Como Entero
	monedas = 0
	
	Escribir "====================================="
	Escribir "       DESBLOQUEO DEL NIVEL 5"
	Escribir "====================================="
	Escribir "Necesitas 350 monedas para entrar."
	Esperar Tecla
	
	Mientras monedas < 350 Hacer
		Limpiar Pantalla
		Escribir "====================================="
		Escribir "       DESBLOQUEO DEL NIVEL 5"
		Escribir "====================================="
		Escribir "Monedas actuales: ", monedas
		Escribir "Monedas faltantes: ", 350 - monedas
		Escribir "El nivel sigue bloqueado."
		Escribir "Ingrese las monedas ganadas en esta partida: "
		Leer ganadas
		
		monedas = monedas + ganadas
		
		Escribir "Ahora tienes ", monedas, " monedas."
		Esperar Tecla
	FinMientras
	
	Limpiar Pantalla
	Escribir "====================================="
	Escribir "          NIVEL DESBLOQUEADO"
	Escribir "====================================="
	Escribir "Ya tienes ", monedas, " monedas."
	Escribir "Puedes ingresar al nivel 5."
FinAlgoritmo
