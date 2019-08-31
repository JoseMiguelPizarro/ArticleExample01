using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public abstract class LevelMeshTool
{
    public abstract string IconPath { get; }
    public abstract string ToolName { get; }
    public GUIContent Content { get; set; }
    public Texture2D IconTexture { get; set; }

    public abstract void Act(LevelMeshEditor editorState, Event current);
    public virtual void ReadKeyboardInput(LevelMeshEditor editorState, Event current) { }
    public virtual void DrawHandles() { }

    public virtual void DrawGUI(LevelMeshEditor editorState) { }

    public LevelMeshTool()
    {
        IconTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(IconPath);
        Content = new GUIContent(IconTexture);
    }
}
