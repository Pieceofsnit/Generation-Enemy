using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [HideInInspector] public Target Target;
    
    private void Update()
    {
        MoveToTarget();
    }  
    
    public void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, _speed * Time.deltaTime);
    }
}
