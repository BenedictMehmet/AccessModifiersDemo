namespace AccessModifiersDemo
{
    public class DerivedClass : ProtectedBase
    {
        public void UseProtectedMethod()
        {
            ShowProtectedMessage();
        }
    }
}
