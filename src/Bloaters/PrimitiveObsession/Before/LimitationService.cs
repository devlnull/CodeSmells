namespace Bloaters.PrimitiveObsession.Before;

public class LimitationService
{
    public IEnumerable<DateTime> GetLimitedDays(DateTime startDate, DateTime endDate)
    {
        if (startDate == null || endDate == null)
            throw new Exception("start or end dates must not be null");
        
        if (startDate < endDate)
            throw new Exception("end date must be less than start date.");
        
        if (startDate == endDate)
            throw new Exception("start and end dates must not be equal.");

        return Enumerable.Range(1, 100)
            .Select(x => DateTime.Now.AddDays(x));
    }
}