Imports System

Module Program
    Sub Main()
        'LUIS ALEJANDRO VASQUEZ GALVEZ // CALCULO DE FACTORIAL CON MULTIPLOS DE 4
        Dim num As Integer
        Dim i As Integer
        Dim y As Integer
        Dim cont As Integer = 0
        Console.Write("Ingrese el número que desea calcular: ")
        num = Integer.Parse(Console.ReadLine())
        If num >= 0 Then
            Console.WriteLine("{0}! = {1}", num, fact(num))
            Console.WriteLine("Multiplos de 4:")
            For i = 0 To fact(num) Step 1
                If i Mod 4 = 0 Then
                    Console.WriteLine(i)
                    cont = cont + 1
                End If
            Next
            Console.WriteLine("La cantidad de múltiplos de 4 es: " + cont.ToString())
            Console.Read()
        End If
        If num < 0 Then
            Console.WriteLine("El numero que ingresas es negativo, intenta nuevamente")
        End If

    End Sub



    Function fact(ByVal num) As Integer

        If num = 1 Then

            Return num

        Else

            Return num * fact(num - 1)

        End If

    End Function
End Module