using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShowPath : MonoBehaviour
{
    private NavMeshAgent _meshAgent;
    private LineRenderer _playerLineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _meshAgent = GetComponent<NavMeshAgent>();
        _playerLineRenderer = GetComponent<LineRenderer>();

        _playerLineRenderer.startWidth = 0.15f;
        _playerLineRenderer.endWidth = 0.15f;
        _playerLineRenderer.positionCount = 0;
    }

    private void Update()
    {
        if (Vector3.Distance(_meshAgent.destination, transform.position) > _meshAgent.stoppingDistance)
        {
            DrawPath();
        }
    }

    public void SetDestination(Vector3 target)
    {
        _meshAgent.SetDestination(target);
    }

    // Draw the ppath the player will take to reah its destination
    private void DrawPath()
    {
        _playerLineRenderer.positionCount = _meshAgent.path.corners.Length;
        _playerLineRenderer.SetPosition(0, transform.position);

        if (_meshAgent.path.corners.Length < 2)
        {
            return;
        }

        for (int i = 1; i < _meshAgent.path.corners.Length; i++)
        {
            Vector3 destinationPosition = new Vector3(_meshAgent.path.corners[i].x, _meshAgent.path.corners[i].y, _meshAgent.path.corners[i].z);
            _playerLineRenderer.SetPosition(i, destinationPosition);
        }
    }
}
