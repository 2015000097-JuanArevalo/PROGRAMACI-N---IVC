Proceso DecimalBinario
    Definir opcion, numeroDecimal, residuo, resultadoDecimal Como Entero
    Definir i, digito Como Entero
    Definir binario, digitoTexto Como Cadena
    Definir valido Como Logico

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Conversion Decimal y Binario==="

    Escribir "1. Decimal a binario"
    Escribir "2. Binario a decimal"
    Escribir "Seleccione una opcion:"
    Leer opcion

    Segun opcion Hacer
        1:
            Escribir "Ingrese un numero decimal entero positivo:"
            Leer numeroDecimal

            Si numeroDecimal < 0 Entonces
                Escribir "El numero debe ser positivo."
            Sino
                Si numeroDecimal = 0 Entonces
                    binario <- "0"
                Sino
                    binario <- ""

                    Mientras numeroDecimal > 0 Hacer
                        residuo <- numeroDecimal MOD 2
                        binario <- ConvertirATexto(residuo) + binario
                        numeroDecimal <- Trunc(numeroDecimal / 2)
                    FinMientras
                FinSi

                Escribir "Resultado binario: ", binario
            FinSi

        2:
            Escribir "Ingrese un numero binario:"
            Leer binario

            resultadoDecimal <- 0
            valido <- Verdadero

            Para i <- 0 Hasta Longitud(binario) - 1 Hacer
                digitoTexto <- SubCadena(binario, i, i)

                Si digitoTexto <> "0" Y digitoTexto <> "1" Entonces
                    valido <- Falso
                Sino
                    digito <- ConvertirANumero(digitoTexto)
                    resultadoDecimal <- resultadoDecimal * 2 + digito
                FinSi
            FinPara

            Si valido Entonces
                Escribir "Resultado decimal: ", resultadoDecimal
            Sino
                Escribir "El numero binario es invalido."
            FinSi

        De Otro Modo:
            Escribir "Opcion invalida."
    FinSegun
FinProceso
