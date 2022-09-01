using UnityEngine;
using Kardas;

public class HeroTriggerController : MonoBehaviour
{

    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private StepSpawnController stepSpawnController;



    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == other.tag)
        {
            heroDataTransmitter.AddNewWoodList(other.gameObject);
            other.gameObject.AddComponent<WoodRotateController>();
        }


        if (other.gameObject.CompareTag(TAG.STEPPOINT))
        {
            stepSpawnController.stepPoint = other.gameObject;
            heroDataTransmitter.CheckListAmount();
        }
    }



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(TAG.STEP))
        {
            heroDataTransmitter.SetHeroClimb();
        }
    }
}
