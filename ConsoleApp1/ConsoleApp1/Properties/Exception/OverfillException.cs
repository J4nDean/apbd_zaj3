namespace ConsoleApp1.Exceptions
{
    public class OverfillException : Exception
    {
        public OverfillException(string NumerSeryjny) :
            base(String.Format("Masa ladunku w kontenerze o numerze seryjnym {0} przekroczyla maksymalna mase ladunku", NumerSeryjny))
        {
        }
    }
}



