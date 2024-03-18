namespace tds.util;

public interface IStateMachine<T>
{
    public void ChangeState(T state);
}
