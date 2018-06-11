using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCreator : MonoBehaviour {

    private void Start()
    {
        ShapeHelper.CreatePlane(10, 5, true);
    }

}
