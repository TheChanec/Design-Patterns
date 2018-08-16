namespace Creational.Singleton.Example3
{
    interface IPerro
    {
        bool Equals(object obj);
        int GetHashCode();
        Perro GetInstancia();
        string ToString();
    }
}