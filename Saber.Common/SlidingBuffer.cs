using System.Collections;

namespace Saber.Common;

public class SlidingBuffer<T>(int maxCount) : IEnumerable<T>
{
    private readonly Queue<T> _queue = new(maxCount);

    public void Add(T item)
    {
        if (_queue.Count == maxCount)
            _queue.Dequeue();
        _queue.Enqueue(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _queue.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
