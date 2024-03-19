namespace tds.util;

public interface IFactory<K, V>
{
    public V Get(K key);
}
