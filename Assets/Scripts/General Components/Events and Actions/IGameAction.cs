public interface IGameAction<T>
{
    int Priority { get; }
    void Execute(T arg);
}
