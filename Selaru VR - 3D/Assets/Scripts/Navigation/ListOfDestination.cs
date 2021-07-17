using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class ListOfDestination : MonoBehaviour
{
    [SerializeField] private GameObject _content;
    [SerializeField] private GameObject _buttonDestination;
    [SerializeField] private NavMeshAgent _playerNavMesh;

    [SerializeField] private string _destinationTag;

    private GameObject[] _destination;

    private void Awake()
    {
        _destination = GameObject.FindGameObjectsWithTag(_destinationTag);
    }

    private void Start()
    {
        foreach (GameObject item in _destination)
        {
            GameObject newBtn = Instantiate(_buttonDestination, _content.transform);
            newBtn.GetComponentInChildren<TextMeshProUGUI>().text = item.name;
            newBtn.name = item.name;
            Button clickBtn = newBtn.GetComponent<Button>();
            clickBtn.onClick.AddListener(() => { _playerNavMesh.SetDestination(item.transform.position); });
        }
    }


}
