Partial Public Class Vitamins
    Private Vitamins As List(Of String)

    Public Sub New()
    End Sub

    Private Sub New(ByVal vitamins As List(Of String))
        Me.Vitamins = vitamins

    End Sub

    Public Property Vitamins1 As List(Of String)
        Get
            Return Vitamins
        End Get
        Set(value As List(Of String))
            Vitamins = value
        End Set
    End Property

    Public Sub ConsultVitamins()
        'Dim FirstTriVitamins As List(Of String) = firstTrimesterVitamins.get
    End Sub

    Public Module listOfVitamins
        Sub Main()
            Dim firstTrimesterVitamins As New List(Of String) From {
            "Folic Acid (Folate)",
            "Iron",
            "Vitamin D",
            "Vitamin B12",
            "Zinc",
            "Vitamin B6",
            "Vitamin B9 (Folic Acid/Folate)",
            "Vitamin B3 (Niacin)",
            "Vitamin B7 (Biotin)",
            "Choline"
        }

            Dim secondTrimesterVitamins As New List(Of String) From {
            "Calcium",
            "Omega-3 Fatty Acids (DHA and EPA)",
            "Iodine",
            "Vitamin C",
            "Riboflavin (Vitamin B2)",
            "Thiamine (Vitamin B1)",
            "Vitamin E",
            "Magnesium",
            "Vitamin K"
        }

            Dim thirdTrimesterVitamins As New List(Of String) From {
            "Vitamin A",
            "Vitamin B5 (Pantothenic Acid)",
            "Copper",
            "Selenium",
            "Potassium",
            "Manganese",
            "Chromium",
            "Molybdenum",
            "Boron",
            "Vanadium",
            "Silicon",
            "Nickel",
            "Cobalt",
            "Germanium",
            "Arsenic ",
            "Lutein",
            "Zeaxanthin",
            "Astaxanthin"
        }

            ' Displaying the vitamins for each trimester
            Console.WriteLine("First Trimester Vitamins:")
            For Each vitamin In firstTrimesterVitamins
                Console.WriteLine("- " & vitamin)
            Next

            Console.WriteLine()

            Console.WriteLine("Second Trimester Vitamins:")
            For Each vitamin In secondTrimesterVitamins
                Console.WriteLine("- " & vitamin)
            Next

            Console.WriteLine()

            Console.WriteLine("Third Trimester Vitamins:")
            For Each vitamin In thirdTrimesterVitamins
                Console.WriteLine("- " & vitamin)
            Next

            Console.ReadLine() ' To keep the console window open
        End Sub
    End Module

End Class
