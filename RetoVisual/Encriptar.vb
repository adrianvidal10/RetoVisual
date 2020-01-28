﻿Imports System.Security.Cryptography
Imports System.Text
Module Encriptar

    Friend des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Friend hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Friend myKey As String = "MyKey2012" 'Clave secreta(puede alterarse)
    Friend Function Encriptar(ByVal texto As String) As String

        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function
    'Funcion para el Desencriptado de Cadenas de Texto
    Friend Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim aaa As String = Convert.ToBase64String(Convert.FromBase64String(texto))
            MsgBox(aaa)
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function

End Module

