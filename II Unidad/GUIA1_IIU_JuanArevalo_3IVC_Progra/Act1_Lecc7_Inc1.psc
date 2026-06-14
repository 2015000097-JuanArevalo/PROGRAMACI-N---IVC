Proceso Act1_Lecc7_Inc1
    Definir materia Como Cadena
    Definir n1, n2, n3, n4, n5 Como Entero
    Definir promedio Como Real

    Escribir "==PROMEDIO DE CALIFICACIONES=="
    Escribir "Digite una materia:"
    Leer materia
    Escribir "Dame 5 notas:"
    Leer n1
    Leer n2
    Leer n3
    Leer n4
    Leer n5

    promedio = (n1 + n2 + n3 + n4 + n5) / 5

    Si promedio >= 70 Entonces
        Escribir "El promedio es: ", promedio, " y el estudiante aprobó."
    Sino
        Escribir "El promedio es: ", promedio, " y el estudiante reprobó."
    FinSi
FinProceso
