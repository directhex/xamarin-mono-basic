Class Nullable2
    Function Compare() As Boolean
        Dim a As nullable(Of Date)
        Dim b As nullable(Of Date)
        Return Nullable.Compare(a, b)
    End Function
    Sub Conversions1()
        Dim bo As Boolean = CBool(New nullable(Of Boolean)(False))
        Dim b As Byte = CByte(New Byte?(1))
        Dim sb As SByte = CSByte(New SByte?(2))
        Dim s As Short = CShort(New Short?(2))
        Dim us As UShort = CUShort(New UShort?(3))
        Dim i As Integer = CInt(New Integer?(1))
        Dim ui As UInteger = CUInt(New UInteger?(2))
        Dim l As Long = CLng(New Long?(4))
        Dim ul As ULong = CULng(New ULong?(6))
        Dim f As Single = CSng(New Single?(5))
        Dim r As Double = CDbl(New Double?(1))
        Dim dec As Decimal = CDec(New Decimal?(2))
        Dim dt As Date = CDate(New nullable(Of Date)(Date.minvalue))
        Dim c As Char = CChar(New Char?("a"c))
    End Sub
    Sub Conversions2()
        Dim bo As Boolean = CType(New nullable(Of Boolean)(False), Boolean)
        Dim b As Byte = CType(New Byte?(1), Byte)
        Dim sb As SByte = CType(New SByte?(2), SByte)
        Dim s As Short = CType(New Short?(2), Short)
        Dim us As UShort = CType(New UShort?(3), UShort)
        Dim i As Integer = CType(New Integer?(1), Integer)
        Dim ui As UInteger = CType(New UInteger?(2), UInteger)
        Dim l As Long = CType(New Long?(4), Long)
        Dim ul As ULong = CType(New ULong?(6), ULong)
        Dim f As Single = CType(New Single?(5), Single)
        Dim r As Double = CType(New Double?(1), Double)
        Dim dec As Decimal = CType(New Decimal?(2), Decimal)
        Dim dt As Date = CType(New nullable(Of Date)(Date.minvalue), Date)
        Dim c As Char = CType(New Char?("a"c), Char)
        Dim tc As TypeCode = CType(New typecode?(TypeCode.Int32), TypeCode)
    End Sub
End Class