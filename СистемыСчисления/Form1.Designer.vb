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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRez = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRez2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTo2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.вход = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.основание1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.основание2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.рез = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Число (10)"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(94, 12)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        Me.txtNum.Text = "126"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(94, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Основание"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(94, 38)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(100, 20)
        Me.txtTo.TabIndex = 1
        Me.txtTo.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Результат"
        '
        'txtRez
        '
        Me.txtRez.Location = New System.Drawing.Point(94, 107)
        Me.txtRez.Name = "txtRez"
        Me.txtRez.Size = New System.Drawing.Size(100, 20)
        Me.txtRez.TabIndex = 1
        Me.txtRez.Text = "126"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Число (10)"
        '
        'txtRez2
        '
        Me.txtRez2.Location = New System.Drawing.Point(94, 191)
        Me.txtRez2.Name = "txtRez2"
        Me.txtRez2.Size = New System.Drawing.Size(100, 20)
        Me.txtRez2.TabIndex = 1
        Me.txtRez2.Text = "126"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Основание"
        '
        'txtTo2
        '
        Me.txtTo2.Location = New System.Drawing.Point(94, 133)
        Me.txtTo2.Name = "txtTo2"
        Me.txtTo2.Size = New System.Drawing.Size(100, 20)
        Me.txtTo2.TabIndex = 1
        Me.txtTo2.Text = "16"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Число"
        '
        'вход
        '
        Me.вход.Location = New System.Drawing.Point(376, 19)
        Me.вход.Name = "вход"
        Me.вход.Size = New System.Drawing.Size(80, 20)
        Me.вход.TabIndex = 5
        Me.вход.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(464, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "по основанию"
        '
        'основание1
        '
        Me.основание1.Location = New System.Drawing.Point(548, 19)
        Me.основание1.Name = "основание1"
        Me.основание1.Size = New System.Drawing.Size(80, 20)
        Me.основание1.TabIndex = 5
        Me.основание1.Text = "2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "переводим в число по основанию"
        '
        'основание2
        '
        Me.основание2.Location = New System.Drawing.Point(548, 55)
        Me.основание2.Name = "основание2"
        Me.основание2.Size = New System.Drawing.Size(80, 20)
        Me.основание2.TabIndex = 5
        Me.основание2.Text = "10"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(410, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 31)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'рез
        '
        Me.рез.Location = New System.Drawing.Point(414, 137)
        Me.рез.Name = "рез"
        Me.рез.Size = New System.Drawing.Size(185, 20)
        Me.рез.TabIndex = 5
        Me.рез.Text = "10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(349, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Результат"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 346)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.рез)
        Me.Controls.Add(Me.основание2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.основание1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.вход)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtRez)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTo2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtRez2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRez As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRez2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTo2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents вход As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents основание1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents основание2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents рез As TextBox
    Friend WithEvents Label9 As Label
End Class
