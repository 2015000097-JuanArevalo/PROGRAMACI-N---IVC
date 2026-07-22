Proceso FraseInvertida
    Definir frase, invertida Como Cadena
    Definir i Como Entero

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Frase Invertida==="

    Escribir "Ingrese una frase:"
    Leer frase

    invertida <- ""

    Para i <- Longitud(frase) - 1 Hasta 0 Con Paso -1 Hacer
        invertida <- invertida + SubCadena(frase, i, i)
    FinPara

    Escribir "Frase invertida: ", invertida
FinProceso
