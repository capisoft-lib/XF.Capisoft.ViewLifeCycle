using System;
namespace XF.Capisoft.ViewLifeCycle
{
    public interface IViewLifecycle
    {
        void Loaded();
        void Unloaded();
    }
}
