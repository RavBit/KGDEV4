using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class BasePlayer : BasePlayers
{
    #region Instance player
    private static BasePlayer _instance;

    private BasePlayer()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static BasePlayer Instance {
        get {
            if (_instance == null)
            {
                new BasePlayer();
            }
            return _instance;
        }

    }
    #endregion

    public override void Test()
    {
        //DEBUG PURPOSE ONLY
        UnityEngine.Debug.Log("Kanonskogel23");
    }
}
