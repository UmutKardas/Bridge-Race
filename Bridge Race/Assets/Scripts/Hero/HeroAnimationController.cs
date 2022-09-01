using UnityEngine;

public class HeroAnimationController : MonoBehaviour
{

    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private Animator heroAnimator;



    public void SetHeroAnimation()
    {
        heroAnimator.SetBool("running", CheckHeroRunMovement());
    }



    public bool CheckHeroRunMovement()
    {
        return Mathf.Abs(heroDataTransmitter.GetHeroInput().x) > 0 || Mathf.Abs(heroDataTransmitter.GetHeroInput().z) > 0;
    }
}
