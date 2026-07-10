Algoritmo InventarioTienda
	Escribir "Nombre: Juan Arévalo"
	Escribir "Grado y Sección: IVC"
	Escribir "Clave: 3"
	Escribir "Ejemplo de una matriz"
	Escribir ""
	
    Dimension productos[10,3]
    Definir opcion Como Entero

    Repetir
        Limpiar Pantalla
        Escribir "===== MENU ====="
        Escribir "1. Registrar producto"
        Escribir "2. Mostrar productos"
        Escribir "3. Actualizar producto"
        Escribir "4. Eliminar producto"
        Escribir "5. Salir"
        Leer opcion

        Segun opcion Hacer
            1:
                Limpiar Pantalla
                Escribir "=== REGISTRAR PRODUCTO ==="
                Registrar(productos)
                Escribir "Presione cualquier tecla para continuar..."
                Esperar Tecla

            2:
                Limpiar Pantalla
                Escribir "=== MOSTRAR PRODUCTOS ==="
                Mostrar(productos)
                Escribir "Presione cualquier tecla para continuar..."
                Esperar Tecla

            3:
                Limpiar Pantalla
                Escribir "=== ACTUALIZAR PRODUCTO ==="
                Actualizar(productos)
                Escribir "Presione cualquier tecla para continuar..."
                Esperar Tecla

            4:
                Limpiar Pantalla
                Escribir "=== ELIMINAR PRODUCTO ==="
                Eliminar(productos)
                Escribir "Presione cualquier tecla para continuar..."
                Esperar Tecla
        FinSegun
    Hasta Que opcion = 5
FinAlgoritmo

// Subproceso para registrar un producto
SubProceso Registrar(productos)
    Definir i Como Entero
    Definir registrado Como Logico
    registrado <- Falso

    Para i <- 1 Hasta 10 Hacer
        Si productos[i,1] = "" Entonces
            Escribir "Codigo del producto:"
            Leer productos[i,1]
            Escribir "Nombre del producto:"
            Leer productos[i,2]
            Escribir "Cantidad en existencia:"
            Leer productos[i,3]
            Escribir "Producto registrado."
            registrado <- Verdadero
            i <- 10
        FinSi
    FinPara

    Si registrado = Falso Entonces
        Escribir "La matriz esta llena."
    FinSi
FinSubProceso

// Subproceso para mostrar productos
SubProceso Mostrar(productos)
    Definir i Como Entero

    Escribir "CODIGO    NOMBRE    CANTIDAD"
    Para i <- 1 Hasta 10 Hacer
        Si productos[i,1] <> "" Entonces
            Escribir productos[i,1], "    ", productos[i,2], "    ", productos[i,3]
        FinSi
    FinPara
FinSubProceso

// Subproceso para actualizar un producto
SubProceso Actualizar(productos)
    Definir i Como Entero
    Definir codigo Como Cadena
    Definir encontrado Como Logico
    encontrado <- Falso

    Escribir "Codigo del producto a buscar:"
    Leer codigo

    Para i <- 1 Hasta 10 Hacer
        Si productos[i,1] = codigo Entonces
            Escribir "Nuevo nombre del producto:"
            Leer productos[i,2]
            Escribir "Nueva cantidad en existencia:"
            Leer productos[i,3]
            Escribir "Producto actualizado."
            encontrado <- Verdadero
        FinSi
    FinPara

    Si encontrado = Falso Entonces
        Escribir "Codigo no encontrado."
    FinSi
FinSubProceso

// Subproceso para eliminar un producto
SubProceso Eliminar(productos)
    Definir i Como Entero
    Definir codigo Como Cadena
    Definir encontrado Como Logico
    encontrado <- Falso

    Escribir "Codigo del producto a eliminar:"
    Leer codigo

    Para i <- 1 Hasta 10 Hacer
        Si productos[i,1] = codigo Entonces
            productos[i,1] <- ""
            productos[i,2] <- ""
            productos[i,3] <- ""
            Escribir "Producto eliminado."
            encontrado <- Verdadero
        FinSi
    FinPara

    Si encontrado = Falso Entonces
        Escribir "Codigo no encontrado."
    FinSi
FinSubProceso
