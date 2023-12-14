using BondYieldCalculator.Entities;

namespace BondYieldCalculator.GUI.Interfaces.Services
{
    internal interface IConfigService
    {
        Config Instance { get; }

        void Refresh();
    }
}
