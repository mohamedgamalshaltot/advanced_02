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

            /*  Public static void Swap<T>(ref T a, ref T b)
              {
                  T temp = a;
                  a = b;
                  b = temp;
              }
            */
            #endregion
            #region Q 05
            // Q5: Write a generic method FindMax<T> that finds maximum value
            /*
             public static T FindMax<T>(T a, T b) where T : IComparable<T>
             {
                 return a.CompareTo(b) > 0 ? a : b;
             }
            */
            #endregion
            #region Q 06
            //Q6: What is a generic interface? Write IRepository<T>. 
            //A generic interface is an interface that is defined with type parameters, allowing it to be implemented by classes that can work with different data types while maintaining type safety.
            /* public interface IRepository<T>
            {
                void Add(T item);
                void Remove(T item);
                T GetById(int id);
                IEnumerable<T> GetAll();
            }*/
            #endregion
            #region Q 07
            // Q7: What is the 'struct' constraint? Write an example.
            // The 'struct' constraint in C# is used in generic type definitions to specify that the type parameter must be a value type (i.e., a struct). This means that the type argument provided must be a non-nullable value type, such as int, double, or a user-defined struct.
            /* public class Example<T> where T : struct
             {
                 public T Value { get; set; }
             }*/
            #endregion
            #region Q 08
            // Q8: What is the 'class' constraint? Write an example.
            // The 'class' constraint in C# is used in generic type definitions to specify that the type parameter must be a reference type (i.e., a class). This means that the type argument provided must be a class or an interface, allowing for null values and reference semantics.
            /* public class Example<T> where T : class
             {
                 public T Value { get; set; }
             }*/

            #endregion
            #region Q 09
            // Q9: What is the 'new()' constraint? Write an example.
            // The 'new()' constraint in C# is used in generic type definitions to specify that the type parameter must have a parameterless constructor. This means that the type argument provided must be a class or struct that has a public parameterless constructor.
            /* public class Example<T> where T : new()
             {
                 public T Value { get; set; }
             }*/
            #endregion
            #region Q 10
            //Q10:  What is the interface constraint? Write an example.
            // The interface constraint in C# is used in generic type definitions to specify that the type parameter must implement a specific interface. This allows the generic method or class to call methods defined in that interface on the type parameter.
            /* public class Example<T> where T : IDisposable
            {
                public void DisposeItem(T item)
                {
                    item.Dispose();
                }
            }*/
            #endregion
            #region Q 11
            // Q11: What is the base class constraint? Write an example.
            // The base class constraint in C# is used in generic type definitions to specify that the type parameter must inherit from a specific base class. This allows the generic method or class to access members of the base class on the type parameter.
            /* public class Example<T> where T : BaseClass
             {
                 public void CallBaseMethod(T item)
                 {
                     item.BaseMethod();
                 }
             }*/
            #endregion
            #region Q 12
            // Q12: How do you apply multiple constraints? Write an example. 
            // In C#, you can apply multiple constraints to a generic type parameter by separating them with commas. This allows you to specify that the type parameter must satisfy multiple conditions, such as being a reference type, implementing an interface, and having a parameterless constructor.
            /* public class Example<T> where T : class, IDisposable, new()
             {
                 public void CreateAndDispose()
                 {
                     T item = new T();
                     item.Dispose();
                 }
             }*/
            #endregion
            #region Q 13
            // Q13: What does the 'default' keyword do in generics?
            // The 'default' keyword in generics is used to obtain the default value of a type parameter. For reference types, it returns null, and for value types, it returns the zero-initialized value (e.g., 0 for int, false for bool). This is useful when you want to initialize a variable of a generic type without knowing its specific type at compile time.

            #endregion


        }
    }
}
