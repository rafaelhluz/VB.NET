Imports _1___Primeiro_Projeto
Imports _2___Criando_Variáveis
Imports _3___Manipulando_Textos
Imports _4___Controle_de_Fluxo
Imports _5___Laços_de_Repetição

Public Class FrmPrincipal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub Btm01_Click(sender As Object, e As EventArgs) Handles Btm01.Click

        Dim f As New FrmPrincipal01
        f.ShowDialog()

    End Sub
    Private Sub Btm02_Click(sender As Object, e As EventArgs) Handles Btm02.Click

        Dim f As New FrmPrincipal02
        f.ShowDialog()

    End Sub
    Private Sub Btm03_Click(sender As Object, e As EventArgs) Handles Btm03.Click

        Dim f As New FrmPrincipal03
        f.ShowDialog()

    End Sub

    Private Sub Btm04_Click(sender As Object, e As EventArgs) Handles Btm04.Click

        Dim f As New Frm_Principal_04
        f.ShowDialog()

    End Sub
    Private Sub Btm05_Click(sender As Object, e As EventArgs) Handles Btm05.Click

        Dim f As New FrmPrincipal05
        f.ShowDialog()

    End Sub
End Class
