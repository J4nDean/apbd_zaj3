namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        ContainerTests containerTests = new();
        containerTests.TestLiquidContainer();
        containerTests.TestGasContainer();
        containerTests.TestCoolerContainer();
        
        KontenerowiecTests kontenerowiecTests = new();
        kontenerowiecTests.TestObliczWageKontenerow();
        kontenerowiecTests.TestDodajKontener();
        kontenerowiecTests.TestUsunKontener();
        
    }
}