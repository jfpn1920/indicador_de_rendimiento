Imports System
Module indicador_de_rendimiento
    Sub Main(args As String())
        Dim ids(19) As Integer
        Dim nombres(19) As String
        Dim actividades(19) As String
        Dim metas(19) As Double
        Dim resultados(19) As Double
        Dim rendimientos(19) As Double
        Dim niveles(19) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '---------------------------------------------'
        '--|menu_principal_indicador_de_rendimiento|--'
        '---------------------------------------------'
        Do
            Console.WriteLine("menu principal indicador de rendimiento")
            Console.WriteLine("1) Registrar indicador")
            Console.WriteLine("2) Editar indicador")
            Console.WriteLine("3) Listar indicadores")
            Console.WriteLine("4) Buscar indicador")
            Console.WriteLine("5) Eliminar indicador")
            Console.WriteLine("6) Evaluar rendimiento")
            Console.WriteLine("7) Mostrar resumen")
            Console.WriteLine("8) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-------------------------'
                '--|registrar_indicador|--'
                '-------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas indicadores.")
                    Else
                        Console.Write("Ingrese el nombre: ")
                        Dim nuevoNombre As String = Console.ReadLine()
                        If nuevoNombre = "" Then
                            Console.WriteLine("El nombre no puede estar vacio.")
                        Else
                            Console.Write("Ingrese la actividad: ")
                            Dim nuevaActividad As String = Console.ReadLine()
                            If nuevaActividad = "" Then
                                Console.WriteLine("La actividad no puede estar vacia.")
                            Else
                                Console.Write("Ingrese la meta: ")
                                Dim nuevaMeta As Double = Convert.ToDouble(Console.ReadLine())
                                If nuevaMeta <= 0 Then
                                    Console.WriteLine("La meta debe ser mayor que cero.")
                                Else
                                    Console.Write("Ingrese el resultado: ")
                                    Dim nuevoResultado As Double = Convert.ToDouble(Console.ReadLine())
                                    If nuevoResultado < 0 Then
                                        Console.WriteLine("El resultado no puede ser negativo.")
                                    Else
                                        Dim nuevoRendimiento As Double = (nuevoResultado / nuevaMeta) * 100
                                        Dim nuevoNivel As String = ""
                                        If nuevoRendimiento < 60 Then
                                            nuevoNivel = "Bajo"
                                        ElseIf nuevoRendimiento < 80 Then
                                            nuevoNivel = "Medio"
                                        ElseIf nuevoRendimiento < 100 Then
                                            nuevoNivel = "Alto"
                                        Else
                                            nuevoNivel = "Excelente"
                                        End If
                                        ids(cantidad) = cantidad + 1
                                        nombres(cantidad) = nuevoNombre
                                        actividades(cantidad) = nuevaActividad
                                        metas(cantidad) = nuevaMeta
                                        resultados(cantidad) = nuevoResultado
                                        rendimientos(cantidad) = nuevoRendimiento
                                        niveles(cantidad) = nuevoNivel
                                        cantidad += 1
                                        Console.WriteLine("Indicador registrado correctamente.")
                                        Console.WriteLine("ID: " & ids(cantidad - 1) & " | Nombre: " & nombres(cantidad - 1) & " | Actividad: " & actividades(cantidad - 1) & " | Meta: " & metas(cantidad - 1) & " | Resultado: " & resultados(cantidad - 1) & " | Rendimiento: " & rendimientos(cantidad - 1) & "% | Nivel: " & niveles(cantidad - 1))
                                    End If
                                End If
                            End If
                        End If
                    End If
                '----------------------'
                '--|editar_indicador|--'
                '----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen indicadores registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                        Next
                        Console.Write("Ingrese el ID del indicador a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            Dim nuevoNombre As String = Console.ReadLine()
                            If nuevoNombre = "" Then
                                Console.WriteLine("El nombre no puede estar vacio.")
                            Else
                                Console.Write("Nueva actividad: ")
                                Dim nuevaActividad As String = Console.ReadLine()
                                If nuevaActividad = "" Then
                                    Console.WriteLine("La actividad no puede estar vacia.")
                                Else
                                    Console.Write("Nueva meta: ")
                                    Dim nuevaMeta As Double = Convert.ToDouble(Console.ReadLine())
                                    If nuevaMeta <= 0 Then
                                        Console.WriteLine("La meta debe ser mayor que cero.")
                                    Else
                                        Console.Write("Nuevo resultado: ")
                                        Dim nuevoResultado As Double = Convert.ToDouble(Console.ReadLine())
                                        If nuevoResultado < 0 Then
                                            Console.WriteLine("El resultado no puede ser negativo.")
                                        Else
                                            Dim nuevoRendimiento As Double = (nuevoResultado / nuevaMeta) * 100
                                            Dim nuevoNivel As String = ""
                                            If nuevoRendimiento < 60 Then
                                                nuevoNivel = "Bajo"
                                            ElseIf nuevoRendimiento < 80 Then
                                                nuevoNivel = "Medio"
                                            ElseIf nuevoRendimiento < 100 Then
                                                nuevoNivel = "Alto"
                                            Else
                                                nuevoNivel = "Excelente"
                                            End If
                                            nombres(posicion) = nuevoNombre
                                            actividades(posicion) = nuevaActividad
                                            metas(posicion) = nuevaMeta
                                            resultados(posicion) = nuevoResultado
                                            rendimientos(posicion) = nuevoRendimiento
                                            niveles(posicion) = nuevoNivel
                                            Console.WriteLine("Indicador actualizado correctamente.")
                                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Actividad: " & actividades(posicion) & " | Meta: " & metas(posicion) & " | Resultado: " & resultados(posicion) & " | Rendimiento: " & rendimientos(posicion) & "% | Nivel: " & niveles(posicion))
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------'
                '--|listar_indicadores|--'
                '------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen indicadores registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                        Next
                    End If
                '----------------------'
                '--|buscar_indicador|--'
                '----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen indicadores registrados.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por nombre")
                        Console.WriteLine("3) Buscar por actividad")
                        Console.WriteLine("4) Buscar por nivel")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Actividad: " & actividades(posicion) & " | Meta: " & metas(posicion) & " | Resultado: " & resultados(posicion) & " | Rendimiento: " & rendimientos(posicion) & "% | Nivel: " & niveles(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el nombre: ")
                            Dim nombreBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If nombres(i).ToLower().Contains(nombreBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron indicadores.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese la actividad: ")
                            Dim actividadBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If actividades(i).ToLower().Contains(actividadBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron indicadores.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese el nivel: ")
                            Dim nivelBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If niveles(i).ToLower() = nivelBuscar.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron indicadores con ese nivel.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '------------------------'
                '--|eliminar_indicador|--'
                '------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen indicadores registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                        Next
                        Console.Write("Ingrese el ID del indicador a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                actividades(i) = actividades(i + 1)
                                metas(i) = metas(i + 1)
                                resultados(i) = resultados(i + 1)
                                rendimientos(i) = rendimientos(i + 1)
                                niveles(i) = niveles(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            nombres(cantidad) = ""
                            actividades(cantidad) = ""
                            metas(cantidad) = 0
                            resultados(cantidad) = 0
                            rendimientos(cantidad) = 0
                            niveles(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Indicador eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|evaluar_rendimiento|--'
                '-------------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen indicadores registrados.")
                    Else
                        Console.WriteLine("1) Mostrar rendimiento bajo")
                        Console.WriteLine("2) Mostrar rendimiento medio")
                        Console.WriteLine("3) Mostrar rendimiento alto")
                        Console.WriteLine("4) Mostrar rendimiento excelente")
                        Console.WriteLine("5) Mostrar indicadores que cumplen la meta")
                        Console.WriteLine("6) Mostrar indicadores que no cumplen la meta")
                        Console.WriteLine("7) Mostrar todos")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoEvaluacion As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoEvaluacion = 1 Then
                            Dim encontrado As Boolean = False

                            For i As Integer = 0 To cantidad - 1
                                If niveles(i) = "Bajo" Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen indicadores con rendimiento bajo.")
                            End If
                        ElseIf tipoEvaluacion = 2 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If niveles(i) = "Medio" Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen indicadores con rendimiento medio.")
                            End If
                        ElseIf tipoEvaluacion = 3 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If niveles(i) = "Alto" Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen indicadores con rendimiento alto.")
                            End If
                        ElseIf tipoEvaluacion = 4 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If niveles(i) = "Excelente" Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen indicadores con rendimiento excelente.")
                            End If
                        ElseIf tipoEvaluacion = 5 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If resultados(i) >= metas(i) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen indicadores que cumplan la meta.")
                            End If
                        ElseIf tipoEvaluacion = 6 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If resultados(i) < metas(i) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen indicadores que no cumplan la meta.")
                            End If
                        ElseIf tipoEvaluacion = 7 Then
                            For i As Integer = 0 To cantidad - 1
                                Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Actividad: " & actividades(i) & " | Meta: " & metas(i) & " | Resultado: " & resultados(i) & " | Rendimiento: " & rendimientos(i) & "% | Nivel: " & niveles(i))
                            Next
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 7
                    If cantidad = 0 Then
                        Console.WriteLine("No existen indicadores registrados.")
                    Else
                        Dim bajos As Integer = 0
                        Dim medios As Integer = 0
                        Dim altos As Integer = 0
                        Dim excelentes As Integer = 0
                        Dim cumplenMeta As Integer = 0
                        Dim noCumplenMeta As Integer = 0
                        Dim sumaRendimientos As Double = 0
                        Dim mayorRendimiento As Double = rendimientos(0)
                        Dim menorRendimiento As Double = rendimientos(0)
                        For i As Integer = 0 To cantidad - 1
                            If niveles(i) = "Bajo" Then
                                bajos += 1
                            ElseIf niveles(i) = "Medio" Then
                                medios += 1
                            ElseIf niveles(i) = "Alto" Then
                                altos += 1
                            ElseIf niveles(i) = "Excelente" Then
                                excelentes += 1
                            End If
                            If resultados(i) >= metas(i) Then
                                cumplenMeta += 1
                            Else
                                noCumplenMeta += 1
                            End If
                            sumaRendimientos += rendimientos(i)
                            If rendimientos(i) > mayorRendimiento Then
                                mayorRendimiento = rendimientos(i)
                            End If
                            If rendimientos(i) < menorRendimiento Then
                                menorRendimiento = rendimientos(i)
                            End If
                        Next
                        Dim promedioRendimiento As Double = sumaRendimientos / cantidad
                        Console.WriteLine("Total de indicadores: " & cantidad)
                        Console.WriteLine("Rendimiento bajo: " & bajos)
                        Console.WriteLine("Rendimiento medio: " & medios)
                        Console.WriteLine("Rendimiento alto: " & altos)
                        Console.WriteLine("Rendimiento excelente: " & excelentes)
                        Console.WriteLine("Indicadores que cumplen la meta: " & cumplenMeta)
                        Console.WriteLine("Indicadores que no cumplen la meta: " & noCumplenMeta)
                        Console.WriteLine("Promedio de rendimiento: " & promedioRendimiento & "%")
                        Console.WriteLine("Mayor rendimiento: " & mayorRendimiento & "%")
                        Console.WriteLine("Menor rendimiento: " & menorRendimiento & "%")
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 8
                    Console.WriteLine("Gracias por utilizar Indicador de Rendimiento.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 8
    End Sub
End Module