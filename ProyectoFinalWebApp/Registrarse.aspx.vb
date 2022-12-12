Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class WebForm1
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



        'End If


    End Sub

    Protected Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub

    Protected Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura 
        Dim wexisteusuario As Boolean

        wexisteusuario = False
        'valida si existe el usuario
        Try
            smt = "SELECT * FROM usuarios where usuario = '" & txt_usuario.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader

            While (data.Read()) 'mientras existan registros para leer 
                wexisteusuario = True
            End While
            data.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not (wexisteusuario) Then
            ' hace insert si el usuario no existe
            Try
                smt = "INSERT INTO [dbo].[usuarios] ([usuario],[nombre],[apellido],[correo],[contrasena]) VALUES ("
                smt = smt & "'" & txt_usuario.Text & "'"
                smt = smt & ",'" & txt_nombre.Text & "'"
                smt = smt & ",'" & txt_apellido.Text & "'"
                smt = smt & ",'" & txt_correo.Text & "'"
                smt = smt & ",'" & txt_contrasena.Text & "'"
                smt = smt & ")"
                cmd = New SqlClient.SqlCommand(smt, ob_conexion)
                data = cmd.ExecuteReader
                data.Close()
                MsgBox("Registro Insertado.   Retornar al formularion Login.")
                Response.Redirect("login.aspx")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Usuario existe.   Reintentar.")
        End If



    End Sub
End Class