using UnityEngine;
using Kardas;

public class StepSpawnController : MonoBehaviour
{

    [SerializeField] private Material heroMaterial;
    [SerializeField] private GameObject stepPrefab;
    [HideInInspector] public GameObject stepPoint;

    private GameObject lastObject;
    private float stepYIncrease = 1f;
    private float stepZIncrease = 2f;



    public void SpawnStep()
    {
        stepPrefab.GetComponent<MeshRenderer>().material = heroMaterial;
        lastObject = Instantiate(stepPrefab, stepPoint.transform.position, Quaternion.identity);
        stepPoint.transform.position = new Vector3(stepPoint.transform.position.x, stepPoint.transform.position.y + stepYIncrease, stepPoint.transform.position.z + stepZIncrease);
        lastObject.tag = TAG.STEP;
    }
}
