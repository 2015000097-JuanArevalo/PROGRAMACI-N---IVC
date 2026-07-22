Proceso Conversiones
    Definir opcion Como Entero
    Definir metros, resultado Como Real
    Definir unidad Como Cadena

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Conversiones==="

    Escribir "Ingrese una cantidad en metros:"
    Leer metros

    Escribir "1. Milimetros"
    Escribir "2. Centimetros"
    Escribir "3. Decimetros"
    Escribir "4. Hectometros"
    Escribir "5. Kilometros"
    Escribir "Seleccione una opcion:"
    Leer opcion

    Segun opcion Hacer
        1:
            resultado <- metros * 1000
            unidad <- "milimetros"
        2:
            resultado <- metros * 100
            unidad <- "centimetros"
        3:
            resultado <- metros * 10
            unidad <- "decimetros"
        4:
            resultado <- metros / 100
            unidad <- "hectometros"
        5:
            resultado <- metros / 1000
            unidad <- "kilometros"
        De Otro Modo:
            Escribir "Opcion invalida."
    FinSegun

    Si opcion >= 1 Y opcion <= 5 Entonces
        Escribir metros, " metros equivale a ", resultado, " ", unidad, "."
    FinSi
FinProceso
