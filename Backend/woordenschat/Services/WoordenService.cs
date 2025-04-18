using woordenschat.Services.IServices;

namespace woordenschat.Services;

public class WoordenService : IWoordenService
{
    public IEnumerable<Woorden> Woorden() 
    {
        return new List<Woorden> { 
            new Woorden { Id = 1, Woord = "Verwaand", Betekenis = "Arrogant, jezelf heel goed vinden en op andere neerkijkt" },
            new Woorden { Id = 2, Woord = "Ondermijnen", Betekenis = "iemand de grond in boren, buitensluiten, verzwakken" },
            new Woorden { Id = 3, Woord = "Cultiveren", Betekenis = "Aanbouwen, aankweken" },
         };
    }
}
