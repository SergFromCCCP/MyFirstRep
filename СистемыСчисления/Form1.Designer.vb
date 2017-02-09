<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.вход = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.рез = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numFrom = New System.Windows.Forms.NumericUpDown()
        Me.numTo = New System.Windows.Forms.NumericUpDown()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.numFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Число"
        '
        'вход
        '
        Me.вход.Location = New System.Drawing.Point(82, 6)
        Me.вход.Name = "вход"
        Me.вход.Size = New System.Drawing.Size(80, 20)
        Me.вход.TabIndex = 0
        Me.вход.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "по основанию"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "переводим в число по основанию"
        '
        'рез
        '
        Me.рез.Location = New System.Drawing.Point(105, 80)
        Me.рез.Name = "рез"
        Me.рез.ReadOnly = True
        Me.рез.Size = New System.Drawing.Size(185, 20)
        Me.рез.TabIndex = 5
        Me.рез.Text = "10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Результат"
        '
        'numFrom
        '
        Me.numFrom.Location = New System.Drawing.Point(254, 7)
        Me.numFrom.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.numFrom.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numFrom.Name = "numFrom"
        Me.numFrom.Size = New System.Drawing.Size(36, 20)
        Me.numFrom.TabIndex = 1
        Me.numFrom.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'numTo
        '
        Me.numTo.Location = New System.Drawing.Point(254, 43)
        Me.numTo.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.numTo.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numTo.Name = "numTo"
        Me.numTo.Size = New System.Drawing.Size(36, 20)
        Me.numTo.TabIndex = 2
        Me.numTo.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(114, 128)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Закрыть"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 165)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.numTo)
        Me.Controls.Add(Me.numFrom)
        Me.Controls.Add(Me.рез)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.вход)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.numFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents вход As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents рез As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents numFrom As NumericUpDown
    Friend WithEvents numTo As NumericUpDown
    Friend WithEvents btnClose As Button
End Class
