using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEnemyState : MonoBehaviour
{
    public interface IEnemyState
    {
        void Enter(Enemy enemy);     // What happens when the state is entered
        void Update(Enemy enemy);    // What happens each frame
        void Exit(Enemy enemy);      // What happens when exiting the state
    }
}

