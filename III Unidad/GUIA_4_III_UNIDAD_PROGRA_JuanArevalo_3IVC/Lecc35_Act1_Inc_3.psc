Proceso PiedraPapelTijeras
    Definir usuario, computadora Como Entero
    Definir nombreUsuario, nombreComputadora, respuesta Como Cadena

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Piedra, Papel o Tijeras==="

    Repetir
        Escribir "1. Piedra"
        Escribir "2. Papel"
        Escribir "3. Tijeras"
        Escribir "Seleccione una opcion:"
        Leer usuario

        Si usuario < 1 O usuario > 3 Entonces
            Escribir "Opcion invalida."
        Sino
            computadora <- Aleatorio(1, 3)

            Segun usuario Hacer
                1:
                    nombreUsuario <- "Piedra"
                2:
                    nombreUsuario <- "Papel"
                3:
                    nombreUsuario <- "Tijeras"
            FinSegun

            Segun computadora Hacer
                1:
                    nombreComputadora <- "Piedra"
                2:
                    nombreComputadora <- "Papel"
                3:
                    nombreComputadora <- "Tijeras"
            FinSegun

            Escribir "Usted eligio: ", nombreUsuario
            Escribir "La computadora eligio: ", nombreComputadora

            Si usuario = computadora Entonces
                Escribir "Resultado: Empate."
            Sino
                Si (usuario = 1 Y computadora = 3) O (usuario = 2 Y computadora = 1) O (usuario = 3 Y computadora = 2) Entonces
                    Escribir "Resultado: Usted gana."
                Sino
                    Escribir "Resultado: La computadora gana."
                FinSi
            FinSi
        FinSi

        Escribir "Desea jugar de nuevo? (S/N):"
        Leer respuesta
        respuesta <- Mayusculas(respuesta)
    Hasta Que respuesta = "N"
FinProceso
