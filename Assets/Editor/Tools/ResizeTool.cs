using UnityEngine;

public class ResizeTool : LevelMeshTool
{
    public override string IconPath => "Assets/Resources/Icons/resize.png";

    public override string ToolName => "Resize";

    public override void Act(LevelMeshEditor editorState, Event current)
    {
        Debug.Log("I'm resizing something ;)");
    }
}
