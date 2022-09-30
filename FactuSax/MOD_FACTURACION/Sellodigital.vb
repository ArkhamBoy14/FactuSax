Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading.Tasks
Imports System.Runtime.InteropServices


Public Class Sellodigital
        Public Function Sellar(ByVal CadenaOriginal As String, ByVal ArchivoClavePrivada As String, ByVal lPassword As String) As String
            Dim ClavePrivada As Byte() = File.ReadAllBytes(ArchivoClavePrivada)
            Dim bytesFirmados As Byte() = Nothing
            Dim bCadenaOriginal As Byte() = Nothing
            Dim lSecStr As SecureString = New SecureString()
            Dim sham As SHA256Managed = New SHA256Managed()
            lSecStr.Clear()

            For Each c As Char In lPassword.ToCharArray()
                lSecStr.AppendChar(c)
            Next

        Dim lrsa As RSACryptoServiceProvider = JavaScience.opensslkey.DecodeEncryptedPrivateKeyInfo(ClavePrivada, lSecStr)
        bCadenaOriginal = Encoding.UTF8.GetBytes(CadenaOriginal)

            Try
                bytesFirmados = lrsa.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), sham)
            Catch ex As NullReferenceException
                Throw New NullReferenceException("Clave privada incorrecta, revisa que la clave que escribes corresponde a los sellos digitales cargados")
            End Try

            Dim sellodigital As String = Convert.ToBase64String(bytesFirmados)
            Return sellodigital
        End Function

        Public Function Sellar(ByVal CadenaOriginal As String, ByVal ArchivoClavePrivada As Byte(), ByVal lPassword As String) As String
            Dim ClavePrivada As Byte() = ArchivoClavePrivada
            Dim bytesFirmados As Byte() = Nothing
            Dim bCadenaOriginal As Byte() = Nothing
            Dim lSecStr As SecureString = New SecureString()
            Dim sham As SHA256Managed = New SHA256Managed()
            lSecStr.Clear()

            For Each c As Char In lPassword.ToCharArray()
                lSecStr.AppendChar(c)
            Next

            Dim lrsa As RSACryptoServiceProvider = JavaScience.opensslkey.DecodeEncryptedPrivateKeyInfo(ClavePrivada, lSecStr)
            bCadenaOriginal = Encoding.UTF8.GetBytes(CadenaOriginal)

            Try
                bytesFirmados = lrsa.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), sham)
            Catch __unusedNullReferenceException1__ As NullReferenceException
                Throw New NullReferenceException("Clave privada incorrecta.")
            End Try

            Dim sellodigital As String = Convert.ToBase64String(bytesFirmados)
            Return sellodigital
        End Function

        Public Function verificarSello(ByVal CadenaOriginal As String, ByVal ArchivoClavePrivada As String, ByVal lPassword As String, ByVal ArchivoClavePublica As String) As Boolean
            Dim ClavePrivada As Byte() = File.ReadAllBytes(ArchivoClavePrivada)
            Dim bytesFirmados As Byte() = Nothing
            Dim bCadenaOriginal As Byte() = Nothing
            Dim lSecStr As SecureString = New SecureString()
            Dim sham As SHA1Managed = New SHA1Managed()
            lSecStr.Clear()

            For Each c As Char In lPassword.ToCharArray()
                lSecStr.AppendChar(c)
            Next

            Dim lrsa As RSACryptoServiceProvider = JavaScience.opensslkey.DecodeEncryptedPrivateKeyInfo(ClavePrivada, lSecStr)
            bCadenaOriginal = Encoding.UTF8.GetBytes(CadenaOriginal)

            Try
                bytesFirmados = lrsa.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), sham)
            Catch __unusedNullReferenceException1__ As NullReferenceException
                Throw New NullReferenceException("Clave privada incorrecta.")
            End Try

            Dim sellodigital As String = Convert.ToBase64String(bytesFirmados)
            Dim rsaCSP As RSACryptoServiceProvider = New RSACryptoServiceProvider()
            Dim hash As SHA1Managed = New SHA1Managed()
            Dim hashedData As Byte()
            Dim dataOK As Boolean = rsaCSP.VerifyData(Encoding.UTF8.GetBytes(CadenaOriginal), CryptoConfig.MapNameToOID("SHA1"), bytesFirmados)
            hashedData = hash.ComputeHash(bytesFirmados)
            Return rsaCSP.VerifyHash(hashedData, CryptoConfig.MapNameToOID("SHA1"), Encoding.UTF8.GetBytes(CadenaOriginal))
        End Function

        Public Function SellarMD5(ByVal CadenaOriginal As String, ByVal ArchivoClavePrivada As String, ByVal lPassword As String) As String
            Dim ClavePrivada As Byte() = File.ReadAllBytes(ArchivoClavePrivada)
            Dim bytesFirmados As Byte() = Nothing
            Dim bCadenaOriginal As Byte() = Nothing
            Dim lSecStr As SecureString = New SecureString()
            lSecStr.Clear()

            For Each c As Char In lPassword.ToCharArray()
                lSecStr.AppendChar(c)
            Next

            Dim lrsa As RSACryptoServiceProvider = JavaScience.opensslkey.DecodeEncryptedPrivateKeyInfo(ClavePrivada, lSecStr)
            Dim hasher As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            bCadenaOriginal = Encoding.UTF8.GetBytes(CadenaOriginal)
            hasher.ComputeHash(bCadenaOriginal)
            bytesFirmados = lrsa.SignData(bCadenaOriginal, hasher)
            Dim sellodigital As String = Convert.ToBase64String(bytesFirmados)
            Return sellodigital
        End Function

        Public Function Certificado(ByVal ArchivoCER As String) As String
            Dim Certificadox As Byte() = File.ReadAllBytes(ArchivoCER)
            Return Base64_Encode(Certificadox)
        End Function

        Public Function Certificado(ByVal ArchivoCER As Byte()) As String
            Return Base64_Encode(ArchivoCER)
        End Function

        Private Function Base64_Encode(ByVal str As Byte()) As String
            Return Convert.ToBase64String(str)
        End Function

        Private Function Base64_Decode(ByVal str As String) As Byte()
            Try
                Dim decbuff As Byte() = Convert.FromBase64String(str)
                Return decbuff
            Catch

                If True Then
                    Return Nothing
                End If
            End Try
        End Function

        Public Shared Function getCadenaOriginal(ByVal NombreXML As String) As String
            Dim transformer As System.Xml.Xsl.XslCompiledTransform = New System.Xml.Xsl.XslCompiledTransform()
            Dim strwriter As StringWriter = New StringWriter()

        If File.Exists("cadenaoriginal_4_0.xslt") Then

            Try
                transformer.Load("cadenaoriginal_4_0.xslt")
                transformer.Transform(NombreXML, Nothing, strwriter)
                Return strwriter.ToString()
            Catch e As Exception
                Console.WriteLine(e.Message)
            End Try
        End If

        If File.Exists("cadenaoriginal_4_0.xslt") Then

            Try
                transformer.Load("cadenaoriginal_4_0.xslt")
                transformer.Transform(NombreXML, Nothing, strwriter)
                Return strwriter.ToString()
            Catch e As Exception
                Console.WriteLine(e.Message)
                Throw e
            End Try
        Else
            Return "Error al cargar el validador."
            End If
        End Function

        Public Shared Function md5(ByVal Value As String) As String
            Dim originalBytes As Byte()
            Dim encodedBytes As Byte()
            Dim md5x As MD5
            md5x = New MD5CryptoServiceProvider()
            originalBytes = Encoding.UTF8.GetBytes(Value)
            encodedBytes = md5x.ComputeHash(originalBytes)
            Dim ret As String = ""

            For i As Integer = 0 To encodedBytes.Length - 1
                ret += encodedBytes(i).ToString("x2").ToLower()
            Next

            Return ret
        End Function

        Public Shared Function leerCER(ByVal NombreArchivo As String, <Out> ByRef Inicio As String, <Out> ByRef Final As String, <Out> ByRef Serie As String, <Out> ByRef Numero As String) As Boolean
            If NombreArchivo.Length < 1 Then
                Inicio = ""
                Final = ""
                Serie = "INVALIDO"
                Numero = ""
                Return False
            End If

            Dim objCert As X509Certificate2 = New X509Certificate2(NombreArchivo)
            Dim objSB As StringBuilder = New StringBuilder("Detalle del certificado: " & vbLf & vbLf)
            objSB.AppendLine("Persona = " & objCert.Subject)
            objSB.AppendLine("Emisor = " & objCert.Issuer)
            objSB.AppendLine("Válido desde = " & objCert.NotBefore.ToString())
            Inicio = objCert.NotBefore.ToString()
            objSB.AppendLine("Válido hasta = " & objCert.NotAfter.ToString())
            Final = objCert.NotAfter.ToString()
            objSB.AppendLine("Tamaño de la clave = " & objCert.PublicKey.Key.KeySize.ToString())
            objSB.AppendLine("Número de serie = " & objCert.SerialNumber)
            Serie = objCert.SerialNumber.ToString()
            objSB.AppendLine("Hash = " & objCert.Thumbprint)
            Dim tNumero As String = "", rNumero As String = "", tNumero2 As String = ""
            Dim X As Integer

            If Serie.Length < 2 Then
                Numero = ""
            Else

                For Each c As Char In Serie

                    Select Case c
                        Case "0"c
                            tNumero += c
                        Case "1"c
                            tNumero += c
                        Case "2"c
                            tNumero += c
                        Case "3"c
                            tNumero += c
                        Case "4"c
                            tNumero += c
                        Case "5"c
                            tNumero += c
                        Case "6"c
                            tNumero += c
                        Case "7"c
                            tNumero += c
                        Case "8"c
                            tNumero += c
                        Case "9"c
                            tNumero += c
                    End Select
                Next

                For X = 1 To tNumero.Length - 1
                    X += 1
                    tNumero2 = tNumero.Substring(0, X)
                    rNumero = rNumero & tNumero2.Substring(tNumero2.Length - 1, 1)
                Next

                Numero = rNumero
            End If

            If DateTime.Now < objCert.NotAfter AndAlso DateTime.Now > objCert.NotBefore Then
                Return True
            End If

            Return False
        End Function

        Public Shared Function leerCER(ByVal NombreArchivo As Byte(), <Out> ByRef Inicio As String, <Out> ByRef Final As String, <Out> ByRef Serie As String, <Out> ByRef Numero As String) As Boolean
            If NombreArchivo.Length < 1 Then
                Inicio = ""
                Final = ""
                Serie = "INVALIDO"
                Numero = ""
                Return False
            End If

            Dim objCert As X509Certificate2 = New X509Certificate2(NombreArchivo)
            Dim objSB As StringBuilder = New StringBuilder("Detalle del certificado: " & vbLf & vbLf)
            objSB.AppendLine("Persona = " & objCert.Subject)
            objSB.AppendLine("Emisor = " & objCert.Issuer)
            objSB.AppendLine("Válido desde = " & objCert.NotBefore.ToString())
            Inicio = objCert.NotBefore.ToString()
            objSB.AppendLine("Válido hasta = " & objCert.NotAfter.ToString())
            Final = objCert.NotAfter.ToString()
            objSB.AppendLine("Tamaño de la clave = " & objCert.PublicKey.Key.KeySize.ToString())
            objSB.AppendLine("Número de serie = " & objCert.SerialNumber)
            Serie = objCert.SerialNumber.ToString()
            objSB.AppendLine("Hash = " & objCert.Thumbprint)
            Dim tNumero As String = "", rNumero As String = "", tNumero2 As String = ""
            Dim X As Integer

            If Serie.Length < 2 Then
                Numero = ""
            Else

                For Each c As Char In Serie

                    Select Case c
                        Case "0"c
                            tNumero += c
                        Case "1"c
                            tNumero += c
                        Case "2"c
                            tNumero += c
                        Case "3"c
                            tNumero += c
                        Case "4"c
                            tNumero += c
                        Case "5"c
                            tNumero += c
                        Case "6"c
                            tNumero += c
                        Case "7"c
                            tNumero += c
                        Case "8"c
                            tNumero += c
                        Case "9"c
                            tNumero += c
                    End Select
                Next

                For X = 1 To tNumero.Length - 1
                    X += 1
                    tNumero2 = tNumero.Substring(0, X)
                    rNumero = rNumero & tNumero2.Substring(tNumero2.Length - 1, 1)
                Next

                Numero = rNumero
            End If

            If DateTime.Now < objCert.NotAfter AndAlso DateTime.Now > objCert.NotBefore Then
                Return True
            End If

            Return False
        End Function

        Public Shared Function validarCERKEY(ByVal NombreArchivoCER As String, ByVal NombreArchivoKEY As String, ByVal ClavePrivada As String) As Boolean
            Dim certificado As X509Certificate2 = New X509Certificate2(File.ReadAllBytes(NombreArchivoCER))
            Dim pk As Byte() = certificado.GetPublicKey()
            Dim certPrivado As X509Certificate2 = New X509Certificate2(File.ReadAllBytes(NombreArchivoKEY))
            Return False
        End Function
    End Class
