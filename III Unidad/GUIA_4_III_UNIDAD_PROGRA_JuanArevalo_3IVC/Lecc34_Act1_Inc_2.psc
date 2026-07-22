Proceso IndiceMasaCorporal
    Definir peso, altura, imc Como Real

    Escribir "Nombre: Juan Arevalo"
    Escribir "Grado: IVC - Clave: 3"
    Escribir "===Indice de Masa Corporal==="

    Escribir "Ingrese el peso en kilogramos:"
    Leer peso
    Escribir "Ingrese la altura en metros:"
    Leer altura

    Si peso <= 0 O altura <= 0 Entonces
        Escribir "El peso y la altura deben ser mayores que cero."
    Sino
        imc <- peso / (altura ^ 2)
        Escribir "Su IMC es: ", imc
    FinSi
FinProceso
