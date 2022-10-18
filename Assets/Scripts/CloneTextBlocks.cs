using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneTextBlocks : MonoBehaviour
{
    public GameObject BluePrint;
    public int [] objectIDs;
    private bool isInit = false;

    [SerializeField]  private float Range;
    [SerializeField]  private int NumberOfClones;

    Vector3 targetPlace;
    Vector2 startPlace;
    private int direction;


    void createClones()
    {

        if (!isInit)
        {
            direction = 1;
            objectIDs = new int[NumberOfClones];
            for (int i = 1; i < NumberOfClones + 1; i++)
            {

                targetPlace = new Vector3((BluePrint.transform.position.x + Range) * i * direction, BluePrint.transform.position.y);
                Instantiate<GameObject>(BluePrint, targetPlace, Quaternion.identity, BluePrint.transform);
                objectIDs[i] = GetInstanceID();

            }
            isInit = true;
        }
    }


    private void FixedUpdate()
    {
        createClones();
    }
}
