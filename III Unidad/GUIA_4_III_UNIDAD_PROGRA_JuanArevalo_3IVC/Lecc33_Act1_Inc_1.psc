Proceso AgendaTelefonica
    Definir nombres, telefonos Como Cadena
    Definir i, posicion, indice Como Entero
    Dimension nombres[10]
    Dimension telefonos[10]

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Agenda Telefonica==="

    Para i <- 0 Hasta 9 Hacer
        Escribir "Persona ", i + 1
        Escribir "Nombre:"
        Leer nombres[i]
        Escribir "Telefono:"
        Leer telefonos[i]
        Escribir ""
    FinPara

    Escribir "Ingrese una posicion de la lista (1-10):"
    Leer posicion

    Si posicion >= 1 Y posicion <= 10 Entonces
        indice <- posicion - 1
        Escribir "Nombre: ", nombres[indice]
        Escribir "Telefono: ", telefonos[indice]
    Sino
        Escribir "Posicion invalida."
    FinSi
FinProceso
