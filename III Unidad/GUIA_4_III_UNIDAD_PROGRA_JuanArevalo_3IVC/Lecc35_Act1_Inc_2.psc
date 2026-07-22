Proceso CalculadoraCambio
    Definir precio, pago, cambio, restante Como Entero
    Definir billetes200, billetes100, billetes50, billetes20, monedas Como Entero

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Calculadora de Cambio==="

    Escribir "Ingrese el precio del producto en quetzales enteros:"
    Leer precio
    Escribir "Ingrese el valor del billete recibido:"
    Leer pago

    Si precio < 0 O pago < 0 Entonces
        Escribir "Los valores no pueden ser negativos."
    Sino
        Si pago < precio Entonces
            Escribir "El pago es insuficiente."
        Sino
            cambio <- pago - precio
            restante <- cambio

            billetes200 <- Trunc(restante / 200)
            restante <- restante MOD 200

            billetes100 <- Trunc(restante / 100)
            restante <- restante MOD 100

            billetes50 <- Trunc(restante / 50)
            restante <- restante MOD 50

            billetes20 <- Trunc(restante / 20)
            restante <- restante MOD 20

            monedas <- restante

            Escribir "Cambio total: Q", cambio
            Escribir "Billetes de Q200: ", billetes200
            Escribir "Billetes de Q100: ", billetes100
            Escribir "Billetes de Q50: ", billetes50
            Escribir "Billetes de Q20: ", billetes20
            Escribir "Monedas de Q1: ", monedas
        FinSi
    FinSi
FinProceso
