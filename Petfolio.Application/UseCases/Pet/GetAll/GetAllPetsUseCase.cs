using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Pitoco",
                    Type = Communication.Enums.PetType.Dog
                },

                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Billy",
                    Type = Communication.Enums.PetType.Dog
                }
            }
        };
    }
}
