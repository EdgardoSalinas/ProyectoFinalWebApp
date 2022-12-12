Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class consulta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then
            Me.SearchCustomers()
        End If

    End Sub

    Private Sub SearchCustomers()
        Dim constr As String = "Server=DESKTOP-EG9C4H1\SQLEXPRESS;Database=oficios;User Id=sa;Password=SSDSA;"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "Select u.[Usuario],n.Nombre,n.Apellido,Oficio=o.descripcion,u.Explicacion From [usuariooficio] u,oficios o, usuarios n where n.usuario = u.usuario and u.id_oficio = o.id"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " and ( u.usuario LIKE @usuario + '%'"
                    sql += " or n.nombre LIKE @usuario + '%'"
                    sql += " or n.apellido LIKE @usuario + '%'"
                    sql += " or o.descripcion LIKE @usuario + '%'"
                    sql += " or u.Explicacion LIKE @usuario + '%'"
                    sql += " )"
                    cmd.Parameters.AddWithValue("@usuario", txtSearch.Text.Trim())
                End If
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


    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchCustomers()
    End Sub

    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
        gvCustomers.PageIndex = e.NewPageIndex
        Me.SearchCustomers()
    End Sub


End Class