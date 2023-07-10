<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.TxTFechaActual = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbDatosPerfil = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.PbPaciente = New System.Windows.Forms.PictureBox()
        Me.lblCorreo = New System.Windows.Forms.GroupBox()
        Me.CbProvincia = New System.Windows.Forms.ComboBox()
        Me.RbFemenino = New System.Windows.Forms.RadioButton()
        Me.RbMasculino = New System.Windows.Forms.RadioButton()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblprovincia = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnResumir = New System.Windows.Forms.Button()
        Me.GbPadecimientos = New System.Windows.Forms.GroupBox()
        Me.txtOtra = New System.Windows.Forms.TextBox()
        Me.ChkHipertension = New System.Windows.Forms.CheckBox()
        Me.ChkInsuficiencia = New System.Windows.Forms.CheckBox()
        Me.ChkOtra = New System.Windows.Forms.CheckBox()
        Me.ChkDiabetes = New System.Windows.Forms.CheckBox()
        Me.lblEnfermedades = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbDatosPerfil.SuspendLayout()
        CType(Me.PbPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblCorreo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GbPadecimientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(402, 21)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(339, 29)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "INFORMACIÓN PERSONAL"
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = True
        Me.lblFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaActual.Location = New System.Drawing.Point(880, 25)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(139, 25)
        Me.lblFechaActual.TabIndex = 1
        Me.lblFechaActual.Text = "Fecha Actual"
        '
        'TxTFechaActual
        '
        Me.TxTFechaActual.Enabled = False
        Me.TxTFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTFechaActual.Location = New System.Drawing.Point(1025, 20)
        Me.TxTFechaActual.Name = "TxTFechaActual"
        Me.TxTFechaActual.Size = New System.Drawing.Size(162, 30)
        Me.TxTFechaActual.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(29, 67)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1138, 624)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbDatosPerfil)
        Me.TabPage1.Controls.Add(Me.lblCorreo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1130, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbDatosPerfil
        '
        Me.gbDatosPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbDatosPerfil.Controls.Add(Me.txtCorreo)
        Me.gbDatosPerfil.Controls.Add(Me.Label1)
        Me.gbDatosPerfil.Controls.Add(Me.DtFechaNacimiento)
        Me.gbDatosPerfil.Controls.Add(Me.lblFechaNacimiento)
        Me.gbDatosPerfil.Controls.Add(Me.PbPaciente)
        Me.gbDatosPerfil.Cursor = System.Windows.Forms.Cursors.Default
        Me.gbDatosPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosPerfil.Location = New System.Drawing.Point(612, 25)
        Me.gbDatosPerfil.Name = "gbDatosPerfil"
        Me.gbDatosPerfil.Size = New System.Drawing.Size(515, 561)
        Me.gbDatosPerfil.TabIndex = 2
        Me.gbDatosPerfil.TabStop = False
        Me.gbDatosPerfil.Text = "Datos del Perfil"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(15, 420)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(469, 26)
        Me.txtCorreo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Correo Electrónico"
        '
        'DtFechaNacimiento
        '
        Me.DtFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaNacimiento.Location = New System.Drawing.Point(15, 338)
        Me.DtFechaNacimiento.Name = "DtFechaNacimiento"
        Me.DtFechaNacimiento.Size = New System.Drawing.Size(200, 26)
        Me.DtFechaNacimiento.TabIndex = 2
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(11, 305)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(186, 20)
        Me.lblFechaNacimiento.TabIndex = 1
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'PbPaciente
        '
        Me.PbPaciente.BackgroundImage = Global.CitasMedicas.My.Resources.Resources.Paciente1
        Me.PbPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbPaciente.Location = New System.Drawing.Point(15, 35)
        Me.PbPaciente.Name = "PbPaciente"
        Me.PbPaciente.Size = New System.Drawing.Size(423, 262)
        Me.PbPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbPaciente.TabIndex = 0
        Me.PbPaciente.TabStop = False
        '
        'lblCorreo
        '
        Me.lblCorreo.Controls.Add(Me.CbProvincia)
        Me.lblCorreo.Controls.Add(Me.RbFemenino)
        Me.lblCorreo.Controls.Add(Me.RbMasculino)
        Me.lblCorreo.Controls.Add(Me.txtDireccion)
        Me.lblCorreo.Controls.Add(Me.txtSegundoApellido)
        Me.lblCorreo.Controls.Add(Me.txtPrimerApellido)
        Me.lblCorreo.Controls.Add(Me.txtNombre)
        Me.lblCorreo.Controls.Add(Me.lblprovincia)
        Me.lblCorreo.Controls.Add(Me.lblSexo)
        Me.lblCorreo.Controls.Add(Me.lblDireccion)
        Me.lblCorreo.Controls.Add(Me.lblSegundoApellido)
        Me.lblCorreo.Controls.Add(Me.lblPrimerApellido)
        Me.lblCorreo.Controls.Add(Me.lblNombre)
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(0, 25)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(606, 561)
        Me.lblCorreo.TabIndex = 1
        Me.lblCorreo.TabStop = False
        Me.lblCorreo.Text = "Información Personal"
        '
        'CbProvincia
        '
        Me.CbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProvincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Items.AddRange(New Object() {"San José", "Cartago", "Heredia", "Limón", "Alajuela", "Puntarenas", "Guanacaste"})
        Me.CbProvincia.Location = New System.Drawing.Point(200, 435)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(121, 28)
        Me.CbProvincia.TabIndex = 12
        '
        'RbFemenino
        '
        Me.RbFemenino.AutoSize = True
        Me.RbFemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbFemenino.Location = New System.Drawing.Point(200, 383)
        Me.RbFemenino.Name = "RbFemenino"
        Me.RbFemenino.Size = New System.Drawing.Size(103, 24)
        Me.RbFemenino.TabIndex = 11
        Me.RbFemenino.TabStop = True
        Me.RbFemenino.Text = "Femenino"
        Me.RbFemenino.UseVisualStyleBackColor = True
        '
        'RbMasculino
        '
        Me.RbMasculino.AutoSize = True
        Me.RbMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMasculino.Location = New System.Drawing.Point(200, 353)
        Me.RbMasculino.Name = "RbMasculino"
        Me.RbMasculino.Size = New System.Drawing.Size(106, 24)
        Me.RbMasculino.TabIndex = 10
        Me.RbMasculino.TabStop = True
        Me.RbMasculino.Text = "Masculino"
        Me.RbMasculino.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(200, 187)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(355, 138)
        Me.txtDireccion.TabIndex = 9
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(200, 135)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(377, 26)
        Me.txtSegundoApellido.TabIndex = 8
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(200, 82)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(377, 26)
        Me.txtPrimerApellido.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(200, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(377, 26)
        Me.txtNombre.TabIndex = 6
        '
        'lblprovincia
        '
        Me.lblprovincia.AutoSize = True
        Me.lblprovincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprovincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblprovincia.Location = New System.Drawing.Point(15, 435)
        Me.lblprovincia.Name = "lblprovincia"
        Me.lblprovincia.Size = New System.Drawing.Size(87, 20)
        Me.lblprovincia.TabIndex = 5
        Me.lblprovincia.Text = "Provincia"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSexo.Location = New System.Drawing.Point(15, 353)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(50, 20)
        Me.lblSexo.TabIndex = 4
        Me.lblSexo.Text = "Sexo"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(15, 193)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(90, 20)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Dirección"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSegundoApellido.Location = New System.Drawing.Point(15, 141)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(154, 20)
        Me.lblSegundoApellido.TabIndex = 2
        Me.lblSegundoApellido.Text = "Segundo Apellido"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(15, 88)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(138, 20)
        Me.lblPrimerApellido.TabIndex = 1
        Me.lblPrimerApellido.Text = "Primer Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(15, 35)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(74, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLimpiar)
        Me.TabPage2.Controls.Add(Me.btnSalir)
        Me.TabPage2.Controls.Add(Me.btnResumir)
        Me.TabPage2.Controls.Add(Me.GbPadecimientos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1130, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Adicionales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(798, 234)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(138, 34)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(798, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(138, 34)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnResumir
        '
        Me.btnResumir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumir.Location = New System.Drawing.Point(798, 173)
        Me.btnResumir.Name = "btnResumir"
        Me.btnResumir.Size = New System.Drawing.Size(138, 34)
        Me.btnResumir.TabIndex = 1
        Me.btnResumir.Text = "Resumir"
        Me.btnResumir.UseVisualStyleBackColor = True
        '
        'GbPadecimientos
        '
        Me.GbPadecimientos.Controls.Add(Me.txtOtra)
        Me.GbPadecimientos.Controls.Add(Me.ChkHipertension)
        Me.GbPadecimientos.Controls.Add(Me.ChkInsuficiencia)
        Me.GbPadecimientos.Controls.Add(Me.ChkOtra)
        Me.GbPadecimientos.Controls.Add(Me.ChkDiabetes)
        Me.GbPadecimientos.Controls.Add(Me.lblEnfermedades)
        Me.GbPadecimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPadecimientos.Location = New System.Drawing.Point(98, 56)
        Me.GbPadecimientos.Name = "GbPadecimientos"
        Me.GbPadecimientos.Size = New System.Drawing.Size(610, 524)
        Me.GbPadecimientos.TabIndex = 0
        Me.GbPadecimientos.TabStop = False
        Me.GbPadecimientos.Text = "Padecimientos"
        '
        'txtOtra
        '
        Me.txtOtra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtOtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtra.Location = New System.Drawing.Point(169, 304)
        Me.txtOtra.Multiline = True
        Me.txtOtra.Name = "txtOtra"
        Me.txtOtra.Size = New System.Drawing.Size(435, 122)
        Me.txtOtra.TabIndex = 5
        Me.txtOtra.Visible = False
        '
        'ChkHipertension
        '
        Me.ChkHipertension.AutoSize = True
        Me.ChkHipertension.Location = New System.Drawing.Point(89, 178)
        Me.ChkHipertension.Name = "ChkHipertension"
        Me.ChkHipertension.Size = New System.Drawing.Size(206, 24)
        Me.ChkHipertension.TabIndex = 4
        Me.ChkHipertension.Text = "Hipertensión Arterial"
        Me.ChkHipertension.UseVisualStyleBackColor = True
        '
        'ChkInsuficiencia
        '
        Me.ChkInsuficiencia.AutoSize = True
        Me.ChkInsuficiencia.Location = New System.Drawing.Point(89, 241)
        Me.ChkInsuficiencia.Name = "ChkInsuficiencia"
        Me.ChkInsuficiencia.Size = New System.Drawing.Size(218, 24)
        Me.ChkInsuficiencia.TabIndex = 3
        Me.ChkInsuficiencia.Text = "Insuficiencia Cardiaca"
        Me.ChkInsuficiencia.UseVisualStyleBackColor = True
        '
        'ChkOtra
        '
        Me.ChkOtra.AutoSize = True
        Me.ChkOtra.Location = New System.Drawing.Point(89, 306)
        Me.ChkOtra.Name = "ChkOtra"
        Me.ChkOtra.Size = New System.Drawing.Size(74, 24)
        Me.ChkOtra.TabIndex = 2
        Me.ChkOtra.Text = "Otra:"
        Me.ChkOtra.UseVisualStyleBackColor = True
        '
        'ChkDiabetes
        '
        Me.ChkDiabetes.AutoSize = True
        Me.ChkDiabetes.Location = New System.Drawing.Point(89, 117)
        Me.ChkDiabetes.Name = "ChkDiabetes"
        Me.ChkDiabetes.Size = New System.Drawing.Size(106, 24)
        Me.ChkDiabetes.TabIndex = 1
        Me.ChkDiabetes.Text = "Diabetes"
        Me.ChkDiabetes.UseVisualStyleBackColor = True
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.AutoSize = True
        Me.lblEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEnfermedades.Location = New System.Drawing.Point(85, 60)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(317, 24)
        Me.lblEnfermedades.TabIndex = 0
        Me.lblEnfermedades.Text = "Seleccione las(s) enfermedades:"
        '
        'FrmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1200, 703)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TxTFechaActual)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Principal"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbDatosPerfil.ResumeLayout(False)
        Me.gbDatosPerfil.PerformLayout()
        CType(Me.PbPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblCorreo.ResumeLayout(False)
        Me.lblCorreo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GbPadecimientos.ResumeLayout(False)
        Me.GbPadecimientos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gbDatosPerfil As GroupBox
    Friend WithEvents lblCorreo As GroupBox
    Friend WithEvents lblprovincia As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents lblPrimerApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents RbMasculino As RadioButton
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents RbFemenino As RadioButton
    Friend WithEvents CbProvincia As ComboBox
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents PbPaciente As PictureBox
    Friend WithEvents DtFechaNacimiento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents GbPadecimientos As GroupBox
    Friend WithEvents lblEnfermedades As Label
    Friend WithEvents ChkHipertension As CheckBox
    Friend WithEvents ChkInsuficiencia As CheckBox
    Friend WithEvents ChkOtra As CheckBox
    Friend WithEvents ChkDiabetes As CheckBox
    Friend WithEvents txtOtra As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnResumir As Button
    Friend WithEvents TxTFechaActual As TextBox
End Class
