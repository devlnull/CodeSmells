namespace Bloaters.PrimitiveObsession.After;

public class DateRange
{
    public DateRange(DateTime startDate, DateTime endDate)
    {
        if (startDate == null || endDate == null)
            throw new Exception("start or end dates must not be null");
        
        if (startDate < endDate)
            throw new Exception("end date must be less than start date.");

        StartDate = startDate;
        EndDate = endDate;
    }

    public DateTime EndDate { get; }

    public DateTime StartDate { get; }
}