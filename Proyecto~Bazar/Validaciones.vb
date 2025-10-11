Public Module Validaciones

    ' Solo Decimales y una coma: Para precios
    Function SoloNumerosDecimales(ByVal tecla As System.Windows.Forms.KeyPressEventArgs, ByVal texto_actual As String) As Boolean

        Dim tecla_presionada As Integer = AscW(tecla.KeyChar)

        ' Permitir números (48-57), backspace (8), coma (44), Enter (13)

        If (tecla_presionada >= 48 And tecla_presionada <= 57) Or tecla_presionada = 8 Or tecla_presionada = 44 Or tecla_presionada = 13 Then

            ' Validar que solo haya un punto decimal

            If tecla_presionada = 44 Then

                If texto_actual.Contains(",") Then

                    ' Si ya hay una coma, no permitir otra

                    Return False

                    Exit Function

                End If

            End If

            Return True

        Else

            Return False

        End If

    End Function

    ' Solo Enteros:
    Function SoloNumerosEnteros(ByVal tecla As System.Windows.Forms.KeyPressEventArgs) As Boolean

        Dim tecla_presionada As Integer = AscW(tecla.KeyChar)

        ' Permitir solo: números (48-57), backspace (8), Enter (13), Tab (9)

        If (tecla_presionada >= 48 And tecla_presionada <= 57) Or tecla_presionada = 8 Or tecla_presionada = 13 Or tecla_presionada = 9 Then

            Return True

        Else

            Return False

        End If

    End Function

    ' Validacion para textos.
    ' Char.IsLetter(tecla.KeyChar) Verifica si es una letra (A-Z, a-z, incluye acentos y caracteres especiales)
    ' Char.IsDigit(tecla.KeyChar) Verifica si es un número (0-9)
    ' Char.IsControl(tecla.KeyChar) Verifica si es una tecla de control (Backspace, Enter, Tab, Escape, etc.)
    'La "c" es un carácter literal (character literal). Indica que "." es un carácter (Char) y no una cadena (String).
    Function LetrasNumerosPuntos(ByVal tecla As System.Windows.Forms.KeyPressEventArgs) As Boolean
        ' Usar funciones built-in de VB.NET (más legible)
        If Char.IsLetter(tecla.KeyChar) Or
           Char.IsDigit(tecla.KeyChar) Or
           tecla.KeyChar = "."c Or
           tecla.KeyChar = " "c Or
           Char.IsControl(tecla.KeyChar) Then

            Return True

        Else

            Return False

        End If

    End Function




    ' Obtener Nombres de Columnas con Reflexión
    Public Sub CargarColumnasEnComboBox(tabla As DataTable, comboBox As ComboBox)

        comboBox.Items.Clear()

        For Each columna As DataColumn In tabla.Columns

            comboBox.Items.Add(columna.ColumnName)

        Next

        comboBox.SelectedIndex = 0

    End Sub

End Module
