using System.Collections;
using UnityEngine;

public class SerializedAttributes : MonoBehaviour
{
    [SerializeField] // correct usage
    private string privateField;
    
    [SerializeField] // redundant usage
    public string publicField;

    [SerializeField] // invalid usage
    private string PrivateProperty { get; set; }

    [SerializeField] // invalid usage
    static string staticField;

    [SerializeField] // invalid usage
    readonly field readonlyField;
}