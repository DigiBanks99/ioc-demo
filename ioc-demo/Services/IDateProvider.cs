using System;

namespace IocDemo.Services
{
    public interface IDateProvider
    {
        DateTimeOffset Provide(DateTimeOffset baseDate, int offset, DateOffsetType type);
    }
}
