using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyTracker : MonoBehaviour
{
    public GameObject MeshAsset;
    public GameObject VRAsset;
    public Vector3 RotationOffset;
    public Vector3 PositionOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Position
        MeshAsset.transform.position = VRAsset.transform.position + PositionOffset / 10f;

        //Rotation mess
        Vector3 Rotate = VRAsset.transform.rotation.eulerAngles + RotationOffset;
        Quaternion Variable = Quaternion.identity;
        Variable.eulerAngles = Rotate;
        MeshAsset.transform.rotation = Variable;
    }
}
