Imports MySql.Data.MySqlClient

Public Class productslist
    Dim productNumber As Integer = 1
    Dim currentStall As String
    Private isEditingProfile As Boolean
    Public Property currentStallAccount As String

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Me.Dispose()
        Home.Show()
    End Sub

    Private Sub btnInSummary_Click(sender As Object, e As EventArgs) Handles btnInSummary.Click
        Me.Hide()
        Me.Dispose()
        InSummary.Show()
    End Sub

    Private Sub btnSalesTrack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.Dispose()
        SalesT.Show()
    End Sub


    Private Sub RefreshProductInfo(productName As String)
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM products WHERE name = @name"
            cmd.Parameters.AddWithValue("@name", productName)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    producttName.Text = reader("name").ToString()
                    productPrice.Text = "₱" & Decimal.Parse(reader("price")).ToString("F2")
                    productID.Text = reader("product_key").ToString()
                    productType.Text = reader("type").ToString()
                    productQuantity.Text = If(reader("quantity") Is DBNull.Value OrElse reader("quantity") = 0, "Not applicable", reader("quantity").ToString())

                    ' Check if the expiry date is "1753-1-1"
                    Dim expiryDate As DateTime = Convert.ToDateTime(reader("expiry_date"))
                    If expiryDate.Date = New DateTime(1753, 1, 1) Then
                        productExpiry.Text = "Good for one day only"
                    Else
                        productExpiry.Text = expiryDate.ToString("MM/dd/yyyy")
                    End If

                    Dim imagePath As String = reader("image").ToString()
                    If System.IO.File.Exists(imagePath) Then
                        productImage.Image = Image.FromFile(imagePath)
                    Else
                        MessageBox.Show("   The image file could not be found.   ", "LNU IGP Trade Park SISMS v0.1")
                    End If
                Else
                    MessageBox.Show("   The selected product is not in the database.   ", "LNU IGP Trade Park SISMS v0.1")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
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

    Private Function GenerateProductKey() As String
        Dim key As String = prodExpDate.Value.ToString("MMyyyy") & productNumber.ToString("D3")
        productNumber += 1
        Return key
    End Function

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles prodImgImport.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            MessageBox.Show("   Image imported!   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("   Choose an image, and try again.   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If panList.Visible = True Then
            panList.Visible = False
            panAdd.Visible = True
            panDel.Visible = False
            panEdit.Visible = False
            btnAdd.FillColor = Color.FromArgb(20, 145, 80)
            btnAdd.ForeColor = Color.White
        Else
            panList.Visible = True
            panAdd.Visible = False
            panEdit.Visible = False
            panDel.Visible = False
            btnAdd.FillColor = Color.FromArgb(224, 224, 224)
            btnAdd.ForeColor = Color.FromArgb(20, 145, 80)
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If panList.Visible = True Then
            panList.Visible = False
            panAdd.Visible = False
            panDel.Visible = True
            panEdit.Visible = False
            btnDel.FillColor = Color.FromArgb(228, 50, 64)
            btnDel.ForeColor = Color.White
        Else
            panList.Visible = True
            panAdd.Visible = False
            panEdit.Visible = False
            panDel.Visible = False
            btnDel.FillColor = Color.FromArgb(224, 224, 224)
            btnDel.ForeColor = Color.FromArgb(228, 50, 64)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If panList.Visible = True Then
            panList.Visible = False
            panAdd.Visible = False
            panDel.Visible = False
            panEdit.Visible = True
            btnEdit.FillColor = Color.FromArgb(228, 160, 4)
            btnEdit.ForeColor = Color.White
        Else
            panList.Visible = True
            panAdd.Visible = False
            panEdit.Visible = False
            panDel.Visible = False
            btnEdit.FillColor = Color.FromArgb(224, 224, 224)
            btnEdit.ForeColor = Color.FromArgb(228, 160, 4)
        End If

        If panListlistboxProducts.SelectedItem Is Nothing Then
            MessageBox.Show("   Select a product from the list before trying to edit.   ", "LNU IGP Trade Park SISMS v0.1")
            Return
        End If

        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            Dim productName As String = panListlistboxProducts.SelectedItem.ToString()
            cmd.CommandText = "SELECT * FROM products WHERE name = @name"
            cmd.Parameters.AddWithValue("@name", productName)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    prodEditName.Text = reader("name").ToString()
                    prodEditType.SelectedItem = reader("type").ToString()
                    prodEditPrice.Text = reader("price").ToString()
                    prodEditQuantity.Text = reader("quantity").ToString()
                    prodEditExpDate.Value = Convert.ToDateTime(reader("expiry_date"))
                    ' prodEditImgImport.Image = Image.FromFile(reader("image").ToString())
                Else
                    MessageBox.Show("   The selected product is not in the database.   ", "LNU IGP Trade Park SISMS v0.1")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub prodSaveInfo_Click(sender As Object, e As EventArgs) Handles prodSaveInfo.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT MAX(product_number) FROM products"
            Dim result = cmd.ExecuteScalar()
            Dim productNumber As Integer = If(result Is DBNull.Value, 1, Convert.ToInt32(result))
            Dim prodKey As String = prodExpDate.Value.ToString("MMyyyy") & productNumber.ToString("D3")
            cmd.CommandText = "SELECT COUNT(*) FROM products WHERE name = @name"
            cmd.Parameters.AddWithValue("@name", prodName.Text)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("   This product already exists in the database. Please use the Edit feature instead.   ", "LNU IGP Trade Park SISMS v0.1")
                Return
            End If

            productNumber += 1
            prodKey = prodExpDate.Value.ToString("MMyyyy") & productNumber.ToString("D3")

            Dim expiryDate As String
            If checkboxOneDayOnly.Checked = False Then
                expiryDate = "1753-1-1"
            Else
                expiryDate = prodExpDate.Value.ToString("yyyy-MM-dd")
            End If

            cmd.CommandText = "INSERT INTO products (product_key, product_number, name, type, price, quantity, expiry_date, image, stall) VALUES (@prodKey, @productNumber, @name, @type, @price, @quantity, @expiry_date, @image, @stall)"
            cmd.Parameters.AddWithValue("@prodKey", prodKey)
            cmd.Parameters.AddWithValue("@productNumber", productNumber)
            cmd.Parameters.AddWithValue("@type", prodType.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@price", Decimal.Parse(prodPrice.Text))
            cmd.Parameters.AddWithValue("@quantity", If(String.IsNullOrEmpty(prodQuantity.Text), 0, Integer.Parse(prodQuantity.Text)))
            cmd.Parameters.AddWithValue("@expiry_date", expiryDate)
            cmd.Parameters.AddWithValue("@image", OpenFileDialog1.FileName)
            cmd.Parameters.AddWithValue("@stall", currentStallAccount) ' Use currentStallAccount instead of currentStall

            cmd.ExecuteNonQuery()

            MessageBox.Show("   Product added successfully!   ", "LNU IGP Trade Park SISMS v0.1")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub refresh_Click(sender As Object, e As EventArgs)
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT name FROM products"
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            panListlistboxProducts.Items.Clear()
            While reader.Read()
                panListlistboxProducts.Items.Add(reader("name").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub panDellistRefresh_Click(sender As Object, e As EventArgs) Handles panDellistRefresh.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT name FROM products"
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            panDelpanItems.Items.Clear()
            While reader.Read()
                panDelpanItems.Items.Add(reader("name").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub panListlistRefresh_Click(sender As Object, e As EventArgs) Handles panListlistRefresh.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT name FROM products WHERE stall = @stall"
            cmd.Parameters.AddWithValue("@stall", currentStallAccount)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            panListlistboxProducts.Items.Clear()

            While reader.Read()
                panListlistboxProducts.Items.Add(reader("name").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub productslist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDelfrompanDel_Click(sender As Object, e As EventArgs) Handles btnDelfrompanDel.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            Dim productName As String = panDelpanItems.SelectedItem.ToString()
            Dim result As DialogResult = MessageBox.Show("   Are you sure you want to delete " & productName & "?   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                cmd.CommandText = "DELETE FROM products WHERE name = @name"
                cmd.Parameters.AddWithValue("@name", productName)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("   Product deleted successfully!   ", "LNU IGP Trade Park SISMS v0.1")
                    panDelpanItems.Items.Remove(panDelpanItems.SelectedItem)
                Else
                    MessageBox.Show("An error occurred: The product could not be found.", "LNU IGP Trade Park SISMS v0.1")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("   An error occurred: " & ex.Message & "   ")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub prodEditSaveEdits_Click(sender As Object, e As EventArgs) Handles prodEditSaveEdits.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            Dim expiryDate As String
            If checkboxOneDayOnly.Checked Then
                expiryDate = "1753-1-1"
            Else
                expiryDate = prodEditExpDate.Value.ToString("yyyy-MM-dd")
            End If

            cmd.CommandText = "UPDATE products SET name = @name, type = @type, price = @price, quantity = @quantity, expiry_date = @expiry_date WHERE name = @oldName"
            cmd.Parameters.AddWithValue("@oldName", panListlistboxProducts.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@name", prodEditName.Text)
            cmd.Parameters.AddWithValue("@type", prodEditType.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@price", Decimal.Parse(prodEditPrice.Text))
            cmd.Parameters.AddWithValue("@quantity", Integer.Parse(prodEditQuantity.Text))
            cmd.Parameters.AddWithValue("@expiry_date", expiryDate)
            cmd.Parameters.AddWithValue("@image", OpenFileDialog1.FileName)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("   Product information updated successfully!   ", "LNU IGP Trade Park SISMS v0.1")
            Else
                MessageBox.Show("   An error occurred: The product could not be found.   ", "LNU IGP Trade Park SISMS v0.1")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub prodEditImgImport_Click(sender As Object, e As EventArgs) Handles prodEditImgImport.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            MessageBox.Show("   Image imported!   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("   Choose an image, and try again.   ", "LNU IGP Trade Park SISMS v0.1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnItemInfoRefresh_Click(sender As Object, e As EventArgs) Handles btnItemInfoRefresh.Click
        If panListlistboxProducts.SelectedItem IsNot Nothing Then
            RefreshProductInfo(panListlistboxProducts.SelectedItem.ToString())
        Else
            MessageBox.Show("   Select a product from the list before trying to refresh.   ", "LNU IGP Trade Park SISMS v0.1")
        End If
    End Sub

    Private Sub panListlistboxProducts_SelectedValueChanged(sender As Object, e As EventArgs) Handles panListlistboxProducts.SelectedValueChanged
        If panListlistboxProducts.SelectedItem IsNot Nothing Then
            RefreshProductInfo(panListlistboxProducts.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnAssignInvToDate_Click(sender As Object, e As EventArgs) Handles btnAssignInvToDate.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn

            cmd.CommandText = "SELECT COUNT(*) FROM inventory WHERE DATE(inventory_date) = @inventory_date"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@inventory_date", prodInventoryDate.Value.Date)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("   There's already an existing inventory assigned to the currently selected date. Consider clearing it instead.   ")
                Return
            End If

            For Each item As String In panListlistboxProducts.Items
                Dim productName As String = item.ToString()
                cmd.CommandText = "SELECT * FROM products WHERE name = @name"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@name", productName)

                Dim productType As String
                Dim productPrice As Decimal
                Dim productQuantity As Integer
                Dim productExpiryDate As Date
                Dim productImage As String

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        productType = reader("type").ToString()
                        productPrice = Decimal.Parse(reader("price").ToString())
                        productQuantity = Integer.Parse(reader("quantity").ToString())
                        productExpiryDate = Convert.ToDateTime(reader("expiry_date"))
                        productImage = reader("image").ToString()
                    End If
                End Using

                cmd.CommandText = "INSERT INTO inventory (inventory_date, product_name, product_type, product_price, product_quantity, product_expiry_date, product_image) VALUES (@inventory_date, @product_name, @product_type, @product_price, @product_quantity, @product_expiry_date, @product_image)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@inventory_date", prodInventoryDate.Value)
                cmd.Parameters.AddWithValue("@product_name", productName)
                cmd.Parameters.AddWithValue("@product_type", productType)
                cmd.Parameters.AddWithValue("@product_price", productPrice)
                cmd.Parameters.AddWithValue("@product_quantity", productQuantity)
                cmd.Parameters.AddWithValue("@product_expiry_date", productExpiryDate)
                cmd.Parameters.AddWithValue("@product_image", productImage)

                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Inventory assigned to selected date successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btnInventoryDateClear_Click(sender As Object, e As EventArgs) Handles btnInventoryDateClear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the inventory for the selected date?", "Clear Inventory", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
            Dim cmd As New MySqlCommand()

            Try
                conn.Open()
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM inventory WHERE inventory_date = @inventory_date"
                cmd.Parameters.AddWithValue("@inventory_date", prodInventoryDate.Value.Date)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Inventory for the selected date cleared successfully!")
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
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

    Private Sub productslist_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=1234;database=products")
        Dim cmd As New MySqlCommand()

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT name FROM products WHERE stall = @stall"
            cmd.Parameters.AddWithValue("@stall", currentStallAccount)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            panListlistboxProducts.Items.Clear()

            While reader.Read()
                panListlistboxProducts.Items.Add(reader("name").ToString())
            End While

            cmd.Parameters.Clear() ' Clear the parameters

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT name FROM products WHERE stall = @stall"
            cmd.Parameters.AddWithValue("@stall", currentStallAccount)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            panDelpanItems.Items.Clear()

            While reader.Read()
                panDelpanItems.Items.Add(reader("name").ToString())
            End While

            cmd.Parameters.Clear() ' Clear the parameters

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "LNU IGP Trade Park SISMS v0.1")
        Finally
            conn.Close()
        End Try

        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM stall_profile WHERE stall_username = @stall_username"
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

    Private Sub checkboxOneDayOnly_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxOneDayOnly.CheckedChanged
        If checkboxOneDayOnly.Checked = False Then
            btnItemMarkedGoodForADay.Visible = True
        ElseIf checkboxOneDayOnly.Checked = True Then
            btnItemMarkedGoodForADay.Visible = False
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxEditItemGoodForADay.CheckedChanged
        If checkboxEditItemGoodForADay.Checked = False Then
            btnEditItemGoodForADay.Visible = True
        ElseIf checkboxEditItemGoodForADay.Checked = True Then
            btnEditItemGoodForADay.Visible = False
        End If
    End Sub
End Class