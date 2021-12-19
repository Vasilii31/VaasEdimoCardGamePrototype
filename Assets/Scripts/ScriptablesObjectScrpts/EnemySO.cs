using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Assets/Enemy")]
public class EnemySO : ScriptableObject
{
    public int id;
    public string enemyName;
    public int hp;
    public int lvl;
    public int power;
    public string enemyDescription;

    public List<Ability> onPlayAbilities;
    public List<Ability> onDeathAbilities;
    public List<Ability> onKillAbilities;
    public enum cardtype { ASSASSIN, CASTER, GUNSLINGER, RIDER, SUPPORT, ELDRICH, FIGHTER }

    public cardtype type;

    public Sprite enemyImage;
}
