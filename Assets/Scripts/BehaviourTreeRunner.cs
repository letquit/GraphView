using System;
using UnityEngine;

public class BehaviourTreeRunner : MonoBehaviour
{
    public BehaviourTree tree;

    private void Start()
    {
        tree = tree.Clone();
        // tree.Bind(GetComponent<AiAgent>());
        tree.Bind();
    }

    private void Update()
    {
        tree.Update();
    }
}
