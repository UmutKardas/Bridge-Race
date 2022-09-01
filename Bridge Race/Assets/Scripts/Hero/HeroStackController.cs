using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Kardas;

public class HeroStackController : MonoBehaviour
{

    [SerializeField] private StepSpawnController stepSpawnController;
    [SerializeField] private float verticalIncrementValue;
    [SerializeField] private GameObject lastObject;
    [SerializeField] private float moveTime;

    public List<GameObject> woodList = new List<GameObject>();
    public GameObject heroGameobject;



    public void AddNewWoodList(GameObject _wood)
    {
        woodList.Add(_wood);
        _wood.transform.parent = heroGameobject.transform;
        _wood.transform.DOLocalMove(new Vector3(0, lastObject.transform.localPosition.y + verticalIncrementValue, lastObject.transform.localPosition.z), moveTime);
        lastObject = _wood;
    }



    private void RemoveWoodList()
    {
        woodList.Remove(lastObject);
        Destroy(lastObject);
        if (woodList.Count > 0)
        {
            lastObject = woodList[woodList.Count - 1];
        }

        else
        {
            lastObject = GameObject.FindGameObjectWithTag(TAG.STACKPOINT);
        }
    }



    public void CheckListAmount()
    {
        if (woodList.Count > 0)
        {
            RemoveWoodList();
            stepSpawnController.SpawnStep();
        }
    }
}
