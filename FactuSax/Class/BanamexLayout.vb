Public Class BanamexLayout
    Private Num_Cliente As String ''B5
    Private Nom_Cliente As String ''B6
    Private Cta_Cargo As String
    Private Num_Sucursal As String
    Private Fech_Pago As String ''E5
    Private Desc_pago As String ''E6
    Private Sec As Integer ''E7
    Private Tipo_Pago As String
    Public sTipo_Reporte As String
    Sub Genera()
        Dim regcontrol(7) As String

        regcontrol(1) = "1"
        regcontrol(2) = poncomplementos((Trim(Num_Cliente)), (12 - (Len((Trim(Num_Cliente))))), True, "D")
        regcontrol(3) = Format((Fech_Pago), "yymmdd")
        regcontrol(4) = poncomplementos((Trim(Sec)), (4 - (Len((Trim(Sec))))), True, "D")
        regcontrol(5) = poncomplementos(cambia((Trim(Nom_Cliente)), False), (36 - (Len(Left((Trim(Nom_Cliente)), 36)))), False, "I")
        regcontrol(6) = poncomplementos(cambia((Trim(Desc_pago)), False), (20 - (Len(Left((Trim(Desc_pago)), 20)))), False, "I")
        regcontrol(7) = "15D01"
        regcontrol(0) = regcontrol(1) & regcontrol(2) & regcontrol(3) & regcontrol(4) & regcontrol(5) & regcontrol(6) & regcontrol(7)
    End Sub
    Function clabeinter(vvcta As String) As Boolean

        Dim emploclabe As String
        Dim comparadigito As Integer
        Dim i, sumv

        emploclabe = vvcta

        comparadigito = Right(emploclabe, 1)


        For i = 1 To 17
            If i = 1 Or i = 4 Or i = 7 Or i = 10 Or i = 13 Or i = 16 Then
                sumv = Val(Right(3 * Val(Mid(emploclabe, i, 1)), 1)) + sumv
            ElseIf i = 2 Or i = 5 Or i = 8 Or i = 11 Or i = 14 Or i = 17 Then
                sumv = Val(Right(7 * Val(Mid(emploclabe, i, 1)), 1)) + sumv
            ElseIf i = 3 Or i = 6 Or i = 9 Or i = 12 Or i = 15 Then
                sumv = Val(Right(1 * Val(Mid(emploclabe, i, 1)), 1)) + sumv
            End If
        Next i
        sumv = Val(Right(Str(sumv), 1))
        sumv = 10 - sumv
        If sumv = 10 Then sumv = 0

        If sumv = comparadigito Then
            clabeinter = True
        Else
            clabeinter = False
        End If
    End Function

    'Valida que la Tarjeta sea correcta, no valida si nada con el banco.
    Function validatarjeta(vcta As String) As Boolean

        Dim tarjeta, lnNum, n, sumanum, valida
        tarjeta = vcta
        For n = 1 To 15 Step 2
            lnNum = Int(Val(Mid(tarjeta, n, 1)) * 2)
            Select Case lnNum
                Case Is < 9
                    sumanum = sumanum + lnNum
                    sumanum = sumanum + Val(Mid(tarjeta, n + 1, 1))
                Case Is > 9
                    lnNum = lnNum - 9
                    sumanum = sumanum + lnNum
                    sumanum = sumanum + Val(Mid(tarjeta, n + 1, 1))
            End Select
        Next n

        valida = sumanum Mod 10

        If valida = 0 And valida <= 150 Then
            validatarjeta = True
        Else
            validatarjeta = False
        End If

    End Function
    Function cambia(vvnomb As String, beneficiario As Boolean) As String
        Dim VVALOR, modificado, largos, i
        Dim Vpaterno, Vmaterno, vnom
        Dim v1, v2, bandera1, bandera2

        VVALOR = vvnomb

        modificado = Replace(VVALOR, "á", "a")
        modificado = Replace(modificado, "é", "e")
        modificado = Replace(modificado, "í", "i")
        modificado = Replace(modificado, "ó", "o")
        modificado = Replace(modificado, "ú", "u")
        modificado = Replace(modificado, "ü", "u")
        modificado = Replace(modificado, "û", "u")
        modificado = Replace(modificado, "ñ", "@")
        modificado = Replace(modificado, "Á", "A")
        modificado = Replace(modificado, "É", "E")
        modificado = Replace(modificado, "Í", "I")
        modificado = Replace(modificado, "Ó", "O")
        modificado = Replace(modificado, "Ú", "U")

        modificado = Replace(modificado, "à", "a")
        modificado = Replace(modificado, "è", "e")
        modificado = Replace(modificado, "ì", "i")
        modificado = Replace(modificado, "ò", "o")
        modificado = Replace(modificado, "ù", "u")
        modificado = Replace(modificado, "À", "A")
        modificado = Replace(modificado, "È", "E")
        modificado = Replace(modificado, "Ì", "I")
        modificado = Replace(modificado, "Ò", "O")
        modificado = Replace(modificado, "Ù", "U")

        modificado = Replace(modificado, "Ü", "U")
        modificado = Replace(modificado, "Û", "U")
        modificado = Replace(modificado, "Ñ", "@")
        modificado = Replace(modificado, ".", " ")
        modificado = Replace(modificado, "*", " ")
        modificado = Replace(modificado, " ", " ")
        modificado = Replace(modificado, "'", " ")
        modificado = Replace(modificado, "´", " ")


        If beneficiario = False Then
            modificado = Replace(modificado, "/", " ")
            modificado = Replace(modificado, "\", " ")
            modificado = Replace(modificado, ",", " ")
        End If

        modificado = UCase(modificado)


        If beneficiario = True Then
            largos = Len(modificado)
            For i = 1 To largos
                If Mid(modificado, i, 1) = "," Then
                    bandera1 = i
                ElseIf Mid(modificado, i, 1) = "/" Then
                    bandera2 = i
                End If
            Next i
            v1 = largos - bandera1
            v2 = bandera2 - bandera1
            vnom = Trim(Mid(modificado, 1, (bandera1 - 1)))
            Vpaterno = Trim(Mid(modificado, (bandera1 + 1), (v2 - 1)))
            Vmaterno = Trim(Mid(modificado, (bandera2 + 1), largos))

            If Vpaterno = "x" Or Vpaterno = "X" Then
                Vpaterno = ""
            End If
            If Vmaterno = "x" Or Vmaterno = "X" Then
                Vmaterno = ""
            End If
            If Len(Vpaterno) <= 0 And Len(Vmaterno) > 0 Then
                cambia = vnom & "," & Vmaterno & "/" & Vpaterno
            Else
                cambia = vnom & "," & Vpaterno & "/" & Vmaterno
            End If
        Else
            cambia = modificado
        End If

    End Function


    Function poncomplementos(val1 As String, vlargo As Integer, ceros As Boolean, IzqoDer As String) As String
        Dim valor, tamano, complemento, k
        valor = val1
        tamano = vlargo
        ' Con sw = true se ponene ceros, en caso contrario son espacios

        If ceros = True Then
            For k = 1 To tamano
                complemento = complemento + "0"
            Next k
        Else
            complemento = Space(tamano)
        End If

        If IzqoDer = "D" Then
            poncomplementos = complemento & valor
        Else
            poncomplementos = valor & complemento
        End If

    End Function
End Class
