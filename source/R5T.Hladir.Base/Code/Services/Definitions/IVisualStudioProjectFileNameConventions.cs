using System;using R5T.T0064;


namespace R5T.Hladir
{[ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileNameConventions:IServiceDefinition
    {
        string GetProjectName(string projectFileName);
        string GetProjectFileName(string projectName);
    }
}
