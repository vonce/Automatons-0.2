using UnityEngine;
using System.Collections;

public class Status : MonoBehaviour {

    public GameObject target;
    public float range;
    public float sightRange;
    public float speed;
    public int[] statusMatrix;//matrix contains true or false corresponding to statuses ex. attacking, poison, crippled etc.

    void Update()
    {
        //this should turn off scripts based on what statuses are on (attacking fleeing, special)
        //action being taken; 0 = attacking, 1 = move to attack, 2 = flee, 3 = special, 4 = move to special etc.
        //
    }
}
