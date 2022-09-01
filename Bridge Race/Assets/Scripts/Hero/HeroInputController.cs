using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [HideInInspector] public Vector3 heroInputVector;



    void Update()
    {
        SetHeroInput();
        SetHeroAnimation();
    }



    private void SetHeroInput()
    {
        heroInputVector.x = Input.GetAxisRaw("Horizontal");
        heroInputVector.z = Input.GetAxisRaw("Vertical");
    }



    private void SetHeroAnimation()
    {
        heroDataTransmitter.SetHeroAnimation();
    }
}
