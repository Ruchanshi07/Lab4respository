
Option Strict On
'Name: Ruchanshi Desai'
'File: Lab4'
'Description: This form applicatiion describes about the details and maintainance of track of the car.'
'Reference: CustomerList(dc connect)'

Public Class frmCarInventory

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False

    ''' <summary>
    ''' btn enter will validate the data entered into the controls and once that data is validated 
    ''' a car object will create using the parameterized constructor.
    ''' ala  the entered data will abpove will come in the listview provided below after clicking on button enter.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim car As Cars
        Dim carItem As ListViewItem


        If IsValidInput() = True Then


            editMode = True


            lblOutput.Text = "It worked!"

            Dim carprice As Double
            Double.TryParse(txtPrice.Text.Trim, carprice)
            carprice = Math.Round(carprice, 2)
            Dim price As String = CStr(carprice)

            If currentCarIdentificationNumber.Trim.Length = 0 Then


                car = New Cars(cmbMake.Text, txtModel.Text, cmbYear.Text, txtPrice.Text, cbNew.Checked)


                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCarIdentificationNumber), Cars)


                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Price = txtPrice.Text
                car.Year = cmbYear.Text
                car.newStatus = cbNew.Checked
            End If

            lvwCars.Items.Clear()


            For Each carEntry As DictionaryEntry In carList


                carItem = New ListViewItem()


                car = CType(carEntry.Value, Cars)


                carItem.Checked = car.newStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add("$" + car.Price)



                lvwCars.Items.Add(carItem)

            Next carEntry




            Reset()

            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()


        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        cbNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lblOutput.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        If cmbMake.SelectedIndex = -1 Then

            outputMessage += "Please select the car's make." & vbCrLf


            returnValue = False

        End If

        If cmbYear.SelectedIndex = -1 Then

            outputMessage += "Please select the car's year." & vbCrLf


            returnValue = False

        End If


        If txtPrice.Text.Trim.Length = 0 Then


            outputMessage += "Please enter the car's Price." & vbCrLf

            returnValue = False

        End If


        If txtModel.Text.Trim.Length = 0 Then


            outputMessage += "Please enter the car's Model." & vbCrLf


            returnValue = False

        End If

        Dim price As Double

        If Not Double.TryParse(txtPrice.Text, price) Then
            outputMessage += "Please enter the car's price in numeric." & vbCrLf

            returnValue = False

        End If

        If price < 0 Then
            outputMessage += "Please enter the car's price greater than 0." & vbCrLf

            returnValue = False
        End If

        If returnValue = False Then


            lblOutput.Text = "ERRORS" & vbCrLf & outputMessage

        End If



        Return returnValue

    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Reset()

    End Sub



    Private Sub lvwCar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck


        If editMode = False Then


            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCar_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged


        Const identificationSubItemIndex As Integer = 1


        currentCarIdentificationNumber = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        Dim car As Cars = CType(carList.Item(currentCarIdentificationNumber), Cars)

        txtModel.Text = car.Model
        txtPrice.Text = car.Price
        cmbMake.Text = car.Make
        cmbYear.Text = car.Year
        cbNew.Checked = car.newStatus

        lblOutput.Text = car.GetSalutation()


    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
