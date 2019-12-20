namespace model
{
    public interface IResource
    {
        string GetResourceName();
        string GetResourceDescription();
        long GetResourceAmount();
        bool IsEmpty();
        void IncreaseAmount(long diff);
        void DecreaseAmount(long diff);
    }
}