using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    [SerializeField] AudioSource gunfire;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            gunfire.Play();
        }
    }
}
