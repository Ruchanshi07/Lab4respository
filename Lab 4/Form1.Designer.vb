<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cbNew = New System.Windows.Forms.CheckBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.clmNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(23, 23)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(37, 13)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(23, 53)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(93, 26)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "Model:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(25, 82)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(25, 114)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price:"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(28, 146)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(32, 13)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New:"
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Mercedes-Benz", "Jeep", "Range Rover", "Bugatti", "Audi", "BMW", "Volkswagen", "Lamborgini", "Ferrari", "Hyundai", "Honda", "Chevrolet", "Ford"})
        Me.cmbMake.Location = New System.Drawing.Point(97, 21)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(111, 21)
        Me.cmbMake.TabIndex = 5
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(97, 50)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(111, 20)
        Me.txtModel.TabIndex = 6
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(97, 82)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(111, 21)
        Me.cmbYear.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(97, 114)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(111, 20)
        Me.txtPrice.TabIndex = 8
        '
        'cbNew
        '
        Me.cbNew.AutoSize = True
        Me.cbNew.Location = New System.Drawing.Point(100, 146)
        Me.cbNew.Name = "cbNew"
        Me.cbNew.Size = New System.Drawing.Size(15, 14)
        Me.cbNew.TabIndex = 9
        Me.cbNew.UseVisualStyleBackColor = True
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmNew, Me.clmID, Me.clmMake, Me.clmModel, Me.clmYear, Me.clmPrice})
        Me.lvwCars.Location = New System.Drawing.Point(13, 178)
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(416, 222)
        Me.lvwCars.TabIndex = 10
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'clmNew
        '
        Me.clmNew.Text = "New"
        '
        'clmID
        '
        Me.clmID.Text = "ID"
        '
        'clmMake
        '
        Me.clmMake.Text = "Make"
        '
        'clmModel
        '
        Me.clmModel.Text = "Model"
        '
        'clmYear
        '
        Me.clmYear.Text = "Year"
        '
        'clmPrice
        '
        Me.clmPrice.Text = "Price"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(15, 409)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(414, 81)
        Me.lblOutput.TabIndex = 11
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(161, 500)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(86, 29)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(253, 500)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 29)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(345, 500)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 29)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 539)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.cbNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Protected Friend WithEvents lblNew As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbNew As CheckBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents clmNew As ColumnHeader
    Friend WithEvents clmID As ColumnHeader
    Friend WithEvents clmMake As ColumnHeader
    Friend WithEvents clmModel As ColumnHeader
    Friend WithEvents clmYear As ColumnHeader
    Friend WithEvents clmPrice As ColumnHeader
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
