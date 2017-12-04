using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;

    private Renderer rend;
    public Vector3 positionOffset;

    private Color startColor;

    [Header("Optional")]
    public GameObject turret;

    BuildManager buildManager;


    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }
    
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }
    void OnMouseDown()
    {
        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't Build there! - TODO: Display on screen.");
            return;
        }

        buildManager.BuildTurretOn(this);

    }

    void OnMouseEnter()
    {

        if (buildManager.CanBuild)
            return;
       rend.material.color = hoverColor;
    }
    
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    
}