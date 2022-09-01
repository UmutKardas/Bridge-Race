using UnityEngine;

public class HeroRotateController : MonoBehaviour
{

    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private float lerpValue;



    void Update()
    {
        SetHeroRotate();
    }



    private void SetHeroRotate()
    {
        if (heroDataTransmitter.GetHeroInput().x > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 90f, 0f), lerpValue * Time.deltaTime);
        }

        else if (heroDataTransmitter.GetHeroInput().x < 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, -90f, 0f), lerpValue * Time.deltaTime);
        }

        else if (heroDataTransmitter.GetHeroInput().x > 0f && heroDataTransmitter.GetHeroInput().z > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 35f, 0), lerpValue * Time.deltaTime);
        }

        else if (heroDataTransmitter.GetHeroInput().z > 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), lerpValue * Time.deltaTime);
        }

        else if (heroDataTransmitter.GetHeroInput().z < 0f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180f, 0), lerpValue * Time.deltaTime);
        }
    }
}
