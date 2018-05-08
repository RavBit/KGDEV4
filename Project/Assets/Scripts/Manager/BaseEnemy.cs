using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class BaseEnemy : BasePlayers
{
    #region Instance player
    private static BaseEnemy _instance;

    private BaseEnemy()
    {
        if (_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static BaseEnemy Instance {
        get {
            if (_instance == null)
            {
                new BaseEnemy();
            }
            return _instance;
        }

    }
    #endregion
}
