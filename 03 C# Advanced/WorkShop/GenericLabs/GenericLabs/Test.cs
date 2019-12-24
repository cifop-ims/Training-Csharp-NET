using System;
namespace GenericLabs
{
    public class Test<T> where T : Person, new()
    {
        T _value;
        public Test(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }
        public void Write()
        {
            var e = new T();
            Console.WriteLine(this._value);
        }
    }
}
