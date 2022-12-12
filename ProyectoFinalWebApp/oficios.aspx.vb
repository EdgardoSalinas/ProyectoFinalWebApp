

Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader

Public Class oficios

    Inherits System.Web.UI.Page
    Dim ob_conexion As SqlClient.SqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'cargaroficios()


    End Sub


    Sub cargaroficios()



        ' SET THE CONNECTION STRING.

        Dim usuario, psw, BD, servidor As String
            'Dim ob_conexion As SqlConnection
            servidor = "DESKTOP-EG9C4H1\SQLEXPRESS" 'nombre del  equipo  DESKTOP-EG9C4H1\SQLEXPRESS
            usuario = "sa" 'usuario administrador
            psw = "SSDSA" 'contraseña
            BD = "oficios" 'Nombre de la BDDim ob_conexion As

            Dim sCon As String = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" 'cadena de conexión 
            '    "Data Source=intel;Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=DNA_CLASSIFIED;User Id=sa;Password=demo;Connect Timeout=30;"

            Using con As SqlClient.SqlConnection = New SqlClient.SqlConnection(sCon)
                Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT *FROM dbo.oficios")
                    Dim sda As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
                    cmd.Connection = con : con.Open()
                    sda.SelectCommand = cmd

                    Dim dt As DataTable = New DataTable
                    sda.Fill(dt)

                ' BIND DATABASE WITH THE GRIDVIEW.
                OficiosGridView.DataSource = sda
                OficiosGridView.DataBind()

            End Using
            End Using


    End Sub

    Protected Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Dim ob_conexion As SqlClient.SqlConnection

        Dim usuario, psw, BD, servidor As String
        ob_conexion = New SqlClient.SqlConnection 'variable de conexión que está en el módulo 
        'Dim ob_conexion As SqlConnection
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

        Dim smt As String 'cadena sentencia SQL
        Dim cmd As SqlClient.SqlCommand 'objeto de comando
        Dim data As SqlClient.SqlDataReader 'objeto de lectura 
        Try
            smt = "INSERT INTO [dbo].[oficios] ([descripcion]) VALUES ("
            smt = smt & "'" & txt_descripcion.Text & "'"
            smt = smt & ")"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader
            'While (data.Read()) 'mientras existan registros para leer 
            'DataGridView1.Rows.Add(data("REFERENCIA"), data("CODIGODEBARRA"), data("DESCRIPCION"), data("UNIDADMEDIDA"), data("PRECIO"))
            'End While
            data.Close()
            MsgBox("Registro Insertado")


            OficiosGridView.DataBind()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class