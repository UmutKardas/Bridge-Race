using UnityEngine;

public class WoodRotateController : MonoBehaviour
{

    private Transform heroGameobject;



    private void Start()
    {
        heroGameobject = GameObject.FindObjectOfType<HeroStackController>().heroGameobject.transform;
    }



    void Update()
    {
        SetWoodRotation();
    }



    private void SetWoodRotation()
    {
        transform.rotation = heroGameobject.transform.rotation;
    }
}
