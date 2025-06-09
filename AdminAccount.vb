Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AdminAccount
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")

    Private Sub btnPasswordChange_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim diagExit As DialogResult

        diagExit = MessageBox.Show("Logout from current user?", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If diagExit = DialogResult.Yes Then
            Login.uname.Text = ""
            Login.pword.Text = ""
            Login.pword.UseSystemPasswordChar = True

            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If btnAddAccount.Visible = False Then
            btnAddAccount.Visible = True

            btnSaveEdits.Visible = False
            btnDeleteAccount.Visible = False
            btnStallPasswordChange.Visible = False

            txtStallName.Text = "Stall number"
            txtStallOwnerName.Text = "Stall owner name"
            txtStallPassword.Text = "Stall password"
            txtStallUsername.Text = "Stall username"
        ElseIf btnAddAccount.Visible = True Then
            btnAddAccount.Visible = False

            btnSaveEdits.Visible = True
            btnDeleteAccount.Visible = True
            btnStallPasswordChange.Visible = True
        End If
    End Sub

    Private Sub btnAcctsListRefresh_Click(sender As Object, e As EventArgs) Handles btnAcctsListRefresh.Click
        Try
            RefreshAccountList()
        Catch ex As Exception
            MessageBox.Show("An error occurred while refreshing the account list: " & ex.Message)
        End Try
    End Sub

    Private Sub panListAcctsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles panListAcctsList.SelectedIndexChanged
        Try
            Dim selectedStall As DataRowView = DirectCast(panListAcctsList.SelectedItem, DataRowView)

            If selectedStall IsNot Nothing Then
                Dim stallName As String = selectedStall("stall_name").ToString()

                Dim cmd As New MySqlCommand("SELECT * FROM stall_profile WHERE stall_name = @stallName", conn)
                cmd.Parameters.AddWithValue("@stallName", stallName)

                conn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtStallName.Text = reader("stall_name").ToString()
                        txtStallOwnerName.Text = reader("stall_ownername").ToString()
                        acctImage.Image = Image.FromFile(reader("stall_ownerphoto").ToString())
                        dtpStallOwnerBirthdate.Text = DateTime.Parse(reader("stall_ownerbirthdate").ToString()).ToString("MM-dd-yyyy")
                        txtStallUsername.Text = reader("stall_username").ToString()
                    End If
                End Using

                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the account details: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshAccountList()
        Try
            Dim cmd As New MySqlCommand("SELECT * FROM stall_profile WHERE stall_username <> 'admin'", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            panListAcctsList.DataSource = table
            panListAcctsList.DisplayMember = "stall_name"
        Catch ex As Exception
            Throw New Exception("An error occurred while refreshing the account list: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveEdits_Click(sender As Object, e As EventArgs) Handles btnSaveEdits.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the edits?", "Confirmation", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim cmd As New MySqlCommand("UPDATE stall_profile SET stall_name = @stallName, stall_ownername = @ownerName, stall_ownerphoto = @ownerPhoto, stall_ownerbirthdate = @ownerBirthdate, stall_username = @username, stall_password = @password WHERE stall_username = @username", conn)

                cmd.Parameters.AddWithValue("@stallName", txtStallName.Text)
                cmd.Parameters.AddWithValue("@ownerName", txtStallOwnerName.Text)
                cmd.Parameters.AddWithValue("@ownerPhoto", acctImage.ImageLocation)
                cmd.Parameters.AddWithValue("@ownerBirthdate", dtpStallOwnerBirthdate.Value)
                cmd.Parameters.AddWithValue("@username", txtStallUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtStallPassword.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Edits saved successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the edits: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected account?", "Confirmation", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Dim cmd As New MySqlCommand("DELETE FROM stall_profile WHERE stall_username = @username", conn)

                cmd.Parameters.AddWithValue("@username", txtStallUsername.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Account deleted successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the account: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAcctImageImport_Click(sender As Object, e As EventArgs) Handles btnAcctImageImport.Click
        Try
            Dim openFileDialog As New OpenFileDialog()

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                acctImage.ImageLocation = openFileDialog.FileName
                acctImage.Image = Image.FromFile(openFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while importing the image: " & ex.Message)
        End Try
    End Sub

    Private Sub btnStallPasswordChange_Click(sender As Object, e As EventArgs) Handles btnStallPasswordChange.Click
        Try
            Dim currentPassword As String = InputBox("Enter the current password:")

            Dim cmd As New MySqlCommand("SELECT stall_password FROM stall_profile WHERE stall_username = @username", conn)
            cmd.Parameters.AddWithValue("@username", txtStallUsername.Text)

            conn.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                If reader("stall_password").ToString() = currentPassword Then
                    conn.Close()

                    Dim newPassword As String = InputBox("Enter the new password:")

                    cmd = New MySqlCommand("UPDATE stall_profile SET stall_password = @password WHERE stall_username = @username", conn)
                    cmd.Parameters.AddWithValue("@username", txtStallUsername.Text)
                    cmd.Parameters.AddWithValue("@password", newPassword)

                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Password changed successfully.")
                Else
                    MessageBox.Show("The password entered is incorrect.")
                End If
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while changing the password: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        Try
            If String.IsNullOrEmpty(txtStallName.Text) OrElse String.IsNullOrEmpty(txtStallOwnerName.Text) OrElse String.IsNullOrEmpty(acctImage.ImageLocation) OrElse String.IsNullOrEmpty(txtStallUsername.Text) OrElse String.IsNullOrEmpty(txtStallPassword.Text) Then
                MessageBox.Show("Please fill out all the necessary information.")
            Else
                conn.Open()

                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM stall_profile WHERE stall_name = @stallName", conn)
                cmd.Parameters.AddWithValue("@stallName", txtStallName.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Can't add account. An account with the same stall name already exists in the database.")
                    conn.Close()
                    Return
                End If

                cmd = New MySqlCommand("SELECT COUNT(*) FROM stall_profile WHERE stall_username = @username", conn)
                cmd.Parameters.AddWithValue("@username", txtStallUsername.Text)
                count = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Can't add account. An account with the same stall username already exists in the database.")
                    conn.Close()
                    Return
                End If

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new account?", "Confirmation", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    cmd = New MySqlCommand("INSERT INTO stall_profile (stall_name, stall_ownername, stall_ownerphoto, stall_ownerbirthdate, stall_username, stall_password) VALUES (@stallName, @ownerName, @ownerPhoto, @ownerBirthdate, @username, @password)", conn)
                    cmd.Parameters.AddWithValue("@stallName", txtStallName.Text)
                    cmd.Parameters.AddWithValue("@ownerName", txtStallOwnerName.Text)
                    cmd.Parameters.AddWithValue("@ownerPhoto", acctImage.ImageLocation)
                    cmd.Parameters.AddWithValue("@ownerBirthdate", dtpStallOwnerBirthdate.Value)
                    cmd.Parameters.AddWithValue("@username", txtStallUsername.Text)
                    cmd.Parameters.AddWithValue("@password", txtStallPassword.Text)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New account added successfully.")
                End If

                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the new account: " & ex.Message)
        End Try
    End Sub

    Private Sub AdminAccount_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Try
        'RefreshAccountList()
        'Catch ex As Exception
        'MessageBox.Show("An error occurred while refreshing the account list: " & ex.Message)
        'End Try
    End Sub

    Private Sub btnAdminChangePassword_Click(sender As Object, e As EventArgs) Handles btnAdminChangePassword.Click
        Try
            Dim currentPassword As String = InputBox("Enter the current password:")

            Dim cmd As New MySqlCommand("SELECT stall_password FROM stall_profile WHERE stall_username = 'admin'", conn)

            conn.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                If reader("stall_password").ToString() = currentPassword Then
                    conn.Close()

                    Dim newPassword As String = InputBox("Enter the new password:")

                    cmd = New MySqlCommand("UPDATE stall_profile SET stall_password = @password WHERE stall_username = 'admin'", conn)
                    cmd.Parameters.AddWithValue("@password", newPassword)

                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Password changed successfully.")
                Else
                    MessageBox.Show("The password entered is incorrect.")
                End If
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while changing the password: " & ex.Message)
        End Try
    End Sub

End Class