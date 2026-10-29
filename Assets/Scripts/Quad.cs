using UnityEngine;

public class Quad : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;

		vertices[2] = new Vector3(0, 0, 0);

		mesh.vertices = vertices;
		mesh.RecalculateBounds();

		if (TryGetComponent<MeshCollider>(out var collider))
		{
			collider.sharedMesh = mesh;
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
