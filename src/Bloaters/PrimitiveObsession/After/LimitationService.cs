namespace Bloaters.PrimitiveObsession.After;

public class LimitationService
{
    public IEnumerable<DateTime> GetLimitedDays(DateRange dateRange)
    {
        if (dateRange.StartDate == dateRange.EndDate)
            throw new Exception("start and end dates must not be equal.");

        return Enumerable.Range(1, 100)
            .Select(x => DateTime.Now.AddDays(x));
    }
}