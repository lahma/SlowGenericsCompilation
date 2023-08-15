using System;
using System.Threading.Tasks;

namespace ProblemTest;

public abstract class BaseTypes
{
    protected async Task DoConsume<T>(ConsumeContext<T> context, Func<ConsumeContext<T>, Task> action) where T : class, IBusMessage
    {
    }
}

public interface IBusMessage
{
}

public class ConsumeContext<T>
{
}

public abstract class DomainEventConsumerBase : BaseTypes
{
    protected DomainEventConsumerBase() : base()
    {
    }
}

public abstract class DomainEventConsumer<T> : DomainEventConsumerBase, IConsumer<T> where T : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T> context);
}

public record DomainEvent : IBusMessage
{
}

public interface IConsumer<T>
{
}

public abstract class DomainEventConsumer<T1, T2> : DomainEventConsumer<T1>, IConsumer<T2>
    where T1 : DomainEvent
    where T2 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T2> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T2> context);
}

public abstract class DomainEventConsumer<T1, T2, T3> : DomainEventConsumer<T1, T2>, IConsumer<T3>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T3> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T3> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4> : DomainEventConsumer<T1, T2, T3>, IConsumer<T4>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T4> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T4> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5> : DomainEventConsumer<T1, T2, T3, T4>, IConsumer<T5>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T5> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T5> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6> : DomainEventConsumer<T1, T2, T3, T4, T5>, IConsumer<T6>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T6> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T6> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7> : DomainEventConsumer<T1, T2, T3, T4, T5, T6>, IConsumer<T7>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T7> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T7> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7>, IConsumer<T8>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T8> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T8> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8>, IConsumer<T9>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T9> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T9> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IConsumer<T10>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T10> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T10> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IConsumer<T11>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T11> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T11> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IConsumer<T12>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
    where T12 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T12> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T12> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IConsumer<T13>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
    where T12 : DomainEvent
    where T13 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T13> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T13> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, IConsumer<T14>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
    where T12 : DomainEvent
    where T13 : DomainEvent
    where T14 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T14> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T14> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, IConsumer<T15>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
    where T12 : DomainEvent
    where T13 : DomainEvent
    where T14 : DomainEvent
    where T15 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T15> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T15> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, IConsumer<T16>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
    where T12 : DomainEvent
    where T13 : DomainEvent
    where T14 : DomainEvent
    where T15 : DomainEvent
    where T16 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T16> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T16> context);
}

public abstract class DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : DomainEventConsumer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, IConsumer<T17>
    where T1 : DomainEvent
    where T2 : DomainEvent
    where T3 : DomainEvent
    where T4 : DomainEvent
    where T5 : DomainEvent
    where T6 : DomainEvent
    where T7 : DomainEvent
    where T8 : DomainEvent
    where T9 : DomainEvent
    where T10 : DomainEvent
    where T11 : DomainEvent
    where T12 : DomainEvent
    where T13 : DomainEvent
    where T14 : DomainEvent
    where T15 : DomainEvent
    where T16 : DomainEvent
    where T17 : DomainEvent
{
    protected DomainEventConsumer() : base()
    {
    }

    public Task Consume(ConsumeContext<T17> context)
    {
        return DoConsume(context, ConsumeMessage);
    }

    protected abstract Task ConsumeMessage(ConsumeContext<T17> context);
}