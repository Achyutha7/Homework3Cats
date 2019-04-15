using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    //UI Text element created to display the fight text
    public Text fightText;
    //GameObject myCat is instantiated
    public GameObject myCat; 
    //Create a list of gameobjects of cats
    public List<GameObject> Cats = new List<GameObject>();
    
    
    public void Spawn(Vector3 position)
    {
        Instantiate(myCat).transform.position = position;
        fightText.text = "";
    }
    int listSize = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Make Z position the Z position of prefab object
            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, myCat.transform.position.z);

            Spawn(adjustZ);
            Cats.Add(myCat);
            myCat = Cats[0];
            

            foreach (GameObject mycat in Cats)
            {
                
                int listSize = Cats.Count;
                listSize++;
            }
            if (listSize > 8)
            {
                fightText.text = "Cats Fight!";
            }
        }
    }
}
