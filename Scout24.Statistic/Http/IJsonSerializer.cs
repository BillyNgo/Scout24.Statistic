namespace Scout24.Statistic.Internal
{
    public interface IJsonSerializer
    {
        string Serialize(object item);
        T Deserialize<T>(string json);
    }
}
