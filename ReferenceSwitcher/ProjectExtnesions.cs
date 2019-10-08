using EnvDTE;

namespace ReferenceSwitcher
{
    public static class ProjectExtnesions
    {
        public static string GetAssemblyName(this Project project)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            return (string)project.Properties.Item("AssemblyName").Value;
        }
    }
}