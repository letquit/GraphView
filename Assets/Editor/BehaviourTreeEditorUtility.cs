using UnityEditor;
using UnityEngine;

public static class BehaviourTreeEditorUtility
{
    public static Node CreateNode(BehaviourTree tree, System.Type type)
    {
        Node node = ScriptableObject.CreateInstance(type) as Node;
        node.name = type.Name;
        node.guid = System.Guid.NewGuid().ToString();
        tree.nodes.Add(node);
        AssetDatabase.AddObjectToAsset(node, tree);
        AssetDatabase.SaveAssets();
        return node;
    }

    public static void DeleteNode(BehaviourTree tree, Node node)
    {
        tree.nodes.Remove(node);
        AssetDatabase.RemoveObjectFromAsset(node);
        AssetDatabase.SaveAssets();
    }
}