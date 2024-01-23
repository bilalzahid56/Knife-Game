using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject area;
    [SerializeField]
    private GameObject knifePrefab;
    [SerializeField]
    private GameObject currentKnife;
    public int count = 10;
    public bool allow = true;
    public int countNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && allow)
       {
            allow = false;
            while(countNum < 8)
            {
                Invoke("FewSecondslater", 1.3f);
                count++;
            }
            
       }
    }
    void FewSecondslater()
    {
        
        Instantiate(currentKnife, area.transform.position, area.transform.rotation);
        
        allow = true;
    }
}
