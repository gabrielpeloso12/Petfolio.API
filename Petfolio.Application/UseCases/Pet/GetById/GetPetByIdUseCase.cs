using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = 1,
            Name = "Ete",
            Type = Communication.Enums.PetType.Cat,
            Birthday = new DateTime(year: 2023, month: 01, day: 01)
        };
    }
}
