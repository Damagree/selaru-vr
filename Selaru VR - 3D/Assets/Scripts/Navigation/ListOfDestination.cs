using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class ListOfDestination : MonoBehaviour
{
    [SerializeField] private GameObject _content; // parrent for content
    [SerializeField] private GameObject _buttonDestination; // prefab button that will be instantiated
    [SerializeField] private NavMeshAgent _playerNavMesh; // player navigation mesh

    [SerializeField] private string _destinationTag; // tag destination

    private GameObject[] _destination; // array of destination object

    private void Awake()
    {
        _destination = GameObject.FindGameObjectsWithTag(_destinationTag); // add array of gameobject to variable
    }

    private void Start()
    {
        foreach (GameObject item in _destination)
        {
            GameObject newBtn = Instantiate(_buttonDestination, _content.transform); // instantiate object
            newBtn.GetComponentInChildren<TextMeshProUGUI>().text = item.name; // change button text to item name
            newBtn.name = item.name; // change new button name to item name
            Button clickBtn = newBtn.GetComponent<Button>(); // initialize clickBtn with Button
            clickBtn.onClick.AddListener(() => { _playerNavMesh.SetDestination(item.transform.position); }); // add onclick to set destination 
        }
    }


}
