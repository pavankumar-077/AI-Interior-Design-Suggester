using UnityEngine;

public class FurnitureManager : MonoBehaviour
{
    // =========================
    // PREFABS
    // =========================
    [Header("Prefabs")]
    public GameObject sofaPrefab;
    public GameObject tablePrefab;
    public GameObject chairPrefab;

    // =========================
    // MODERN VARIATIONS
    // =========================
    [Header("Modern Variations")]
    public Material modernLight;
    public Material modernDark;
    public Material modernLuxury;

    // =========================
    // MINIMAL VARIATIONS
    // =========================
    [Header("Minimal Variations")]
    public Material minimalWhite;
    public Material minimalGrey;
    public Material minimalWood;

    // =========================
    // STORED INSTANCES
    // =========================
    private GameObject sofa;
    private GameObject chair;
    private GameObject table;

    // =========================
    // SPAWN FUNCTION
    // =========================
    void SpawnFurniture()
    {
        sofa = Instantiate(sofaPrefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
        chair = Instantiate(chairPrefab, new Vector3(-2, 0.5f, 0), Quaternion.identity);
        table = Instantiate(tablePrefab, new Vector3(2, 0.5f, 0), Quaternion.identity);

        // Add Drag Script Automatically
        sofa.AddComponent<FurnitureDrag>();
        chair.AddComponent<FurnitureDrag>();
        table.AddComponent<FurnitureDrag>();
    }

    // =========================
    // CLEAR ROOM
    // =========================
    void ClearRoom()
    {
        if (sofa != null) Destroy(sofa);
        if (chair != null) Destroy(chair);
        if (table != null) Destroy(table);
    }

    // =========================
    // MANUAL BUTTON SUPPORT
    // =========================

    public void AddSofa()
    {
        GameObject obj = Instantiate(sofaPrefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
        obj.AddComponent<FurnitureDrag>();
    }

    public void AddChair()
    {
        GameObject obj = Instantiate(chairPrefab, new Vector3(-2, 0.5f, 0), Quaternion.identity);
        obj.AddComponent<FurnitureDrag>();
    }

    public void AddTable()
    {
        GameObject obj = Instantiate(tablePrefab, new Vector3(2, 0.5f, 0), Quaternion.identity);
        obj.AddComponent<FurnitureDrag>();
    }

    // =========================
    // -------- MODERN OPTIONS --------
    // =========================

    public void ApplyModernLight()
    {
        ClearRoom();
        SpawnFurniture();
        ApplyMaterial(modernLight);
    }

    public void ApplyModernDark()
    {
        ClearRoom();
        SpawnFurniture();
        ApplyMaterial(modernDark);
    }

    public void ApplyModernLuxury()
    {
        ClearRoom();
        SpawnFurniture();
        ApplyMaterial(modernLuxury);
    }

    // =========================
    // -------- MINIMAL OPTIONS --------
    // =========================

    public void ApplyMinimalWhite()
    {
        ClearRoom();
        SpawnFurniture();
        ApplyMaterial(minimalWhite);
    }

    public void ApplyMinimalGrey()
    {
        ClearRoom();
        SpawnFurniture();
        ApplyMaterial(minimalGrey);
    }

    public void ApplyMinimalWood()
    {
        ClearRoom();
        SpawnFurniture();
        ApplyMaterial(minimalWood);
    }

    // =========================
    // COMMON MATERIAL APPLY
    // =========================
    void ApplyMaterial(Material mat)
    {
        sofa.GetComponent<Renderer>().material = mat;
        chair.GetComponent<Renderer>().material = mat;
        table.GetComponent<Renderer>().material = mat;
    }
}