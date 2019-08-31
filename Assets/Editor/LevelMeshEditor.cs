using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

[CustomEditor(typeof(LevelMesh))]
public class LevelMeshEditor : Editor
{

    private int toolBarWidth = 60;


    private GUIContent selectButton;
    private GUIContent resizeButton;

    private string selectButtonIconPath = "Assets/Resources/Icons/select.png";
    private string resizeButtonIconPath = "Assets/Resources/Icons/resize.png";





    private GUIContent[] toolsButton;
    private List<LevelMeshTool> tools;
    private LevelMeshTool activeTool;
    int m_selectedTool;
    int selectedTool
    {
        get => m_selectedTool;
        set
        {
            m_selectedTool = value;
            activeTool = tools[m_selectedTool];
        }
    }
    private void OnEnable()
    {
        tools = LevelMeshToolProvider.tools;
        toolsButton = tools.Select(t => t.Content).ToArray();
    }




    private void OnSceneGUI()
    {
        DrawToolBar(SceneView.lastActiveSceneView);
        activeTool.Act(this, Event.current);
    }


    public void DrawToolBar(SceneView view)
    {
        Rect rect = new Rect(0, 0, toolBarWidth, view.position.height);

        GUILayout.BeginArea(rect, EditorStyles.textArea);
        selectedTool = GUILayout.SelectionGrid(selectedTool, toolsButton, 1, EditorStyles.toolbarButton, GUILayout.Width(50), GUILayout.Height(50));


        GUILayout.EndArea();
    }


    private void DoAction()
    {
        switch (selectedTool)
        {
            case 0:
                Select();
                break;
            case 1:
                Resize();
                break;

            default:
                break;
        }
    }


    private void Select() { Debug.Log("I'm selecting something ;)"); }
    private void Resize() { Debug.Log("I'm resizing something ;)"); }

}
