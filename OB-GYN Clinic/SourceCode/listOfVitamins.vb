Module listOfVitamins
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
