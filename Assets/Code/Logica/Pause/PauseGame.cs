using UnityEngine;

public static class PauseGame 
{
    public  static bool _isPause { get; private set; }

    public static void SetPause(bool ispause)
    {
        _isPause = ispause;
    }
    
}
