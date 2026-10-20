using System.Security.Cryptography.X509Certificates;

namespace c____Advanced__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 04
            // Q4: What is a generic method? Write Swap<T> method.

            // A generic method is a method that is declared with type parameters, allowing it to work with any data type while maintaining type safety and performance (avoiding boxing/unboxing for value types).

            Public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
            #endregion
        }
    }
}
