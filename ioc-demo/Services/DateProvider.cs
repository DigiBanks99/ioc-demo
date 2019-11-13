using System;

namespace IocDemo.Services
{
    public class DateProvider : IDateProvider
    {
        public DateTimeOffset Provide(DateTimeOffset baseDate, int offset, DateOffsetType type) =>
            type switch
            {
                DateOffsetType.Seconds => Subtract(baseDate, TimeSpan.FromSeconds(offset)),
                DateOffsetType.Minutes => Subtract(baseDate, TimeSpan.FromMinutes(offset)),
                DateOffsetType.Hours => Subtract(baseDate, TimeSpan.FromHours(offset)),
                DateOffsetType.Days => Subtract(baseDate, TimeSpan.FromDays(offset)),
                _ => baseDate
            };

        private DateTimeOffset Subtract(DateTimeOffset baseDate, TimeSpan timeSpan) =>
            baseDate.Subtract(timeSpan);
    }
}
