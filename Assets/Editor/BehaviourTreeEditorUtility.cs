using UnityEditor;
using UnityEngine;

public static class BehaviourTreeEditorUtility
{
    public static Node CreateNode(BehaviourTree tree, System.Type type)
    {
        Node node = ScriptableObject.CreateInstance(type) as Node;
        node.name = type.Name;
        node.guid = System.Guid.NewGuid().ToString();
        
        
        Undo.RecordObject(tree, "Behaviour Tree (CreateNode)");
        tree.nodes.Add(node);

        if (!Application.isPlaying)
        {
            AssetDatabase.AddObjectToAsset(node, tree);
        }
        Undo.RegisterCreatedObjectUndo(node, "Behaviour Tree (CreateNode)");
        
        AssetDatabase.SaveAssets();
        return node;
    }

    public static void DeleteNode(BehaviourTree tree, Node node)
    {
        Undo.RecordObject(tree, "Behaviour Tree (DeleteNode)");
        tree.nodes.Remove(node);
        
        // AssetDatabase.RemoveObjectFromAsset(node);
        Undo.DestroyObjectImmediate(node);
        
        AssetDatabase.SaveAssets();
    }
}