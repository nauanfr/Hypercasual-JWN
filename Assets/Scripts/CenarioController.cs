using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioController : MonoBehaviour
{
    public float time;
    public GameObject _prefab;
    public Transform _reference;
    public Transform _container;
    public List<Transform> list;

    private void Awake()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        bool working = true;
        while (working)
        {
            GetFromPool();
            yield return new WaitForSeconds(time);
        }
    }

    private void GetFromPool()
    {
        foreach (Transform t in list) 
        {
            if (!t.gameObject.activeSelf)
            {
                t.GetComponent<PlatformMovement>().UpdateColorAndType(Random.Range(0,3));
                t.transform.position = _reference.position;
                t.gameObject.SetActive(true);
                return;
            }
        }
        GameObject platform = Instantiate(_prefab, _reference.position, Quaternion.identity, _container);
        platform.GetComponent<PlatformMovement>().UpdateColorAndType(Random.Range(0, 3));
        list.Add(platform.transform);
        return;
    }
}

