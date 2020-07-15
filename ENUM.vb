Module Module1
    'declaring ENUM 

    Enum season
        summer = 1
        winter = 2
        autumn = 5
        spring = 6

    End Enum

    Sub Main()
        'using enum

        Dim weather As season
        weather = season.summer
        Console.WriteLine("weather " & weather)
        Console.ReadKey()
    End Sub

End Module
