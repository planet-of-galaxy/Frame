using UnityEngine;

public class SingletonUser : Singleton<SingletonUser>
{
    // 当需要进行初始化时 在构造函数中进行初始化并调用base
    protected SingletonUser() : base()
    {
        Debug.Log("Child Constructor");
    }

    public override void Reset()
    {

    }

    public void Test()
    {
        Debug.Log("Test");
    }
}
