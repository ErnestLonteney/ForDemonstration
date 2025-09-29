namespace InterfaceExample
{
    interface IAdditionalFunctionallity
    {
        void Run();

        void Sleep();

        void Greet(string name);

        string Name { get; }   
    }
}
