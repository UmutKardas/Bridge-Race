using UnityEngine;

public class HeroMovementController : MonoBehaviour
{

    [SerializeField] private HeroDataTransmitter heroDataTransmitter;
    [SerializeField] private Rigidbody heroRigidbody;
    [SerializeField] private float heroMovementSpeed;
    [SerializeField] private float lerpValue;



    void FixedUpdate()
    {
        SetHeroMovement();
    }



    private void SetHeroMovement()
    {
        heroRigidbody.velocity = new Vector3(heroDataTransmitter.GetHeroInput().x * heroMovementSpeed * Time.fixedDeltaTime,
        heroRigidbody.velocity.y,
        heroDataTransmitter.GetHeroInput().z * heroMovementSpeed * Time.fixedDeltaTime);
    }



    public void SetHeroClimb()
    {
        if (heroDataTransmitter.GetHeroInput().z >= 1)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), lerpValue);
        }
    }
}
