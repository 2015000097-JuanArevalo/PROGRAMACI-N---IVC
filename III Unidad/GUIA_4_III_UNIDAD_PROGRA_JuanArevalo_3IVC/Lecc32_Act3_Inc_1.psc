Proceso Triangulos
    Definir lado1, lado2, lado3 Como Real

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Tipos de Triangulos==="

    Escribir "Ingrese el primer lado:"
    Leer lado1
    Escribir "Ingrese el segundo lado:"
    Leer lado2
    Escribir "Ingrese el tercer lado:"
    Leer lado3

    Si lado1 <= 0 O lado2 <= 0 O lado3 <= 0 Entonces
        Escribir "Las medidas deben ser mayores que cero."
    Sino
        Si lado1 + lado2 <= lado3 O lado1 + lado3 <= lado2 O lado2 + lado3 <= lado1 Entonces
            Escribir "Las medidas no forman un triangulo."
        Sino
            Si lado1 = lado2 Y lado2 = lado3 Entonces
                Escribir "El triangulo es equilatero."
            Sino
                Si lado1 = lado2 O lado1 = lado3 O lado2 = lado3 Entonces
                    Escribir "El triangulo es isosceles."
                Sino
                    Escribir "El triangulo es escaleno."
                FinSi
            FinSi
        FinSi
    FinSi
FinProceso
