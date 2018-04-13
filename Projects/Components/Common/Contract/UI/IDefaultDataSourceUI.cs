// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDefaultDataSourceUI.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IDefaultDataSourceUI type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract.UI
{
    public interface IDefaultDataSourceUI
    {
        object Parameters { get; set; }

        void LoadData();

        void SaveData();
    }
}