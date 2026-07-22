Proceso Ej_Horoscopo
    Definir mes, dia Como Entero
    Definir signo, horoscopo Como Cadena

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Horoscopo==="

    Escribir "Ingrese el mes de nacimiento (1-12):"
    Leer mes
    Escribir "Ingrese el dia de nacimiento:"
    Leer dia

    Si mes < 1 O mes > 12 O dia < 1 O dia > 31 Entonces
        Escribir "Fecha invalida."
    Sino
        Si (mes = 3 Y dia >= 21) O (mes = 4 Y dia <= 19) Entonces
            signo <- "Aries"
        Sino
            Si (mes = 4 Y dia >= 20) O (mes = 5 Y dia <= 20) Entonces
                signo <- "Tauro"
            Sino
                Si (mes = 5 Y dia >= 21) O (mes = 6 Y dia <= 20) Entonces
                    signo <- "Geminis"
                Sino
                    Si (mes = 6 Y dia >= 21) O (mes = 7 Y dia <= 22) Entonces
                        signo <- "Cancer"
                    Sino
                        Si (mes = 7 Y dia >= 23) O (mes = 8 Y dia <= 22) Entonces
                            signo <- "Leo"
                        Sino
                            Si (mes = 8 Y dia >= 23) O (mes = 9 Y dia <= 22) Entonces
                                signo <- "Virgo"
                            Sino
                                Si (mes = 9 Y dia >= 23) O (mes = 10 Y dia <= 22) Entonces
                                    signo <- "Libra"
                                Sino
                                    Si (mes = 10 Y dia >= 23) O (mes = 11 Y dia <= 21) Entonces
                                        signo <- "Escorpio"
                                    Sino
                                        Si (mes = 11 Y dia >= 22) O (mes = 12 Y dia <= 21) Entonces
                                            signo <- "Sagitario"
                                        Sino
                                            Si (mes = 12 Y dia >= 22) O (mes = 1 Y dia <= 19) Entonces
                                                signo <- "Capricornio"
                                            Sino
                                                Si (mes = 1 Y dia >= 20) O (mes = 2 Y dia <= 18) Entonces
                                                    signo <- "Acuario"
                                                Sino
                                                    signo <- "Piscis"
                                                FinSi
                                            FinSi
                                        FinSi
                                    FinSi
                                FinSi
                            FinSi
                        FinSi
                    FinSi
                FinSi
            FinSi
        FinSi

        Segun signo Hacer
            "Aries":
                horoscopo <- "Hoy tendras energia para iniciar algo nuevo."
            "Tauro":
                horoscopo <- "La paciencia te ayudara a tomar una buena decision."
            "Geminis":
                horoscopo <- "Una conversacion importante aclarara tus dudas."
            "Cancer":
                horoscopo <- "Dedica tiempo a tu familia y a descansar."
            "Leo":
                horoscopo <- "Tu confianza te ayudara a superar un reto."
            "Virgo":
                horoscopo <- "Organiza tus pendientes y avanzaras con facilidad."
            "Libra":
                horoscopo <- "Busca equilibrio antes de tomar una decision."
            "Escorpio":
                horoscopo <- "Confia en tu intuicion, pero piensa antes de actuar."
            "Sagitario":
                horoscopo <- "Una nueva idea puede convertirse en una oportunidad."
            "Capricornio":
                horoscopo <- "Tu esfuerzo constante dara buenos resultados."
            "Acuario":
                horoscopo <- "Comparte tus ideas y escucha otras opiniones."
            De Otro Modo:
                horoscopo <- "Hoy sera un buen dia para aprender algo nuevo."
        FinSegun

        Escribir "Su signo zodiacal es: ", signo
        Escribir "Horoscopo: ", horoscopo
    FinSi
FinProceso
