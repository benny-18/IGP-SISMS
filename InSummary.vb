Imports System.Drawing.Imaging
Imports System.IO
Imports Guna.UI2.WinForms
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient


Public Class InSummary
    Private totalItemsSold As Integer = 0
    Private isPanelDailyFullShown As Boolean = False
    Dim isEditingProfile As Boolean = False

    Private Sub btnSalesTrack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SalesT.Show()
    End Sub

    Private Sub btnProdList_Click(sender As Object, e As EventArgs) Handles btnProdList.Click
        Me.Hide()
        productslist.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim diagExit As DialogResult

        diagExit = MessageBox.Show("   Logout from current user?   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If diagExit = DialogResult.Yes Then
            Me.Hide()

            Login.uname.Text = ""
            Login.pword.Text = ""
            Login.Show()
        End If
    End Sub

    Public Sub btnincomeSummaryCalcEstimate_Click(sender As Object, e As EventArgs) Handles btnincomeSummaryCalcEstimate.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM inventory WHERE DATE(inventory_date) = @inventory_date"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@inventory_date", incomeSummaryDate.Value.Date)

            Dim totalSales As Decimal = 0
            totalItemsSold = 0
            Dim totalLosses As Decimal = 0
            Dim totalProductQuantity As Integer = 0
            Dim productCounts As New Dictionary(Of String, Integer)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' inputbox for number of purchased products hehe
                    Dim productQuantity As Integer = Integer.Parse(reader("product_quantity").ToString())
                    totalProductQuantity += productQuantity
                    Dim purchasedItems As Integer
                    If productQuantity > 0 Then
                        purchasedItems = Integer.Parse(InputBox("Enter the number of purchased items for " & reader("product_name").ToString() & " (Quantity available: " & productQuantity & ")"))
                    Else
                        purchasedItems = Integer.Parse(InputBox("Enter the number of purchased items for " & reader("product_name").ToString()))
                    End If

                    totalSales += Decimal.Parse(reader("product_price").ToString()) * purchasedItems
                    totalItemsSold += purchasedItems
                    totalLosses += Decimal.Parse(reader("product_price").ToString()) * (productQuantity - purchasedItems)

                    Dim productName As String = reader("product_name").ToString()
                    If productCounts.ContainsKey(productName) Then
                        productCounts(productName) += purchasedItems
                    Else
                        productCounts.Add(productName, purchasedItems)
                    End If
                End While
            End Using

            dailyTotalSales.Text = "₱" & totalSales.ToString("N2")
            dailyProductsSold.Text = totalItemsSold.ToString()
            dailyTotalLosses.Text = "₱" & totalLosses.ToString("N2")

            summaryDate.Text = incomeSummaryDate.Value.ToString("MM-dd-yyyy")

            totalNumberProductItems.Text = productCounts.Count.ToString() & " items"

            Dim leastPurchasedProduct As String = productCounts.OrderBy(Function(x) x.Value).First().Key
            Dim mostPurchasedProduct As String = productCounts.OrderByDescending(Function(x) x.Value).First().Key
            Me.leastPurchasedProduct.Text = leastPurchasedProduct
            Me.mostPurchasedProduct.Text = mostPurchasedProduct

            Me.totalProductQuantity.Text = totalProductQuantity.ToString() & " items"

            If totalProductQuantity <> 0 Then
                progressDailySum.Value = (totalItemsSold / totalProductQuantity) * 100
                percentageGreen.Value = (productCounts.Count / totalItemsSold) * 100
                percentageYellow.Value = (productCounts(leastPurchasedProduct) / totalItemsSold) * 100
                percentageRed.Value = (productCounts(mostPurchasedProduct) / totalItemsSold) * 100
            Else
                MessageBox.Show("   Total product quantity is zero. Cannot calculate progress.   ", "LNU IGP Trade Park SISMS v0.1")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles switchAssumeInvConsistency.CheckedChanged
        If switchAssumeInvConsistency.Checked Then
            panelDailyFull.Visible = False
            panelDailyTitle.TextAlign = HorizontalAlignment.Center
            panelDailyTitle.Text = "DAILY SUMMARY"
            Dim monthlyTotalSales As Decimal = Decimal.Parse(dailyTotalSales.Text.Replace("₱", "")) * 31
            Dim yearlyTotalSales As Decimal = Decimal.Parse(dailyTotalSales.Text.Replace("₱", "")) * 365
            Dim monthlyProductsSold As Integer = totalItemsSold * 31
            Dim yearlyProductsSold As Integer = totalItemsSold * 365
            Dim monthlyTotalLosses As Decimal = Decimal.Parse(dailyTotalLosses.Text.Replace("₱", "")) * 31
            Dim yearlyTotalLosses As Decimal = Decimal.Parse(dailyTotalLosses.Text.Replace("₱", "")) * 365

            Me.monthlyTotalSales.Text = "₱" & monthlyTotalSales.ToString("N2")
            Me.yearlyTotalSales.Text = "₱" & yearlyTotalSales.ToString("N2")
            Me.monthlyProductsSold.Text = monthlyProductsSold.ToString()
            Me.yearlyProductsSold.Text = yearlyProductsSold.ToString()
            Me.monthlyTotalLosses.Text = "₱" & monthlyTotalLosses.ToString("N2")
            Me.yearlyTotalLosses.Text = "₱" & yearlyTotalLosses.ToString("N2")

            If monthlyTotalSales > 0 Then
                Dim monthlyPerformance As Integer = monthlyTotalSales / (monthlyTotalSales + monthlyTotalLosses) * 100
                progressMonthlySum.Value = monthlyPerformance
            Else
                MessageBox.Show("   Monthly total sales is zero.   ", "LNU IGP Trade Park SISMS v0.1")
            End If

            If yearlyTotalSales > 0 Then
                Dim yearlyPerformance As Integer = yearlyTotalSales / (yearlyTotalSales + yearlyTotalLosses) * 100
                progressYearlySum.Value = yearlyPerformance
            Else
                MessageBox.Show("   Yearly total sales is zero.   ", "LNU IGP Trade Park SISMS v0.1")
            End If
        Else
            panelDailyFull.Visible = True
            panelDailyTitle.TextAlign = HorizontalAlignment.Left
            panelDailyTitle.Text = "    DAILY SUMMARY"
        End If

        'btnincomeSummaryCalcEstimate_Click(sender, e)
    End Sub

    Private Sub switchAssumeInvConsistency_Click(sender As Object, e As EventArgs) Handles switchAssumeInvConsistency.Click

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
                    stallOwnerPhoto.Image = System.Drawing.Image.FromFile(OpenFileDialog2.FileName)
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

    Private Sub InSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStallOwnerPhotoImport_Click(sender As Object, e As EventArgs) Handles btnStallOwnerPhotoImport.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            MessageBox.Show("   Image imported!   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("   Choose an image, and try again.   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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

    Private Sub InSummary_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
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
                    stallOwnerPhoto.Image = System.Drawing.Image.FromFile(reader("stall_ownerphoto").ToString())
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

    Private Sub btnPrintIncomeSummary_Click(sender As Object, e As EventArgs) Handles btnPrintIncomeSummary.Click
        Dim g As Graphics = Me.CreateGraphics()
        Dim bmp As New Bitmap(Me.Size.Width, Me.Size.Height + 10, g)
        Dim mg As Graphics = Graphics.FromImage(bmp)

        mg.CopyFromScreen(Me.Location.X + 20, Me.Location.Y + 25, 40, 47, Me.Size)
        Dim screenshotPath As String = Path.Combine(Application.StartupPath, "Screenshot.png")

        bmp.Save(screenshotPath, ImageFormat.Png)

        Process.Start(screenshotPath)
    End Sub

End Class