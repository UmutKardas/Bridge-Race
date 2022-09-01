using UnityEngine;

public class HeroDataTransmitter : MonoBehaviour
{

    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private HeroAnimationController heroAnimationController;
    [SerializeField] private HeroStackController heroStackController;
    [SerializeField] private HeroMovementController heroMovementController;



    public Vector3 GetHeroInput()
    {
        return heroInputController.heroInputVector;
    }



    public void SetHeroAnimation()
    {
        heroAnimationController.SetHeroAnimation();
    }



    public void AddNewWoodList(GameObject _wood)
    {
        heroStackController.AddNewWoodList(_wood);
    }



    public void CheckListAmount()
    {
        heroStackController.CheckListAmount();
    }



    public void SetHeroClimb()
    {
        heroMovementController.SetHeroClimb();
    }
}
