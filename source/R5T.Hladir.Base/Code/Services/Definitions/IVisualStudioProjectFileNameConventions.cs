using System;


namespace R5T.Hladir
{
    public interface IVisualStudioProjectFileNameConventions
    {
        string GetProjectName(string projectFileName);
        string GetProjectFileName(string projectName);
    }
}
