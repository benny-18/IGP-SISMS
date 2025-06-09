Imports MySql.Data.MySqlClient

Public Class Home
    Private isEditingProfile As Boolean

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim diagExit As DialogResult

        diagExit = MessageBox.Show("Logout from current user?", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If diagExit = DialogResult.Yes Then
            Me.Hide()

            Login.uname.Text = ""
            Login.pword.Text = ""
            Login.Show()
        End If

    End Sub

    Private Sub btnProdList_Click(sender As Object, e As EventArgs) Handles btnProdList.Click
        Me.Hide()
        productslist.Show()
    End Sub

    Private Sub btnInSummary_Click(sender As Object, e As EventArgs) Handles btnInSummary.Click
        Me.Hide()
        InSummary.Show()
    End Sub

    Private Sub btnSalesTrack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SalesT.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Private Sub stallOwnerProfileEdit_Click(sender As Object, e As EventArgs) Handles stallOwnerProfileEdit.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            If isEditingProfile = False Then
                isEditingProfile = True

                btnStallOwnerPhotoImport.Visible = True
                txtStallOwner.Visible = True
                stallOwnerName.Visible = False
                txtStallOwner.Text = stallOwnerName.Text
                datetimeStallBirthdate.Visible = True
                stallOwnerBirthdate.Visible = False
                datetimeStallBirthdate.Value = DateTime.Parse(stallOwnerBirthdate.Text)
                txtStallUsername.Visible = True
                stallUsername.Visible = False
                txtStallUsername.Text = stallUsername.Text
                txtStallName.Visible = True
                stallName.Visible = False
                txtStallName.Text = stallName.Text
                btnPasswordChange.Visible = True

            Else
                isEditingProfile = False

                btnStallOwnerPhotoImport.Visible = False
                txtStallOwner.Visible = False
                stallOwnerName.Visible = True
                datetimeStallBirthdate.Visible = False
                stallOwnerBirthdate.Visible = True
                txtStallUsername.Visible = False
                stallUsername.Visible = True
                txtStallName.Visible = False
                stallName.Visible = True
                btnPasswordChange.Visible = False

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Confirm changes", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    cmd.CommandText = "UPDATE stall_profile SET stall_name = @stall_name, stall_ownername = @stall_ownername, stall_ownerphoto = @stall_ownerphoto, stall_ownerbirthdate = @stall_ownerbirthdate, stall_username = @stall_username WHERE stall_username = @old_username"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@stall_name", txtStallName.Text)
                    cmd.Parameters.AddWithValue("@stall_ownername", txtStallOwner.Text)
                    cmd.Parameters.AddWithValue("@stall_ownerphoto", OpenFileDialog2.FileName)
                    cmd.Parameters.AddWithValue("@stall_ownerbirthdate", datetimeStallBirthdate.Value.Date)
                    cmd.Parameters.AddWithValue("@stall_username", txtStallUsername.Text)
                    cmd.Parameters.AddWithValue("@old_username", stallUsername.Text)

                    cmd.ExecuteNonQuery()

                    stallName.Text = txtStallName.Text
                    stallOwnerName.Text = txtStallOwner.Text
                    stallOwnerPhoto.Image = Image.FromFile(OpenFileDialog2.FileName)
                    stallOwnerBirthdate.Text = datetimeStallBirthdate.Value.ToString("MM-dd-yyyy")
                    stallUsername.Text = txtStallUsername.Text
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnPasswordChange_Click(sender As Object, e As EventArgs) Handles btnPasswordChange.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            Dim currentPassword As String = InputBox("   Enter your current password   ")

            cmd.CommandText = "SELECT stall_password FROM stall_profile WHERE stall_username = @stall_username"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@stall_username", stallUsername.Text)

            Using reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    If reader("stall_password").ToString() = currentPassword Then
                        reader.Close()

                        Dim newPassword As String = InputBox("Enter your new password")

                        cmd.CommandText = "UPDATE stall_profile SET stall_password = @new_password WHERE stall_username = @stall_username"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@new_password", newPassword)
                        cmd.Parameters.AddWithValue("@stall_username", stallUsername.Text)

                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Your password has been changed successfully.", "Password Change", MessageBoxButtons.OK)
                    Else
                        MessageBox.Show("The entered password does not match with the current password.", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("The username does not exist.", "Error", MessageBoxButtons.OK)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnStallOwnerPhotoImport_Click(sender As Object, e As EventArgs) Handles btnStallOwnerPhotoImport.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            MessageBox.Show("   Image imported!   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("   Choose an image, and try again.   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Home_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM stall_profile WHERE stall_username = @stall_username"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@stall_username", Login.uname.Text)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    stallName.Text = reader("stall_name").ToString()
                    stallOwnerName.Text = reader("stall_ownername").ToString()
                    stallOwnerPhoto.Image = Image.FromFile(reader("stall_ownerphoto").ToString())
                    stallOwnerBirthdate.Text = DateTime.Parse(reader("stall_ownerbirthdate").ToString()).ToString("MM-dd-yyyy")
                    stallUsername.Text = reader("stall_username").ToString()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub
End Class