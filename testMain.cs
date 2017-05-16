using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class testMain : MonoBehaviour {
    //public Tuple<int,int> tuple = new Tuple<int, int>();
    public Dictionary<Tuple<int,int>,int> dic = new Dictionary<Tuple<int,int>, int>();
    public List<Tuple<int,int>> list = new List<Tuple<int,int>>();

    public int stats = 0;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        switch (stats) {
        case 0:
            break;
        case 1:
            Tuple<int,int> tupleTemp1 = new Tuple<int, int> (1, 1);
            Tuple<int,int> tupleTemp2 = new Tuple<int, int> (2, 2);
            Tuple<int,int> tupleTemp3 = new Tuple<int, int> (3, 3);
            dic.Add (tupleTemp1,1);
            list.Add (tupleTemp1);
            dic.Add (tupleTemp2,2);
            list.Add (tupleTemp2);
            dic.Add (tupleTemp3,3);
            list.Add (tupleTemp3);
            stats = 0;
            break;
        case 2:
            foreach (Tuple<int,int> element in dic.Keys) {
                Debug.Log ("dic" + element.item1 + element.item2);
            }
            foreach (Tuple<int,int> element in list) {
                Debug.Log ("dic" + element.item1 + element.item2);
            }
            stats = 0;
            break;
        case 3:
            Tuple<int,int> target = new Tuple<int, int> (1, 1);

            int res;

            if (dic.TryGetValue (target,out res))
                Debug.Log ("found in dic");
            //if (list.Find (new Tuple<int,int>(1,1)))
            //    Debug.Log ("found in list");
            stats = 0;
            break;

        }

    }
}
