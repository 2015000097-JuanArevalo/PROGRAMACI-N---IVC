Algoritmo ContadorManzanas
    Definir totman, totnet, cont, suma Como Entero
    
    totman <- 0
    totnet <- 1000
    cont <- 0
    suma <- 0
    
    Escribir "-----CONTADOR DE MANZANAS-----"
    
    Mientras totman < totnet Hacer
        Escribir ""
        Escribir "Llevas acumulado: ", totman, "g"
        Escribir "Ingresa cuántos gramos pesa tu manzana:"
        Leer suma
        
        Si suma >= 180 Entonces
            
            Si totman + suma <= totnet Entonces
                totman <- totman + suma
                cont <- cont + 1
                Escribir "Correcto. Te faltan: ", totnet - totman, "g"
                Escribir "Llevas: ", cont, " manzanas"
            Sino
                Escribir "¡Error! Esta manzana de ", suma, "g hace que superes el kilo. No se contará."
                Escribir "Intenta con una más pequeña. Te quedan ", totnet - totman, "g de espacio."
            FinSi
            
        Sino
            Escribir "¡Eso pesa muy poco para ser una manzana! Intenta de nuevo."
        FinSi
    FinMientras
    
    Escribir ""
    Escribir "-------------------------------------------"
    Escribir "¡Ya has llegado al 1 kilo!"
    Escribir "Llevas en total: ", totman, "g, que son ", cont, " manzanas."
FinAlgoritmo
