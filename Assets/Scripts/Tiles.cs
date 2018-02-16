using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiles : MonoBehaviour
{
    [HideInInspector]
    public int number;
    [HideInInspector]
    public bool blank;
    [HideInInspector]
    public PositionInGrid pos;

    [System.Serializable]
    public struct PositionInGrid
    {
        public int x;
        public int y;

        public PositionInGrid(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

	void Update ()
    {
		if(number == 0)
        {
            blank = true;
            transform.GetComponentInChildren<Text>().text = "";
        }
        else
        {
            blank = false;
        }
	}
}
