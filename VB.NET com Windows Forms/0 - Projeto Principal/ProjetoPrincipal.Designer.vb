<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Btm01 = New Button()
        Btm02 = New Button()
        Btm03 = New Button()
        Btm04 = New Button()
        Btm05 = New Button()
        LblSelProj = New Label()
        SuspendLayout()
        ' 
        ' Btm01
        ' 
        Btm01.Location = New Point(12, 27)
        Btm01.Name = "Btm01"
        Btm01.Size = New Size(314, 51)
        Btm01.TabIndex = 0
        Btm01.Text = "1 - Primeiro projeto"
        Btm01.UseVisualStyleBackColor = True
        ' 
        ' Btm02
        ' 
        Btm02.Location = New Point(12, 84)
        Btm02.Name = "Btm02"
        Btm02.Size = New Size(314, 51)
        Btm02.TabIndex = 1
        Btm02.Text = "2 - Criando variáveis"
        Btm02.UseVisualStyleBackColor = True
        ' 
        ' Btm03
        ' 
        Btm03.Location = New Point(12, 141)
        Btm03.Name = "Btm03"
        Btm03.Size = New Size(314, 51)
        Btm03.TabIndex = 2
        Btm03.Text = "3 - Manipulando textos"
        Btm03.UseVisualStyleBackColor = True
        ' 
        ' Btm04
        ' 
        Btm04.Location = New Point(12, 198)
        Btm04.Name = "Btm04"
        Btm04.Size = New Size(314, 51)
        Btm04.TabIndex = 3
        Btm04.Text = "4 - Controle de fluxo"
        Btm04.UseVisualStyleBackColor = True
        ' 
        ' Btm05
        ' 
        Btm05.Location = New Point(12, 255)
        Btm05.Name = "Btm05"
        Btm05.Size = New Size(314, 51)
        Btm05.TabIndex = 4
        Btm05.Text = "5 - Laços de repetição"
        Btm05.UseVisualStyleBackColor = True
        ' 
        ' LblSelProj
        ' 
        LblSelProj.AutoSize = True
        LblSelProj.Location = New Point(12, 9)
        LblSelProj.Name = "LblSelProj"
        LblSelProj.Size = New Size(171, 15)
        LblSelProj.TabIndex = 5
        LblSelProj.Text = "Selecio um dos projetos abaixo"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 366)
        Controls.Add(LblSelProj)
        Controls.Add(Btm05)
        Controls.Add(Btm04)
        Controls.Add(Btm03)
        Controls.Add(Btm02)
        Controls.Add(Btm01)
        Name = "FrmPrincipal"
        Text = "Projeto principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm01 As Button
    Friend WithEvents Btm02 As Button
    Friend WithEvents Btm03 As Button
    Friend WithEvents Btm04 As Button
    Friend WithEvents Btm05 As Button
    Friend WithEvents LblSelProj As Label

End Class
