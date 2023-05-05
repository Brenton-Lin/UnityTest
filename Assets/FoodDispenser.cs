using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDispenser : MonoBehaviour
{
    public int FoodOption;
    public GameObject[] Foods;
   public void dropDownSelect(int index)
    {
        switch(index)
        {
            case 0: //dispense a burger
                FoodOption = index;
                break;
            case 1:
                FoodOption = index;
                break;
            case 2:
                FoodOption = index;
                break;
        }
    }

    public void dispense()
    {
        GameObject newFood = Instantiate(Foods[FoodOption],transform.position, transform.rotation);
    }
}
