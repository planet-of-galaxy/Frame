using System;

/// <summary>
/// 不继承MonoBehaviour的单例类
/// 继承该单例类的类可以在其构造函数中进行初始化
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Singleton<T> : IResetable where T : Singleton<T>
{
    private static T _instance;
    // 声明锁对象
    protected readonly static object lockObj = new object();
    public static T Instance {
        get
        {
            // 双重锁判断 防止多线程访问生成多个实例
            if (_instance == null)
            {
                lock (lockObj) {
                    if (_instance == null)
                        _instance = Activator.CreateInstance(typeof(T), true) as T;
                }
            }
            return _instance;
        }
    }
    // 该属性用于判断单例类是否已经实例化
    public static bool isInstantiated { get => _instance != null; }
    protected Singleton() {}
    // 该接口用于重置单例类 过场景时会调用
    public abstract void Reset();
}
