using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCore.Topics;

namespace CSharpCore
{
    class Core
    {
        static void Main(string[] args)
        {
            /* Call Function ShowInfo */
            BasicTypes.ShowInfo();

            /* Nullable */
            // Nullable is a concept that allows value types such as int, double, bool, etc., to hold a null value.
            //BasicTypes.NullableExample();

            /* Var and Dynamic */
            /* var */
            // 'var' is a shorthand way to declare a variable where the compiler automatically infers the type from the assigned value.
            // 'var' can only be used when a variable is initialized at the time of declaration, as the compiler needs to infer the type.
            //BasicTypes.VarExample();

            /* 'dynamic' */
            // 'dynamic' allows you to declare a variable whose data type is determined at runtime instead of compile time.
            //BasicTypes.DynamicExample();

            /* Input data */
            //Methods.InputDataExample();

            /* Mathematics operators */
            // +, -, *, /, %, ++, --, Math.Sqrt(), Math.Pow()
            //Operators.MathematicsOperatorsExample();

            /* Comparision Operators */
            // >, >=, <, <=, ==, !=
            // Result: true or false
            //Operators.ComparisonOperatorsExample();

            /* Logical Operators */
            // && || !
            //Operators.LogicalOperatorsExample();

            /* Bitwise Logical Operators */
            // &, |, ^, ~, <<, >>
            //Operators.BitwiseLogicalOperatorsExample();

            /* if-else condition */
            //ControlFlow.IfElseConditionExample();

            /* Switch-case condition */
            //ControlFlow.SwitchCaseConditionExample();

            /* While loop */
            //ControlFlow.WhileLoopExample();

            /* Do-While loop */
            //ControlFlow.DoWhileLoopExample();

            /* Break condition */
            //ControlFlow.BreakConditionExample();

            /* Continue condition */
            //ControlFlow.ContinueConditionExample();

            /* Array 1D */
            //Arrays.Array1DimensionExample();

            /* Array 2D */
            //Arrays.Array2DimensionExample();

            /* Jagged Array */
            //Arrays.JaggedArrayExample();

            /* Array Class */
            //Arrays.ArrayClassExample();

            /* out and ref keyword */
            /* out keyword được sử dụng khi biến local không mang giá trị nào trước đó */
            /* out keyword được dùng cả ở phần đối số và phần tham số */
            //float a, b;
            //Methods.OutKeywordExample(out a, out b);
            //Console.WriteLine("After Input: a = " + a + ", b = " + b);

            /* ref keyword được sử dụng khi biến local đã mang giá trị trước đó */
            //Console.WriteLine("Before Swap: a = " + a + ", b = " + b);
            //Methods.RefKeywordExample(ref a, ref b);
            //Console.WriteLine("After Swap: a = " + a + ", b = " + b);

            /* params keyword dùng trong trường hợp truyền đi một danh sách dữ liệu cùng kiểu hoặc một mảng một chiều */
            /* sau đối số params không được có bất cứ tham số nào khác */
            //Methods.ParamExample();

            /* More Primitive Data Types */
            //BasicTypes.CharExample();
            //BasicTypes.StringExample();
            //BasicTypes.DecimalExample();

            /* Type Casting */
            //Methods.TypeCastingExample();

            /* Constants */
            //BasicTypes.ConstantsExample();

            /* Short Assignment Operators */
            //Operators.ShortAssignmentOperatorsExample();

            /* For Loop */
            //ControlFlow.ForLoopExample();

            /* More String Manipulation */
            //OOPBasics.MoreStringManipulationExample();

            /* More Math Class Examples */
            //OOPBasics.MoreMathExamples();

            /* Enum Example */
            //OOPBasics.EnumExample();

            /* Struct Example */
            //OOPBasics.StructExample();

            /* Namespace Explanation */
            //OOPBasics.ExplainNamespace();
        }
    }
}
