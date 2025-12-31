using UnityEngine;
using System.Collections;


public class HandgunFire : MonoBehaviour
{
    [SerializeField] AudioSource gunfire;
    [SerializeField] GameObject handgun;
    [SerializeField] bool canFire=true;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(canFire==true)
            {
                canFire=false;
                StartCoroutine(FiringGun());

            }
        }
    }


IEnumerator FiringGun()
{
    gunfire.Play();
    handgun.GetComponent<Animator>().Play("HandgunFire");
    yield return new WaitForSeconds(0.25f);
    handgun.GetComponent<Animator>().Play("New State");
    yield return new WaitForSeconds(0.05f);
    canFire=true;
}

}
