namespace AsterSharp.FastAGI
{
    public interface IMappingStrategy
    {
        AGIScript DetermineScript(AGIRequest request);
        void Load();
    }
}