namespace oop3Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01 Q1 a) What is the difference between Method Overloading and Method Overriding?
            // Method overloading changes in the parameters of the Method ( in the number of params , it's data type or its order , And it is a static polymorphism (compile time poly)
            // Method overriding used in inheritance between classes when a base class lets the derived one to change the Implementation of the method , And it is a Dynamic poly (Runtime poly)
            #endregion

            #region Part01 Q1 b)What is the difference between Static Binding and Dynamic Binding?
            // Static binding is performed By the compiler at the compile time and is decided by the Refrence type 
            // Dynamic Binding is performed By the CLR at the Runtime and is decided by the Actual object in Memory 
            #endregion

            #region Part01 Q2 a)What is the purpose of the sealed keyword when applied to a class?
            // It ensures That the inheritance Chain stops at this class and no any class can inherit from it so no more extending from this class
            #endregion

            #region Part01 Q2 b) What is the difference between a sealed class and a sealed method?
            // Sealed class can not be inherited from it and the Sealed keyword is applied on the whole class
            // Sealed Method can not be overriden 
            #endregion

            #region Part01 Q2 c) Can a sealed method be overridden? Why?
            // No , Because the Sealed keyword prevents any class from overriding the sealed Method
            #endregion
        }
    }
}
