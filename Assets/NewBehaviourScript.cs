using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public Rigidbody rb;

    void Start()
    {
        //Debug.Log("UwU OwO ;-; TwT -_- @-@ :/");

        //rb.useGravity = false;

        rb.AddForce(0, 300, -666);
    }

    void Update()
    {
        //rb.AddForce(0, 300, -666);
    }
}
