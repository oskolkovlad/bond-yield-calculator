namespace BondYieldCalculator.Services
{
    using BondYieldCalculator.Entities.Dto;

    public interface IConfigService : IService
    {
        Config Instance { get; }

        void Refresh();
    }
}
