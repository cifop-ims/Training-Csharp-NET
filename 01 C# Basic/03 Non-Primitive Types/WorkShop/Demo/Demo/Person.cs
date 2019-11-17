namespace Demo
{
    public class Person
    {
        public int Age;
        public decimal salary;

        #region operator
        public static implicit operator decimal(Person p)
        {
            return p.salary;
        }
        public static explicit operator int(Person p)
        {
            return (int)p.salary;
        }
        #endregion
    }
}
