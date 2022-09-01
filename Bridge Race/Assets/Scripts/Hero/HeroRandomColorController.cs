using System.Collections.Generic;
using UnityEngine;
using Kardas;

public class HeroRandomColorController : MonoBehaviour
{

    [SerializeField] private Material heroMaterial;
    public List<Color> colorList = new List<Color>();
    private int randomColorNumber;



    void Start()
    {
        SetHeroRandomColor();
        SetHeroTag();
    }



    private void SetHeroRandomColor()
    {
        randomColorNumber = Random.Range(0, 4);
        heroMaterial.color = colorList[randomColorNumber];
    }



    private void SetHeroTag()
    {
        if (randomColorNumber == 0)
        {
            this.transform.parent.tag = TAG.PURPLE;
        }
        else if (randomColorNumber == 1)
        {
            this.transform.parent.tag = TAG.PINK;
        }
        else if (randomColorNumber == 2)
        {
            this.transform.parent.tag = TAG.BLUE;
        }
        else if (randomColorNumber == 3)
        {
            this.transform.parent.tag = TAG.ORANGE;
        }
    }
}
