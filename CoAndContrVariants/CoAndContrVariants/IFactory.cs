namespace CoAndContrVariants;

interface IFactory<out T, in R>
{
    T GetInstance();

    string GetInfo(R obj);
}
