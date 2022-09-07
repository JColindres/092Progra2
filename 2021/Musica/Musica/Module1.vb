Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Module Module1
    'Variables de la sesion
    Public id_usuario_sesion As String
    Public nombre_sesion As String
    Public usuario_sesion As String
    Public tipo_usuario_sesion As String

    Dim datosConexion As String = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=1068868;" _
                    & "database=proyecto_201602713"
    Public conexion As MySqlConnection = New MySqlConnection(datosConexion)

    Public comando As MySqlCommand = New MySqlCommand

    Public Sub ProbarConexion()
        Try
            conexion.Open()
            MsgBox("Se ha realizado la conexión correctamente!")
        Catch ex As Exception
            MsgBox("Error en la conexión!")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub IniciarConexion()
        Try
            conexion.Open()
            Console.WriteLine("Se ha realizado la conexión correctamente!")
        Catch ex As Exception
            MsgBox("Error en la conexión!")
        End Try
    End Sub
    Public Function ResizeImage(ByVal image As Image,
        ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function
End Module
