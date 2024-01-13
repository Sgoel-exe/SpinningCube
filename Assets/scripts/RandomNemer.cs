using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNemer : MonoBehaviour
{
    //private string alphabet = "abcdefghijklmnopqrstuvwxyz";
    //private string numbers = "0123456789";
    [SerializeField] private int length = 5;
    public Transform[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        //This is a very Computer science-y way of doing this, sorry
        //The other way that I have uses a "constant" literal, which I was not sure if I was allowed to do.
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].GetComponent<Renderer>().material.color = Random.ColorHSV();
            string name = cubes[i].ToString().GetHashCode().ToString();
            cubes[i].name = name.Substring(length);
            //cubes[i].name = RandomString(length);
        }   
    }

    /*string RandomString(int length)
    {
        string result = "";
        for (int i = 0; i < length; i++)
        {
            if(Random.Range(0, 2) == 0)
            {
                result += numbers[Random.Range(0, numbers.Length)].ToString();
            }
            else
            {
                result += alphabet[Random.Range(0, alphabet.Length)].ToString();
            }
        }
        return result;
    }
    */
}
