namespace ConsoleUI
{
    public interface ITemperature
    {
        void DisplayCalculations();
        void Insert(int temperature);
        void Insert(string temperature);
        void PrintAllTemperatures();
        void RunCalculations();
    }
}