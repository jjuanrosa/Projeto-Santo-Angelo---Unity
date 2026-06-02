using UnityEngine;

[ExecuteAlways]
public class GenerateTrapicheSquare : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject benchPrefab;
    public GameObject lampPrefab;

    [ContextMenu("GERAR PRACA")]
    public void GenerateSquare()
    {
        ClearOldObjects();

        CreateMainFloor();

        CreateGarden(new Vector3(4,0,4));
        CreateGarden(new Vector3(-4,0,4));
        CreateGarden(new Vector3(4,0,-4));
        CreateGarden(new Vector3(-4,0,-4));

        CreateCentralPaths();

        CreateBench(new Vector3(0,0,6));
        CreateBench(new Vector3(0,0,-6));

        CreateLamp(new Vector3(6,0,6));
        CreateLamp(new Vector3(-6,0,6));
        CreateLamp(new Vector3(6,0,-6));
        CreateLamp(new Vector3(-6,0,-6));

        CreateTree(new Vector3(4,0,4));
        CreateTree(new Vector3(-4,0,4));
        CreateTree(new Vector3(4,0,-4));
        CreateTree(new Vector3(-4,0,-4));
    }

    void ClearOldObjects()
    {
        GameObject oldFloor = GameObject.Find("TrapicheSquareFloor");

        if(oldFloor != null)
        {
            DestroyImmediate(oldFloor);
        }
    }

    void CreateMainFloor()
    {
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);

        floor.name = "TrapicheSquareFloor";

        floor.transform.position = transform.position;

        floor.transform.localScale = new Vector3(2,1,2);

        Renderer renderer = floor.GetComponent<Renderer>();

        renderer.material.color = new Color(0.8f,0.75f,0.65f);
    }

    void CreateCentralPaths()
    {
        GameObject path1 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        path1.transform.position = transform.position + new Vector3(0,0.05f,0);

        path1.transform.localScale = new Vector3(1,0.1f,15);

        Renderer r1 = path1.GetComponent<Renderer>();

        r1.material.color = Color.gray;

        GameObject path2 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        path2.transform.position = transform.position + new Vector3(0,0.05f,0);

        path2.transform.localScale = new Vector3(15,0.1f,1);

        Renderer r2 = path2.GetComponent<Renderer>();

        r2.material.color = Color.gray;
    }

    void CreateGarden(Vector3 offset)
    {
        GameObject garden = GameObject.CreatePrimitive(PrimitiveType.Cube);

        garden.transform.position = transform.position + offset + new Vector3(0,0.1f,0);

        garden.transform.localScale = new Vector3(4,0.2f,4);

        Renderer renderer = garden.GetComponent<Renderer>();

        renderer.material.color = new Color(0.2f,0.5f,0.2f);
    }

    void CreateTree(Vector3 offset)
    {
        if(treePrefab == null)
            return;

        Instantiate(treePrefab, transform.position + offset, Quaternion.identity);
    }

    void CreateBench(Vector3 offset)
    {
        if(benchPrefab == null)
            return;

        Instantiate(benchPrefab, transform.position + offset, Quaternion.identity);
    }

    void CreateLamp(Vector3 offset)
    {
        if(lampPrefab == null)
            return;

        Instantiate(lampPrefab, transform.position + offset, Quaternion.identity);
    }
}