using System.Collections.Generic;
using System;

public static class LevelMeshToolProvider
{
    public static List<LevelMeshTool> tools = new List<LevelMeshTool>();

    static LevelMeshToolProvider()
    {
        foreach (var type in GetAllTypes(AppDomain.CurrentDomain))
        {
            if (type.IsSubclassOf(typeof(LevelMeshTool)))
            {
                var t = Activator.CreateInstance(type) as LevelMeshTool;
                tools.Add(t);
            }
        }
    }


    private static IEnumerable<Type> GetAllTypes(AppDomain domain)
    {
        foreach (var assembly in domain.GetAssemblies())
        {
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                yield return type;
            }
        }
    }
}

