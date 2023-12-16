namespace BondYieldCalculator.Services
{
    using BondYieldCalculator.Entities.Dto;

    public interface IConfigService
    {
        Config Instance { get; }

        void Refresh();
    }
}
