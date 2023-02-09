using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHandling : MonoBehaviour
{
    [SerializeField] private GameObject sword;

    [Header("References")]
    [SerializeField] private Transform hip;
    [SerializeField] private Transform rightHand;
    [SerializeField] private Vector3 handPos;
    [SerializeField] private Vector3 handRot;
    [SerializeField] private Vector3 hipPos;
    [SerializeField] private Vector3 hipRot;


    public void SetSwordParent(int type)
    {
        switch (type)
        {
            case 0:
                sword.transform.parent = rightHand;
                sword.transform.localPosition = handPos;
                sword.transform.localRotation = Quaternion.Euler(handRot);
                Debug.Log("Hand");

                break;
            case 1:
                sword.transform.parent = hip;
                sword.transform.localPosition = hipPos;
                sword.transform.localRotation = Quaternion.Euler(hipRot);
                Debug.Log("Hip");

                break;
            default:
                sword.transform.parent = hip;
                sword.transform.position = hipPos;
                sword.transform.rotation = Quaternion.Euler(hipRot);
                break;
        }
    }
}
