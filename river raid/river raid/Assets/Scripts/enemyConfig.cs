using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "enemyConfig", menuName = "RiverRaidConfigs/EnemyConfig")]
public class enemyConfig : ScriptableObject
{
    public string enemyName;
    public int score;
}
