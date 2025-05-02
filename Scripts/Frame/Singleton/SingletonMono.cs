using UnityEngine;

/// <summary>
/// 不继承MonoBehaviour的单例类
/// 子类可以在Awake中进行初始化
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class SingletonMono<T> : MonoBehaviour, IResetable where T : SingletonMono<T>
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // 尝试在场景中找到现有实例
                _instance = FindObjectOfType<T>();

                if (_instance == null)
                {
                    // 创建新的 GameObject 并添加组件
                    GameObject go = new GameObject(typeof(T).Name);
                    _instance = go.AddComponent<T>();
                    DontDestroyOnLoad(go); // 确保跨场景不被销毁
                }
            }
            return _instance;
        }
    }

    public static bool isInstantiated { get => _instance != null; }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = (T)this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // 防止多个实例
        }
    }
    protected virtual void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }
    // 该接口用于重置单例类 过场景时会调用
    public abstract void Reset();
}
