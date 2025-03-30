namespace Saber.Common;

public class ThrottledCall(int delayMilliseconds)
{
    private CancellationTokenSource _cts = new CancellationTokenSource();
    private readonly Lock _lock = new Lock();

    public async Task Run(Action action)
    {
        lock (_lock)
        {
            // Cancel any existing task
            _cts.Cancel();
            _cts.Dispose();
            _cts = new CancellationTokenSource();
        }

        try
        {
            await Task.Delay(delayMilliseconds, _cts.Token);
            
            if (!_cts.Token.IsCancellationRequested)
            {
                action();
            }
        } catch (TaskCanceledException)
        {
            // Task was canceled, do nothing
        }
    }
}