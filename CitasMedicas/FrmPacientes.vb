Public Class FrmPacientes

    'Se declaran variables globales para mostrar el tipo de sexo, la provincia y la enfermedad'

    Dim TipoSexo As String = ""
    Dim provincia As String = ""
    Dim diabetes As String = ""
    Dim hipertension As String = ""
    Dim insuficiencia As String = ""
    Dim otra As String = ""

    Private Sub FrmPacientes_load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxTFechaActual.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub RbMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles RbMasculino.CheckedChanged
        If RbMasculino.Checked = True Then
            TipoSexo = "Masculino"
        End If
    End Sub

    Private Sub RbFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles RbFemenino.CheckedChanged
        If RbFemenino.Checked Then
            TipoSexo = "Femenino"
        End If
    End Sub

    Private Sub CbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProvincia.SelectedIndexChanged
        If (CbProvincia.SelectedIndex <> -1) Then
            provincia = CbProvincia.Text
        End If
    End Sub

    Private Sub ChkDiabetes_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDiabetes.CheckedChanged
        If ChkDiabetes.Checked = True Then
            diabetes = "Diabetes"
        End If
    End Sub

    Private Sub ChkHipertension_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHipertension.CheckedChanged
        If ChkHipertension.Checked = True Then
            hipertension = "Hipertensión Arterial"
        End If
    End Sub

    Private Sub ChkInsuficiencia_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInsuficiencia.CheckedChanged
        If ChkInsuficiencia.Checked = True Then
            insuficiencia = "Insuficiencia Cardiaca"
        End If
    End Sub

    Private Sub ChkOtra_CheckedChanged(sender As Object, e As EventArgs) Handles ChkOtra.CheckedChanged
        If ChkOtra.Checked = True Then
            txtOtra.Visible = True
        Else
            txtOtra.Visible = False
            txtOtra.Text = ""
        End If
    End Sub

    Private Sub btnResumir_Click(sender As Object, e As EventArgs) Handles btnResumir.Click

        'Se declartan las variables para obtener los datos de los textbox para luego mostrarlos en un mensaje'

        Dim mensaje1 As String = "El Paciente " + txtNombre.Text + " " + txtPrimerApellido.Text + " " + txtSegundoApellido.Text + " " + Chr(13) + "Vive en " + txtDireccion.Text + Chr(13)
        Dim mensaje2 As String = "Nació el: " + DtFechaNacimiento.Text + " -Su Sexo es :" + TipoSexo + " -Correo Electrónico " + txtCorreo.Text + Chr(13)
        Dim mensaje3 As String = "Provincia: " + provincia + Chr(13)
        Dim mensaje4 As String = "Enfermedades: " + diabetes + "- " + hipertension + "- " + insuficiencia + "- " + txtOtra.Text

        'Se declara una variable para mostrar en pantalla el resultado final'

        Dim Resultado As DialogResult

        'Muestra una ventana con el resumen de los datos'

        Resultado = MessageBox.Show(mensaje1 + mensaje2 + mensaje3 + mensaje4 + " ", "Información General-Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Muestra un mensaje donde se pregunta si desea abandonar el programa, si ó no'

        If MessageBox.Show("Está seguro que desea abandonar el Módulo Pacientes?", "Citas Médicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        txtDireccion.Text = ""
        txtCorreo.Text = ""
        RbMasculino.Checked = False
        RbFemenino.Checked = False
        CbProvincia.SelectedIndex = -1
        DtFechaNacimiento.Text = DateTime.Now.ToShortDateString()
        ChkDiabetes.Checked = False
        ChkHipertension.Checked = False
        ChkInsuficiencia.Checked = False
        ChkOtra.Checked = False
        txtOtra.Text = ""
        TipoSexo = ""
        provincia = ""
        diabetes = ""
        hipertension = ""
        insuficiencia = ""
        otra = ""


    End Sub

End Class
