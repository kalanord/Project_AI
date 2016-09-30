using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolController : MonoBehaviour {

    [SerializeField]
    private GameObject prefab; //I'll get from Unity the prefab I want to use the pool with
    [SerializeField]
    private int StartUpInstances; //How many instances I'll get for the pool as default (Value from Unity)

    private List<GameObject> mPool; //This list contains all objects from the pool
    //private int instancesOnGame; //How many instances are active on game
    
    void Start()
    {
        PopulatePool(); //this instantiates the selected prefab in mPool, repeats according to 
        //instancesOnGame = 0; //How many instances are active on game

        OtherInitializations(); //Used in the child class in order to implement more initializations if necessary.
    }

    void PopulatePool()
    {
        //Initializing mPool list
        mPool = new List<GameObject>();
        mPool.Clear();

        //Adding objects until I get the number of instances desired. 
        for (int i = 0; i < StartUpInstances; i++)
        {
            AddObject();
        }
    }

    void AddObject()
    {
        //First, instantiate the prefab in game
        GameObject instance = Instantiate(prefab);
        //I set the Object Pool as a parent of the new instance
        instance.transform.parent = this.transform;
        //I disable the new instance since I don't want it active yet
        instance.SetActive(false);
        //Then, I add it to the Pool
        mPool.Add(instance);
    }

    protected void ObjectRequest()
    {
        //If there aren't any available objects in the Pool, I add a new one.
        //if (instancesOnGame == mPool.Count)
            //AddObject();

        //This selected an inactive GO from the Pool
        int i = 0;
        while (mPool[i].activeInHierarchy)
            i++;

        //GameObject instance = mPool[i]; //Creating reference to an available object
        //mPool[i].transform.position = this.transform.position; //Setting object position
        //instancesOnGame++; //Updating the number of instances on game
        mPool[i].SetActive(true); //Enabling requested object
        //return instance;
    }

    protected virtual void OtherInitializations() { }
}
