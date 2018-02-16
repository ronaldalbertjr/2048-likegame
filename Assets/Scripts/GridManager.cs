using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    Canvas mainCanvas;
    [SerializeField]
    GameObject prefab;
    GameObject[,] grid = new GameObject[3,3];
    Command leftArrow;
    Command rightArrow;
    Command upperArrow;
    Command downArrow;
	void Start ()
    {
        leftArrow = new MoveLeft();
        rightArrow = new MoveRight();
        upperArrow = new MoveUp();
        downArrow = new MoveDown();

		for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            { 
                grid[i,j] = (GameObject) Instantiate(prefab);
                grid[i,j].transform.SetParent(mainCanvas.transform);
                grid[i,j].transform.localPosition = new Vector3(i - 1, j - 1) * prefab.GetComponent<RawImage>().rectTransform.rect.width;
                grid[i,j].transform.localRotation = Quaternion.Euler(0, 0, 0);
                grid[i, j].GetComponent<Tiles>().pos = new Tiles.PositionInGrid(i,j);
                grid[i, j].GetComponent<Tiles>().number = 0;
            }
        }
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            leftArrow.execute();
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            rightArrow.execute();
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            upperArrow.execute();
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            downArrow.execute();

	}

    public static void MoveLeft()
    {
    }

    public static void MoveRight()
    {
    }

    public static void MoveUp()
    {
    }

    public static void MoveDown()
    {
    }
}
