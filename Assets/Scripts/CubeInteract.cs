using UnityEngine;

public class CubeInteract : Interactive
{
    bool rotating = false;
    public new void Interact()
    {
        rotating = !rotating;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (rotating)
        {
          transform.Rotate(new Vector3(1,1,-1)*Time.deltaTime*100);  
        } 
    }
}
