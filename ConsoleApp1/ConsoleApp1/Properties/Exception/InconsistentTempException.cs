namespace ConsoleApp1.Exceptions
{
    public class InconsistentTempException : Exception
    {
        public InconsistentTempException(string NumerSeryjny, double temperaturaProduktu, double Temperatura) :
            base(String.Format("Temperatura w kontenerze o numerze seryjnym {0} jest niezgodna z wymaganiami. Temperatura produktu {1}°C nie jest zgodna z temperaturą kontenera {2}°C.", NumerSeryjny, temperaturaProduktu, Temperatura))
        {

        }
    }
}