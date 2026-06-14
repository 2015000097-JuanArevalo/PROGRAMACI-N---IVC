Proceso Act3_Lecc7_Inc2
    Definir a, b, c Como Entero

    Escribir "Ingrese los 3 lados:"
    Leer a
    Leer b
    Leer c

    Si a = b Y b = c Entonces
        Escribir "Equilatero"
    Sino
        Si a = b O b = c O a = c Entonces
            Escribir "Isosceles"
        Sino
            Escribir "Escaleno"
        FinSi
    FinSi
FinProceso
