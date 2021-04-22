Option Strict On

Imports System.Runtime.InteropServices
Public Class Form1

    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

   <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub
End Class
