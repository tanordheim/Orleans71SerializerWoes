using Microsoft.Extensions.DependencyInjection;
using Orleans.Serialization;
using Orleans.Storage;
using Types;

var serviceCollection = new ServiceCollection()
    .AddSerializer()
    .BuildServiceProvider();
var serializer = new OrleansGrainStorageSerializer(serviceCollection.GetRequiredService<Serializer>());

var model = serializer.Deserialize<StateModel>(File.ReadAllBytes("payload.bin"));
Console.WriteLine("Deserialized value: {0}", model.Value);