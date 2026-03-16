using UnityEngine;

public class WallColorChanger : MonoBehaviour
{
    public Material wallMaterial;

    public void ChangeToRed()
    {
        wallMaterial.color = Color.red;
    }

    public void ChangeToBlue()
    {
        wallMaterial.color = Color.blue;
    }

    public void ChangeToWhite()
    {
        wallMaterial.color = Color.white;
    }
}