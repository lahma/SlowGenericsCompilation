using System.Threading.Tasks;

namespace ProblemTest;

public sealed record SomethingHappenedEvent1(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent2(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent3(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent4(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent5(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent6(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent7(string Data1, int Data2) : DomainEvent;
public sealed record SomethingHappenedEvent8(string Data1, int Data2) : DomainEvent;

public class SomethingHappenedConsumer : DomainEventConsumer<SomethingHappenedEvent1,
    SomethingHappenedEvent2,
    SomethingHappenedEvent3,
    SomethingHappenedEvent4,
    SomethingHappenedEvent5,
    SomethingHappenedEvent6,
    SomethingHappenedEvent7,
    SomethingHappenedEvent8>
{
    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent1> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent2> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent3> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent4> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent5> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent6> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent7> context) => throw new System.NotImplementedException();

    protected override Task ConsumeMessage(ConsumeContext<SomethingHappenedEvent8> context) => throw new System.NotImplementedException();
}