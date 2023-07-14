using UnityEngine;

public enum projectileType
{
    arrow,arcane
};
public class ProjectTile : MonoBehaviour
{
    [SerializeField]
    int attackDamage;

    [SerializeField]
    projectileType ptype;

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }
    public projectileType PType
    {
        get
        {

            return pType;
        }
    }
}
