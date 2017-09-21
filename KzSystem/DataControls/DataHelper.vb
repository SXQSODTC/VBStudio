Imports System.Numerics

Public Structure KzData
    ''' <summary>
    ''' Boolean : True 或 False
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property BooleanType As Type = GetType(Boolean)
    ''' <summary>
    ''' Byte : 1 个字节，0 到 255（无符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property ByteType As Type = GetType(Byte)
    ''' <summary>
    ''' Char : 2 个字节，0 到 65,535（无符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property CharType As Type = GetType(Char)
    ''' <summary>
    ''' DateTime : 8 个字节，0001 年 1 月 1 日午夜 0:00:00 到 9999 年 12 月 31 日晚上 11:59:59 。
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property DateTimeType As Type = GetType(Date)
    ''' <summary>
    ''' Decimal : 16 个字节，0 到 +/-79,228,162,514,264,337,593,543,950,335 (+/-7.9...E+28) ，
    ''' 不包含小数点；0 到 +/-7.9228162514264337593543950335，包含小数点右边 28 位。
    ''' 最小非零数为 +/-0.0000000000000000000000000001 (+/-1E-28) 。
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property DecimalType As Type = GetType(Decimal)
    ''' <summary>
    ''' Double : 8 个字节，对于负值，为 -1.79769313486231570E+308 到 -4.94065645841246544E-324 。
    ''' 对于正值，为 4.94065645841246544E-324 到 1.79769313486231570E+308 。
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property DoubleType As Type = GetType(Double)
    ''' <summary>
    ''' Int32 : 4 个字节，-2,147,483,648 到 2,147,483,647（有符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property IntegerType As Type = GetType(Integer)
    ''' <summary>
    ''' Int64 : 8 个字节，（有符号）-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807 (9.2...E+18)
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property LongType As Type = GetType(Long)
    ''' <summary>
    ''' Object（类） : 4 个字节（32 位平台上） or 8 个字节（64 位平台上），
    ''' 任何类型都可以存储在 Object 类型的变量中
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property ObjectType As Type = GetType(Object)
    ''' <summary>
    ''' SByte : 1 个字节，-128 到 127（有符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property SByteType As Type = GetType(SByte)
    ''' <summary>
    ''' Int16 : 2 个字节，-32,768 到 32,767（有符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property ShortType As Type = GetType(Short)
    ''' <summary>
    ''' Single : 4 个字节，对于负值，为 -3.4028235E+38 到 -1.401298E-45 。
    ''' 对于正值，为 1.401298E-45 到 3.4028235E+38 。
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property SingleType As Type = GetType(Single)
    ''' <summary>
    ''' String（类） : 取决于实现平台，0 到大约 20 亿个 Unicode 字符
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property StringType As Type = GetType(String)
    ''' <summary>
    ''' UInt32 : 4 个字节，0 到 4,294,967,295（无符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property UIntegerType As Type = GetType(UInteger)
    ''' <summary>
    ''' UInt64 : 8 个字节，0 到 18,446,744,073,709,551,615 (1.8...E+19)（无符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property ULongType As Type = GetType(ULong)
    ''' <summary>
    ''' UInt16 : 2 个字节，0 到 65,535（无符号）
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property UShortType As Type = GetType(UShort)
    ''' <summary>
    ''' 表示任意大的带符号整数。这是支持任意大整数的非基元整型类型。
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property BigIntegerType As Type = GetType(BigInteger)

    Public Enum NumericRelationship As Integer
        GreaterThan = 1
        EqualTo = 0
        LessThan = -1
    End Enum

    Public Shared Function Compare(value1 As ValueType, value2 As ValueType) As NumericRelationship
        If Not IsNumeric(value1) Then
            Throw New ArgumentException("value1 is not a number.")
        ElseIf Not IsNumeric(value2) Then
            Throw New ArgumentException("value2 is not a number.")
        Else
            ' Use BigInteger as common integral type
            If IsInteger(value1) And IsInteger(value2) Then
                Dim bigint1 As BigInteger = CType(value1, BigInteger)
                Dim bigInt2 As BigInteger = CType(value2, BigInteger)
                Return CType(BigInteger.Compare(bigint1, bigInt2), NumericRelationship)
                ' At least one value is floating point; use Double.
            Else
                Dim dbl1, dbl2 As Double
                Try
                    dbl1 = CDbl(value1)
                Catch e As OverflowException
                    Console.WriteLine("value1 is outside the range of a Double.")
                End Try

                Try
                    dbl2 = CDbl(value2)
                Catch e As OverflowException
                    Console.WriteLine("value2 is outside the range of a Double.")
                End Try

                Return CType(dbl1.CompareTo(dbl2), NumericRelationship)
            End If
        End If
    End Function

    Public Shared Function IsInteger(value As ValueType) As Boolean
        Return (TypeOf value Is SByte Or
            TypeOf value Is Int16 Or
            TypeOf value Is Int32 Or
            TypeOf value Is Int64 Or
            TypeOf value Is Byte Or
            TypeOf value Is UInt16 Or
            TypeOf value Is UInt32 Or
            TypeOf value Is UInt64 Or
            TypeOf value Is BigInteger)
    End Function

    Public Shared Function IsFloat(value As ValueType) As Boolean
        Return (TypeOf value Is Single Or
            TypeOf value Is Double Or
            TypeOf value Is Decimal)
    End Function

    Public Shared Function IsNumeric(value As ValueType) As Boolean
        If Not (TypeOf value Is Byte OrElse
         TypeOf value Is Int16 OrElse
         TypeOf value Is Int32 OrElse
         TypeOf value Is Int64 OrElse
         TypeOf value Is SByte OrElse
         TypeOf value Is UInt16 OrElse
         TypeOf value Is UInt32 OrElse
         TypeOf value Is UInt64 OrElse
         TypeOf value Is BigInteger OrElse
         TypeOf value Is Decimal OrElse
         TypeOf value Is Double OrElse
         TypeOf value Is Single) Then
            Return False
        Else
            Return True
        End If
    End Function

End Structure

'Public Enum KzBasicType
'    AskType
'    BooleanType
'    ByteType
'    CharType
'    DateTimeType
'    DecimalType
'    DoubleType
'    IntegerType
'    LongType
'    SByteType
'    ShortType
'    SingleType
'    StringType
'    UIntegerType
'    ULongType
'    UShortType
'    VariantType
'End Enum