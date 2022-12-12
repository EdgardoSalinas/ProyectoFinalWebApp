
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class consultaoficiosmassolic
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BuscaOficiosmassolic()
    End Sub

    Private Sub BuscaOficiosmassolic()
        Dim constr As String = "Server=DESKTOP-EG9C4H1\SQLEXPRESS;Database=oficios;User Id=sa;Password=SSDSA;"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "select Oficio_Nombre=o.descripcion,Contador_Registros=count(*) from usuariooficio u, oficios o where u.id_oficio = o.id group by o.descripcion order by count(*) desc"
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    gvCustomers.DataSource = dt
                    gvCustomers.DataBind()
                End Using
            End Using
        End Using
    End Sub


End Class