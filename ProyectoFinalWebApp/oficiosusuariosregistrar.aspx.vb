Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader


Public Class oficiosusuariosregistrar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim usuario, psw, BD, servidor As String
        Dim ob_conexion As SqlClient.SqlConnection
        ob_conexion = New SqlClient.SqlConnection 'variable de conexión que está en el módulo   

        'If Not (IsPostBack) Then
        Try
            servidor = "DESKTOP-EG9C4H1\SQLEXPRESS" 'nombre del  equipo  DESKTOP-EG9C4H1\SQLEXPRESS
            usuario = "sa" 'usuario administrador
            psw = "SSDSA" 'contraseña
            BD = "oficios" 'Nombre de la BDDim ob_conexion As
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" 'cadena de conexión 
            ob_conexion.Open() 'Abrir la base de datos
            'MsgBox("Conectado al servidor y la BD")
        Catch ex As Exception
            MsgBox(ex.Message) 'captura de error
        End Try


        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura 


        Try
            smt = "SELECT * FROM usuarios where usuario = '" & Application("usuariologeado") & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader

            While (data.Read()) 'mientras existan registros para leer 
                txt_nombre.Text = data("nombre")
                txt_apellido.Text = data("apellido")
            End While
            data.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura 
        Dim ob_conexion = New SqlClient.SqlConnection 'variable de conexión que está en el módulo   

        Dim usuario, psw, BD, servidor As String
        Dim existeregistro As Boolean

        servidor = "DESKTOP-EG9C4H1\SQLEXPRESS" 'nombre del  equipo  DESKTOP-EG9C4H1\SQLEXPRESS
        usuario = "sa" 'usuario administrador
        psw = "SSDSA" 'contraseña
        BD = "oficios" 'Nombre de la BDDim ob_conexion As
        ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" 'cadena de conexión 
        ob_conexion.Open() 'Abrir la base de datos

        existeregistro = False

        Try
            smt = "SELECT * FROM usuariooficio where usuario = '" & Application("usuariologeado") & "' and id_oficio ='" & DropDownList1.SelectedItem.Value & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader

            While (data.Read()) 'mientras existan registros para leer 
                MsgBox("Registro ya existe.  Intente nuevamente.")
                existeregistro = True
            End While
            data.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If existeregistro = False Then
            Try
                smt = "INSERT INTO [dbo].[usuariooficio] ([usuario],id_oficio,explicacion) VALUES ("
                smt = smt & "'" & Application("usuariologeado") & "',"
                smt = smt & "'" & DropDownList1.SelectedItem.Value & "',"
                smt = smt & "'" & txt_explicacion.Text & "'"
                smt = smt & ")"
                cmd = New SqlClient.SqlCommand(smt, ob_conexion)
                data = cmd.ExecuteReader
                'While (data.Read()) 'mientras existan registros para leer 
                'DataGridView1.Rows.Add(data("REFERENCIA"), data("CODIGODEBARRA"), data("DESCRIPCION"), data("UNIDADMEDIDA"), data("PRECIO"))
                'End While
                data.Close()
                MsgBox("Registro Insertado")

                OficiosxuserGridView.DataBind()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub
End Class