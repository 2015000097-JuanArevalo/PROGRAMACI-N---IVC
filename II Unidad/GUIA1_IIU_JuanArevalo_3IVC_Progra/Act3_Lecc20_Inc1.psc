Proceso Act3_Lecc20_Inc1
    Definir dia Como Entero

    Escribir Sin Saltar "Ingrese un día de la semana: "
    Leer dia

    Si dia = 1 O dia = 2 O dia = 3 O dia = 4 O dia = 5 Entonces
        Escribir "Entre semana"
    Sino
        Si dia = 6 O dia = 7 Entonces
            Escribir "Fin de semana"
        Sino
            Escribir "Acceso denegado"
        FinSi
    FinSi
FinProceso
