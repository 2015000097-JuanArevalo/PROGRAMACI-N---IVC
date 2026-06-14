Proceso Act2_Lecc7_Inc2
    Definir nota Como Entero

    Escribir Sin Saltar "Ingrese la nota: "
    Leer nota

    Si nota < 70 Entonces
        Escribir "Deficiente"
    Sino
        Si nota < 80 Entonces
            Escribir "Regular"
        Sino
            Si nota < 85 Entonces
                Escribir "Bien"
            Sino
                Si nota < 95 Entonces
                    Escribir "Muy bien"
                Sino
					Si nota <= 100 Entonces
						Escribir "Excelente"
					SiNo
						Escribir "Nota inválida"
					FinSi
                FinSi
            FinSi
        FinSi
    FinSi
FinProceso
