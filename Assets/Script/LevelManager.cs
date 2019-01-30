using UnityEngine;

public class LevelManager : MonoBehaviour
{
	public Texture2D map;
	public Transform parent;
	public ObjectColor[] Tiles;


	private void Awake()
	{
		for (int i = 0; i < map.width; i++)
		{
			for (int j = 0; j < map.height; j++)
			{
				Color color = map.GetPixel(i, j);
				foreach (var tile in Tiles)
				{
					if (tile.color == color)
					{
						Instantiate(tile.gameObject, new Vector3(i, j, 0), Quaternion.identity, parent);
					}
				}
			}
		}

	}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }

}
