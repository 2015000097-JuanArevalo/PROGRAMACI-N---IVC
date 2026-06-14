//Juan Ignacio Arévalo Toc IV "C" Clave: 3
Algoritmo Lecc16_Act2_Inc1
	Escribir "Juan Ignacio Arévalo Toc IVC Clave: 3"
	
    Dimension edadesPersonas[7]

    Definir indice, cantidadMayoresEdad Como Entero

    cantidadMayoresEdad <- 0

    Para indice <- 1 Hasta 7 Hacer
        Escribir "Ingrese la edad de la persona ", indice, ": "
        Leer edadesPersonas[indice]

        Si edadesPersonas[indice] >= 18 Entonces
            cantidadMayoresEdad <- cantidadMayoresEdad + 1
        FinSi
    FinPara

    Escribir "Cantidad de personas mayores de edad: ", cantidadMayoresEdad

FinAlgoritmo
