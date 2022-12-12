Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class Login
    Inherits System.Web.UI.Page
    Dim ob_conexion As SqlClient.SqlConnection




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuario, psw, BD, servidor As String
        'Dim ob_conexion As SqlConnection

        'If Not (IsPostBack) Then
        Try
            servidor = "DESKTOP-EG9C4H1\SQLEXPRESS" 'nombre del  equipo  DESKTOP-EG9C4H1\SQLEXPRESS
            usuario = "sa" 'usuario administrador
            psw = "SSDSA" 'contraseña
            BD = "oficios" 'Nombre de la BDDim ob_conexion As

            ob_conexion = New SqlClient.SqlConnection 'variable de conexión que está en el módulo 
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" 'cadena de conexión 
            ob_conexion.Open() 'Abrir la base de datos
            'MsgBox("Conectado al servidor y la BD")
        Catch ex As Exception
            MsgBox(ex.Message) 'captura de error
        End Try

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("registrarse.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wexisteusuario As Boolean
        wexisteusuario = False
        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura 

        wexisteusuario = False
        'valida si existe el usuario
        Try
            smt = "SELECT * FROM usuarios where usuario = '" & txt_usuario.Text & "' and contrasena = '" & txt_contrasena.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            Data = cmd.ExecuteReader

            While (Data.Read()) 'mientras existan registros para leer 
                wexisteusuario = True
            End While
            Data.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        If wexisteusuario Then
            Application("usuariologeado") = txt_usuario.Text
            'My.Settings.usuarionombre = txt_usuario.Text
            Response.Redirect("Principal.aspx")
        Else
            Application("usuariologeado") = ""
            MsgBox("Usuario no existe.   Reintentar.")
        End If


    End Sub
End Class