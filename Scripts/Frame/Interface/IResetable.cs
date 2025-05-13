// 用于重置对象的接口
// 它与IDestroyable的区别在于 它不会销毁实例 只是重置了其管理的内容
public interface IResetable
{
    void Reset();
}
