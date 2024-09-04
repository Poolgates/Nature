using AltV.Net.EntitySync;
using AltV.Net.EntitySync.ServerEvent;
using AltV.Net.EntitySync.SpatialPartitions;

namespace Nature.Services
{
    public class ServerEntitySync
    {
        public static void LoadEntitySync()
        {
           AltEntitySync.Init(7, (threadId) => 200, (threadId) => false, 
              (threadCount, repository) => new ServerEventNetworkLayer(threadCount, repository),
              (entity, threadCount) => entity.Type, (entityId, entityType, threadCount) => entityType,
              (threadId) =>
              {
                  return threadId switch
                  {
                      // Marker
                      0 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Text
                      1 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Props
                      2 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Help Text
                      3 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Blips
                      4 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Dynamic Blip
                      5 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Ped
                      6 => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                      // Vehicel
                      // Player 
                      _ => new LimitedGrid3(50_000, 50_000, 100, 10_000, 10_000, 300),
                  };
              },
          new IdProvider());
        }
    }
}
