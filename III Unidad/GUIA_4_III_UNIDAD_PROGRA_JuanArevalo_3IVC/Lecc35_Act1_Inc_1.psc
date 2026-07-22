Proceso ConvertidorMoneda
    Definir quetzales Como Real
    Definir respuesta Como Cadena

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Convertidor de Moneda==="

    Repetir
        Escribir "Ingrese una cantidad en quetzales:"
        Leer quetzales

        Escribir "Tasas de practica:"
        Escribir "Estados Unidos - Dolares: ", quetzales * 0.13
        Escribir "Union Europea - Euros: ", quetzales * 0.12
        Escribir "Mexico - Pesos: ", quetzales * 2.30
        Escribir "Honduras - Lempiras: ", quetzales * 3.22
        Escribir "Costa Rica - Colones: ", quetzales * 65.00

        Escribir "Desea convertir otra cantidad? (S/N):"
        Leer respuesta
        respuesta <- Mayusculas(respuesta)
    Hasta Que respuesta = "N"
FinProceso
