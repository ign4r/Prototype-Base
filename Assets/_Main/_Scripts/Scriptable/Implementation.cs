using UnityEngine;

public class Implementation : MonoBehaviour
{
    [SerializeField]
    private TypeMeteoriteData _exampleData;

    [SerializeField]
    private int speedExample;


    private void Start()
    {
        //Obtenemos la data del scriptableObject
        speedExample = _exampleData.Damage;


    }

}
