using Microsoft.Extensions.DependencyInjection;
using Orleans.Serialization;
using Orleans.Storage;
using Types;

var serviceCollection = new ServiceCollection()
    .AddSerializer()
    .BuildServiceProvider();
var serializer = new OrleansGrainStorageSerializer(serviceCollection.GetRequiredService<Serializer>());

var payload = new StateModel
{
    Value = Guid.NewGuid().ToString()
};
File.WriteAllBytes("payload.bin", serializer.Serialize(payload).ToArray());