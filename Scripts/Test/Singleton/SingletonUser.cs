using UnityEngine;

public class SingletonUser : Singleton<SingletonUser>
{
    // Remove the public constructor to avoid the access issue.  
    // Singleton pattern typically uses a protected or private constructor.  
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
