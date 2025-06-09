Imports MySql.Data.MySqlClient

Public Class Login

    'Dim username As String = "admin"
    'Dim password As String = "1234"

    'Dim currentUser As String = "stall12"

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If pword.UseSystemPasswordChar = False Then
            pword.UseSystemPasswordChar = True
        Else
            pword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        productslist.currentStallAccount = Me.uname.Text

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM stall_profile WHERE stall_username = @stall_username AND stall_password = @stall_password"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@stall_username", uname.Text)
            cmd.Parameters.AddWithValue("@stall_password", pword.Text)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    If reader("stall_username").ToString() = "admin" And reader("stall_password").ToString() = pword.Text Then
                        Me.Hide()
                        AdminAccount.Show()
                    Else
                        Me.Hide()
                        Home.Show()
                    End If
                Else
                    MessageBox.Show("   Wrong credentials! Try again.   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            Dim username As String = InputBox("Enter your username")
            Dim ownerName As String = InputBox("Enter the stall owner's name")
            Dim birthdate As String = InputBox("Enter the stall owner's birthdate (MM-DD-YYYY)")

            cmd.CommandText = "SELECT stall_password FROM stall_profile WHERE stall_username = @stall_username AND stall_ownername = @stall_ownername AND stall_ownerbirthdate = @stall_ownerbirthdate"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@stall_username", username)
            cmd.Parameters.AddWithValue("@stall_ownername", ownerName)
            cmd.Parameters.AddWithValue("@stall_ownerbirthdate", DateTime.ParseExact(birthdate, "MM-dd-yyyy", Nothing))

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim password As String = reader("stall_password").ToString()
                    MessageBox.Show("Your password is: " & password, "Credentials", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("The entered information does not match. Please try again later.", "Error", MessageBoxButtons.OK)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub
End Class