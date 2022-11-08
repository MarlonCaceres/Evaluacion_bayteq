using evalucion_bayteq.Models;

namespace evalucion_bayteq.Services.Interfaces
{
    public interface IAPIService{
        public Task<List<PetModel>> GetDataPets();
    }
}