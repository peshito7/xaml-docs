Public Class Default_Vb


' #region raddataform-autogenerated-fields_1
Private Sub DataForm1_AutoGeneratingField(sender As Object, e As Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs)
 Dim employee = TryCast(Me.DataForm1.CurrentItem, Employee)
 If e.PropertyName = "FirstName" Then
  e.DataField.Label = "First Name"
 End If
 If e.PropertyName = "Salary" Then
  e.DataField.Description = "This is the initial salary!"
 End If
 If employee.Gender = Gender.Female Then
  e.DataField.Foreground = New SolidColorBrush(Colors.Purple)
 Else
  e.DataField.Foreground = New SolidColorBrush(Colors.Blue)
 End If
End Sub
' #endregion
End Class
