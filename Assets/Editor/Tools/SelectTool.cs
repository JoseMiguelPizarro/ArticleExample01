using UnityEngine;

public class SelectTool : LevelMeshTool
{
    public override string IconPath => "Assets/Resources/Icons/select.png";

    public override string ToolName => "Select tool";

    public override void Act(LevelMeshEditor editorState, Event current)
    {
        Debug.Log("I'm selecting something ;)");
    }
}
